using System;
using System.Windows;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

public struct LoginResponse {
   int status;
}

public class Client
{
    private const string SERVERIP = "127.0.0.1";
    private const int SERVERPORT = 7722;

    private TcpClient tcpClient;
    private NetworkStream stream;
    private string serverMsg;

    public void Start()
    {
        tcpClient = new TcpClient();
        try
        {
            tcpClient.Connect(SERVERIP, SERVERPORT);
            stream = tcpClient.GetStream();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            Dispose();
        }
    }
    public NetworkStream GetStream() { return stream; }

    private void GetResponse() {
        try
        {
            byte[] msgCodeBuffer = new byte[1];
            stream.Read(msgCodeBuffer, 0, 1);
            byte msgCode = msgCodeBuffer[0];

            byte[] lenBuffer = new byte[4];
            stream.Read(lenBuffer, 0, 4);
            int len = BitConverter.ToInt32(lenBuffer, 0);

            byte[] msgBuffer = new byte[len];
            stream.Read(msgBuffer, 0, len);
            serverMsg = Encoding.ASCII.GetString(msgBuffer);

            Console.WriteLine($"{msgCode}, {len}, {serverMsg}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }




    public T DeserializeResponse<T>()
    {

         return JsonConvert.DeserializeObject<T>(serverMsg);
    }

    public void SendRequest(int code, object request) {
       byte[] bytes = this.SerializeRequest(code,request);
       this.stream.Write(bytes, 0, bytes.Length);
       this.GetResponse();
    }

    public byte[] SerializeRequest(int code, object request)
    {
        string jsonString = JsonConvert.SerializeObject(request);
        byte[] jsonBytes = Encoding.ASCII.GetBytes(jsonString);
        return CombineByteArrays(new byte[] { (byte)code }, BitConverter.GetBytes(jsonBytes.Length), jsonBytes);
    }

    public byte[] CombineByteArrays(params byte[][] arrays)
    {
        byte[] result = new byte[arrays.Sum(a => a.Length)];
        int offset = 0;
        foreach (byte[] array in arrays)
        {
            Buffer.BlockCopy(array, 0, result, offset, array.Length);
            offset += array.Length;
        }
        return result;
    }

    public void Dispose()
    {
        stream?.Dispose();
        tcpClient?.Close();
    }
}

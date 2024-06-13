import socket
import json

SERVERIP = '127.0.0.1'
SERVERPORT = 7722

def client():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
        server_address = (SERVERIP, SERVERPORT)
        try:
            sock.connect(server_address)
        except Exception as e:
            print("error:",e ) #printing error
            exit()
        
        choice = input("Login Or Sign Up\nFor Login Enter 'L' And To Sign Up Enter 'S'\n")
        while choice != 'S' and choice != 'L' and choice != 'l' and choice != 's': #until we get other requests
            choice = input("Login Or Sign Up\nFor Login Enter 'L' And To Sign Up Enter 'S'\n")
        
        if choice == 's' or choice == 'S' :
            signupReq(sock)
        else:
            loginReq(sock)

        #desirialize - need to get it into a function
        msg_code = sock.recv(1)
        len = int.from_bytes(sock.recv(4), byteorder='big')
        msg = sock.recv(len).decode("ASCII")


        print(msg_code, len, msg)
        



        




def serializeLoginOrSignup(code,username,password):
    json_object = {}
    if code == 11:
        json_object =  createJsonObjectLoginOrSignup(code,password,username)

    elif code == 10:
        json_object = createJsonObjectLoginOrSignup(code,password,username)
    else :
        return (0).to_bytes(1,'big') + len(5).to_bytes(4,'big') + "Error".encode("ASCII")
    if json_object is not {} and username != "" and password != "" :
        dic_str = json.dumps(json_object)
        return (code).to_bytes(1, 'big') + len(dic_str).to_bytes(4,'big') + dic_str.encode("ASCII")
    return (0).to_bytes(1,'big') + len(5).to_bytes(4,'big') + "Error".encode("ASCII")


def createJsonObjectLoginOrSignup(code,password,username):
    if code == 11:
        mail = input("Enter new mail:\n")
        #when has db need to check in server code if user exsist with the given mail!

        dict = {"username" : username , "password" : password , "mail" : mail}
        return dict
    else:
        dict = {"username" : username , "password" : password}
        return dict


def loginReq(sock):
    code = 10
    username,password = getUsernameAndPassword()
    msg = serializeLoginOrSignup(code,username,password)
    sock.sendall(msg)



    



def signupReq(sock):
    code = 11
    username,password = getUsernameAndPassword()
    msg = serializeLoginOrSignup(code,username,password)
    sock.sendall(msg)
    


    
#def deserialize_response():
    #TODO




def getUsernameAndPassword():
    username = input("Enter username:\n")
    password = input("Enter password:\n")
    return username,password

def main():
    client()

if __name__ == "__main__":
    main()




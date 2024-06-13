from dataclasses import dataclass
import requests as req
import html
import json
import sqlite3
import sys
from typing import List

@dataclass
class Question:
    content: str
    correct: str
    wrongs: List[str]


def unescape_json(input):
    if type(input) is dict:
        output = {}
        for key, value in input.items():
            key = html.unescape(key)
            value = unescape_json(value)
            output[key] = value
        return output
    elif type(input) is list:
        output = []
        for value in input:
            value = unescape_json(value)
            output.append(value)
        return output
    elif type(input) is str:
        return html.unescape(input)
    else:
        return input


def get_questions(amount: int = 10) -> List[Question]:
    response_text_raw = req.get(f"https://opentdb.com/api.php?amount={amount}&type=multiple").text
    response_raw_json = json.loads(response_text_raw)
    response = unescape_json(response_raw_json)
    # print(response)

    code = response['response_code']
    if code != 0:
        raise Exception(f"unable to get questions from opentdb: {code}")

    questions: List[Question] = []
    for result in response['results']:
        question = Question(
            content=result['question'],
            correct=result['correct_answer'],
            wrongs=result['incorrect_answers']
        )
        questions.append(question)

    return questions


def add_questions_to_db(path: str, questions: List[Question]):
    with sqlite3.connect(path) as conn:
        cursor = conn.cursor()
        create_table_statement = "CREATE TABLE IF NOT EXISTS question (content TEXT UNIQUE, correct TEXT, wrong1 TEXT, wrong2 TEXT, wrong3 TEXT);"
        cursor.execute(create_table_statement).fetchone()
        for question in questions:
            query = "INSERT INTO question (content, correct, wrong1, wrong2, wrong3) VALUES (?, ?, ?, ?, ?);"
            params = (question.content, question.correct, *question.wrongs)
            # print(query)
            # print(params)
            try:
                cursor.execute(query, params).fetchone()
            except sqlite3.Error as err:
                if err.sqlite_errorcode == sqlite3.SQLITE_CONSTRAINT_UNIQUE:
                    continue  # don't care, just continue
                raise err


def main():
    if len(sys.argv) > 1:
        path = sys.argv[1]
    else:
        path = 'TriviaDB.db'

    try:
        questions = get_questions(100)
        add_questions_to_db(path, questions)
        print("DONE!")
    except Exception as e:
        print("ERROR:", e)


if __name__ == "__main__":
    main()

from operator import itemgetter

class Faculty:
    def __init__(self, faculty_id, faculty_name):
        self.faculty_id = faculty_id
        self.faculty_name = faculty_name
        self.departments = []

class Department:
    def __init__(self, department_id, department_name, faculty_id):
        self.department_id = department_id
        self.department_name = department_name
        self.faculty_id = faculty_id
        self.professors = []

class Professor:
    def __init__(self, professor_id, professor_name, salary, department_id):
        self.professor_id = professor_id
        self.professor_name = professor_name
        self.salary = salary
        self.department_id = department_id

# Факультеты
faculties = [
    Faculty(1, "Информатика, искусственный интеллект и системы управления"),
    Faculty(2, "Робототехника и комплексная автоматизация"),
]

# Кафедры
departments = [
    Department(101, "Системы обработки информации и управления", 1),
    Department(102, "Программное обеспечение ЭВМ и информационные технологии", 1),
    Department(201, "Инженерная графика", 2),
]

# Преподаватели
professors = [
    Professor(1001, "Белов Кирилл Иванович", 60000, 101),
    Professor(1002, "Морозов Дмитрий Александрович", 55000, 101),
    Professor(1003, "Андреев Егор Даниилович", 62000, 102),
    Professor(2001, "Кравцов Арсений Артемьевич", 58000, 201),
]

def main():
    # Соединение данных один-ко-многим
    one_to_many = [(professor.professor_name, department.department_name)
                   for professor in professors
                   for department in departments
                   if professor.department_id == department.department_id]

    # Задание 1: Вывести список сотрудников, фамилия которых начинается с "А", и названия их отделов
    result_1 = [(professor_name, department_name) for professor_name, department_name in one_to_many if professor_name.startswith("А")]
    result_1.sort(key=itemgetter(0))
    print("Задание В1:")
    print(result_1)

    # Задание 2: Вывести список отделов с минимальной зарплатой сотрудников в каждом отделе
    result_2 = []
    for department in departments:
        department_professors = [professor for professor in professors if professor.department_id == department.department_id]
        if department_professors:
            min_salary = min(professor.salary for professor in department_professors)
            result_2.append((department.department_name, min_salary))
    result_2.sort(key=itemgetter(1))
    print("\nЗадание В2:")
    print(result_2)

    # Соединение данных многие-ко-многим
    many_to_many_temp = [(department.department_name, professor.professor_name)
                         for department in departments
                         for professor in professors
                         if professor.department_id == department.department_id]

    # Задание 3: Вывести список всех связанных сотрудников и отделов, отсортированный по сотрудникам
    result_3 = [(professor_name, department_name) for department_name, professor_name in many_to_many_temp]
    result_3.sort(key=itemgetter(0))
    print("\nЗадание В3:")
    print(result_3)

if __name__ == '__main__':
    main()

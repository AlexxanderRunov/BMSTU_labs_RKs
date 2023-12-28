import unittest
from main import Faculty, Department, Professor, get_one_to_many_association, get_min_salary_per_department, \
    get_many_to_many_association, filter_professors_by_name, sort_association_by_key


class TestFacultyDepartmentProfessor(unittest.TestCase):

    def setUp(self):
        self.faculties = [
            Faculty(1, "Информатика, искусственный интеллект и системы управления"),
            Faculty(2, "Робототехника и комплексная автоматизация"),
        ]

        self.departments = [
            Department(101, "Системы обработки информации и управления", 1),
            Department(102, "Программное обеспечение ЭВМ и информационные технологии", 1),
            Department(201, "Инженерная графика", 2),
        ]

        self.professors = [
            Professor(1001, "Белов Кирилл Иванович", 60000, 101),
            Professor(1002, "Морозов Дмитрий Александрович", 55000, 101),
            Professor(1003, "Андреев Егор Даниилович", 62000, 102),
            Professor(2001, "Кравцов Арсений Артемьевич", 58000, 201),
        ]

    def test_filter_professors_by_name(self):
        one_to_many_association = get_one_to_many_association(self.professors, self.departments)
        result = filter_professors_by_name("А", one_to_many_association)
        self.assertEqual(result,
                         [("Андреев Егор Даниилович", "Программное обеспечение ЭВМ и информационные технологии")])

    def test_get_min_salary_per_department(self):
        result = get_min_salary_per_department(self.departments, self.professors)
        self.assertEqual(result, [('Системы обработки информации и управления', 55000),
                                  ('Инженерная графика', 58000),
                                  ('Программное обеспечение ЭВМ и информационные технологии', 62000)])

    def test_get_many_to_many_association(self):
        result = get_many_to_many_association(self.departments, self.professors)
        self.assertEqual(result, [("Системы обработки информации и управления", "Белов Кирилл Иванович"),
                                  ("Системы обработки информации и управления", "Морозов Дмитрий Александрович"),
                                  ("Программное обеспечение ЭВМ и информационные технологии", "Андреев Егор Даниилович"),
                                  ("Инженерная графика", "Кравцов Арсений Артемьевич")])


if __name__ == '__main__':
    unittest.main()

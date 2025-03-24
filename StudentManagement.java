package Demo;

import java.util.ArrayList;
import java.util.Scanner;

    // Class Student
class Student {
    private String fullName;
    private int age;
    private String id;

    // Constructor
    public Student(String fullName, int age, String id) {
        this.fullName = fullName;
        this.age = age;
        this.id = id;
    }

    // Getters and Setters
    public String getFullName() {
        return fullName;
    }

    public void setFullName(String fullName) {
        this.fullName = fullName;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    @Override
    public String toString() {
        return "ID: " + id + ", Name: " + fullName + ", Age: " + age;
    }
}

// Class StudentManagement
public class StudentManagement {
    private static final ArrayList<Student> studentList = new ArrayList<>();
    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        while (true) {
            System.out.println("\n=== STUDENT MANAGEMENT ===");
            System.out.println("1. Enter student list");
            System.out.println("2. Find students by last name");
            System.out.println("3. Find and edit students by full name");
            System.out.println("4. End");
            System.out.print("Choose an option: ");
            int choice = Integer.parseInt(scanner.nextLine());

            switch (choice) {
                case 1 -> enterStudentList();
                case 2 -> findStudentsByLastName();
                case 3 -> findAndEditStudentByFullName();
                case 4 -> {
                    System.out.println("Exiting program. Goodbye!");
                    return;
                }
                default -> System.out.println("Invalid option! Please choose again.");
            }
        }
    }

    private static void enterStudentList() {
        System.out.print("Enter number of students: ");
        int n = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < n; i++) {
            System.out.println("Enter details for student " + (i + 1) + ":");
            System.out.print("Full name: ");
            String fullName = scanner.nextLine();
            System.out.print("Age: ");
            int age = Integer.parseInt(scanner.nextLine());
            System.out.print("ID: ");
            String id = scanner.nextLine();
            studentList.add(new Student(fullName, age, id));
        }
        System.out.println("Student list updated!");
    }

    private static void findStudentsByLastName() {
        System.out.print("Enter last name to search: ");
        String lastName = scanner.nextLine();
        boolean found = false;
        for (Student student : studentList) {
            String[] nameParts = student.getFullName().split(" ");
            if (nameParts[nameParts.length - 1].equalsIgnoreCase(lastName)) {
                System.out.println(student);
                found = true;
            }
        }
        if (!found) {
            System.out.println("No students found with the last name: " + lastName);
        }
    }

    private static void findAndEditStudentByFullName() {
        System.out.print("Enter full name to search: ");
        String fullName = scanner.nextLine();
        for (Student student : studentList) {
            if (student.getFullName().equalsIgnoreCase(fullName)) {
                System.out.println("Student found: " + student);
                System.out.println("Enter new details:");
                System.out.print("New full name: ");
                student.setFullName(scanner.nextLine());
                System.out.print("New age: ");
                student.setAge(Integer.parseInt(scanner.nextLine()));
                System.out.print("New ID: ");
                student.setId(scanner.nextLine());
                System.out.println("Student details updated!");
                return;
            }
        }
        System.out.println("No student found with the full name: " + fullName);
    }
}

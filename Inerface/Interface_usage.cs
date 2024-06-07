using System;

interface MyInterface
{
    void Functionality();
}

class Pencil:MyInterface
{
    public void Functionality()
    {
        Console.WriteLine("Writing the words");
    }
}

class Eraser : MyInterface
{
    public void Functionality()
    {
        Console.WriteLine("Erasing the words");
    }
}


class Student
{
    MyInterface Interfacel;
    public Student (MyInterface interface_obj)
    {
        Interfacel = interface_obj;
    }

    public void TaskMethod()
    {
        Interfacel.Functionality();
    }
}

class Test
{
    public static void Main(String[] args)
    {
        MyInterface passiing_func = new Eraser();
        Student student = new Student(passiing_func);
        student.TaskMethod();
    }
}

> <h2> This is my study assignment in Test_CS folder.

> <h3> There is a class, its objects should allow you to work with a person's personal data: surname, gender, date of birth, residential address Correct the mistakes made when writing this class. <h3>
```C#
class Person
{
public string Firstname { get; set; } public DateTime Birthday { get; set; } public char Gender
{
get { return _gender; } set {
if (value == 'м') _gender = Char.ToUpper(value); else _gender = '-';
} }
public int Age()
{
int a = DateTime.Today.Year - Birthday.Year; a--; return a;
}
}
```
> <h3> Write a console application that allows: <h3>
1. Enter the data of several people from the keyboard or from a file.
2. Output to the screen or to a file on disk:
- [X] The number of people with the date of birth specified by the user;
- [X] Average weight of children (under 18 years old)
- [X] A list of the group, sorted in descending order of growth

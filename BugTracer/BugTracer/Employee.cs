using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracer
{
    public class Employee
    {
       public string name;
       public int number;
       private string position;
       private string email;
       private string password;

       public string GetName()
       {
           string _name = name;
           return _name;
       }
       public int GetNumber()
       {
           int _number = number;
           return _number;
       }
       public string GetPosition()
       {
           string _position = position;
           return _position;
       }
       public string GetEmail()
       {
           string _email = email;
           return _email;
       }
       public string GetPassword()
       {
           string _password = password;
           return _password;
       }
       public void SetName(string _name)
       {
           name = _name;
       }
       public void SetNumber(int _number)
       {
           number = _number;
       }
       public void SetPosition(string _position)
       {
           position = _position;
       }
       public void SetEmail(string _email)
       {
           email = _email;
       }
       public void SetPassword(string _password)
       {
           password = _password;
       }
    }
}

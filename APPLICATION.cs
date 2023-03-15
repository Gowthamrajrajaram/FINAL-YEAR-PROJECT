using System;
using System.IO;
using System.Collections.Generic;
public class Ticket
{
  private int seatnum;
  private int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
  private int[] g = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
  private int[] p = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
  public void Balcony (int seatnum)
  {
    if (b[seatnum - 1] != 0)
      {
	b[seatnum - 1] = 0;
	Console.WriteLine ("Your booking is sucessful");
      }
    else
      {
	Console.WriteLine ("sorry Seat was already booked");
      }
  }
  public void Gold (int seatnum)
  {
    if (g[seatnum - 1] != 0)
      {
	g[seatnum - 1] = 0;
	Console.WriteLine ("Your booking is sucessful");
      }
    else
      {
	Console.WriteLine ("sorry Seat was already booked");
      }

  }
  public void Platinum (int seatnum)
  {
    if (p[seatnum - 1] != 0)
      {
	p[seatnum - 1] = 0;
	Console.WriteLine ("Your booking is sucessful");
      }
    else
      {
	Console.WriteLine ("sorry Seat was already booked");
      }

  }
}

class testing
{
  public static void Main (string[]args)
  {
    int Seat_no,Choice;
    Ticket Tick=new Ticket();
    while (Convert.ToBoolean(1))
      {
	Console.WriteLine ("GKM Imax Theaters online ticket booking : ");
	Console.WriteLine ("1. Balcony");
	Console.WriteLine ("2. Gold");
	Console.WriteLine ("3. Platinum");
	Console.WriteLine ("4. Exit");
	Console.WriteLine ("Enter your choice: ");
	Choice=Convert.ToInt32(Console.ReadLine ());

	switch (Choice)
	  {
	  case 1:
	    Console.WriteLine ("Enter your Seat_no: ");
	    Seat_no=Convert.ToInt32(Console.ReadLine());
	    Tick.Balcony (Seat_no);
	    break;

	    case 2:Console.WriteLine ("Enter your Seat_no: ");
	    Seat_no=Convert.ToInt32(Console.ReadLine());
	    Tick.Gold (Seat_no);
	    break;

	    case 3:Console.WriteLine ("Enter your Seat_no: ");
	    Seat_no=Convert.ToInt32(Console.ReadLine());
	    Tick.Platinum (Seat_no);
	    break;

	    case 4:Environment.Exit (1);
	    break;
	    
	    default: Console.WriteLine ("Your choice is not ine the list");
	    break;

	  }
    }
  }
}
class program
{
class Administration
{
private List<string?> adminnames = new List<string?>();
private List<string?> adminpassword = new List<string?>();
public void display()//displaying a choice for user to choose a valid
options
{
Console.WriteLine("Select your choice : ");
Console.WriteLine("1.New Registration");
Console.WriteLine("2.Usre Login");
Console.WriteLine("3.User Logout");
}
public void adminregistration()//admin new registration
{
bool flag=true;
bool count=true;
while(count)
{
Console.Write("Enter your Name: ");
string? name=Console.ReadLine();
bool exit=adminnames.Contains(name);
if(exit)
{
Console.WriteLine("Sorry! your admin name are already exists

and Try another admin name");

}
else

{
adminnames.Add(name);
Console.Write("Your Password: ");
adminpassword.Add(Console.ReadLine());
count=false;
}
}
while(flag)
{
bool isnamePresent = adminnames.Contains(" ");
bool ispasswordPresent = adminpassword.Contains(" ");
if(isnamePresent||ispasswordPresent)
{
Console.Write("Enter your Name: ");
adminnames.Add(Console.ReadLine());
Console.Write("Your Password: ");
adminpassword.Add(Console.ReadLine());
flag = false;
}
else
{
flag=false;
}

}
class Loginmodule
{
public void loginchoise()
{
bool flag=true;
Console.WriteLine("Select your choice : User or Admin");
Console.Write("Enter your choice : ");
string? choise=Console.ReadLine();
if(choise=="user") //users
{
userlogin login = new userlogin();
while(flag)
{
login.display();
int option=Convert.ToInt32(Console.ReadLine());
switch(option)
{
case 1: login.userregistration();
break;
case 2: login.userslogin();
break;
case 3: flag=false;
break;
default:Console.WriteLine("Invalid choise you have been

choosed");

break;

}
}
}
}
}

else if(choise=="admin") //admin
{
Administration log= new Administration();
while(flag)
{
log.display();
int option=Convert.ToInt32(Console.ReadLine());
switch(option)
{
case 1: log.adminregistration();
break;
case 2: log.adminlogin();
break;
case 3: flag=false;
break;
default:Console.WriteLine("Invalid choise you have been choosed");

break;

}
}
}
else
{
Console.WriteLine("Sorry invalid Choise you have been choosed");
}

}
public static void Main(string[] args)
{
Console.WriteLine("Welcome to Muthukumaran shoping");
Loginmodule login = new Loginmodule();
login.loginchoise();
}
}
}
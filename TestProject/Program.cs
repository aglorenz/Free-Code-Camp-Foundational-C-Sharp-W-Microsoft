string permission = "Manadger";
int level = 19;
string message = "";

if (permission.Contains("Admin")) 
{
   message =  level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.";
}
else if (permission.Contains("Manager"))
{
    message = level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";
}
else message = "You do not have sufficient privileges.";

Console.WriteLine(message);


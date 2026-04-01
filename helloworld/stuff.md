.Replace replaces all instances of match , and does not mutate original data !

Strings are IMMUTABLE ! once created they cannot be changed

Basically all (if not all) methods return a new string (ToUpper , ToLower , Replace etc)!

C# compiler doesnt care about spaces/white spaces (unless we are talking about strings then it matters) you can write everything on one line with ; and it will compiler fine !

defining a public class you can use the name of the class in other files in the same project or if its explicidly shared !

Since .net 6 you dont have to define main calss and public void in the Program.cs , it introduced top level statements

int can store only up to 32 bit integers (around 2.1bil) , long can store up to 64 bit integeres (basically HUMONGOUS);

checked() checks at RUNTIME , if the calculation you are doing would overflow !

float allows decimals and is a 32bit , double also allows decimals and it is a 64bit both use floating point which sometimes has precision errors, and decimal is accurate but it is a 128 bit integer !;

C# does NOT have truthy/falsy data , its either TRUE or FALSE !

After the if/elseif/else statment you can have ONE LINE without {} but if you want to have some logic or more than one line you NEED to put {} after the statement !

A singilur = means assignment to a value , two == means "equal"

C# is a compiled language , the code compiles before running to Intermediate Language (IL) , then the .NET runtime gets that code and makes it into machine code ! (Just In Time compilation);

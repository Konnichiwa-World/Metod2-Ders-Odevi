using System;

class Piramid{
public static void Main(string[] args){
int a,b,c,d,e;string[] Patika = {" ", "P","A","T","I","K","A"};
System.Console.WriteLine("Luften, olusacak piramit için yukseklik belirtiniz:");
Int32 z =Int32.Parse(Console.ReadLine());
for(a=1;a<=z;a++){
    if(a%2==1){
    for(b=z;b>=a;b--){System.Console.Write(" ");}
    for(c=1;c<=a;c++){System.Console.Write("*"+Patika[a]+"*");}
    System.Console.WriteLine("");}
    if(a%2==0){
    for(d=z;d>=a;d--){System.Console.Write(" ");}
    for(e=1;e<=a;e++){System.Console.Write("*"+Patika[a]+"*");}
    System.Console.WriteLine("");}
}
}}

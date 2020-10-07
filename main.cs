using System;

class MainClass {
  public static void Main (string[] args) {


 /* I PUT AN INPUT FOR HOW MANY PEOPLE WE WOULD BE
  CALCULATING THE BMI FOR EVEN THOUGH THE DIRECTIONS SAID 10. 
  I feel that this made it easier for me to do the trial code!!*/

 Console.WriteLine("How many people are we calculating the BMI for?"); //input for how much the counter will go up to
 int people = Convert.ToInt32(Console.ReadLine()); 

 for (int counter = 1; counter <= people; counter++) { /* loop statement. (num counter starts at, num counter stops at, counter goes up by one) */
 Console.WriteLine("What is the height of person #" + counter + "?");
 double height = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("What is the weight of person #" + counter + "?");
 double weight = Convert.ToDouble(Console.ReadLine());
 double bmi = calculatebmi(weight, height); //must put defintion of function in other class! this is how you recieve that bmi value
 MainClass.bmiresults(bmi); //this is how you let the other function with NO RETURN VALUE write to console!!!!
 }
  }

 public static double calculatebmi(double weight, double height) { /*creating function. calculatebmi is the function name. weight and height are the variables to be used in this function */
 double bmi = ((weight * 703)/(height * height));
 return bmi; } // Must return the value unless the MainClass type is void (no calculation)

 public static void bmiresults(double bmi) { //bmi is the input value that the function bmiresults is based off of
  if ( bmi < 18.5) {
   Console.WriteLine ("underweight"); }
 else if (bmi <= 24.9 && bmi >= 18.5 ) {
   Console.WriteLine ("normal weight"); } /*These are the statements that respond to our main console string to define what the bmi results mean */
 else if (bmi <= 29.9 && bmi >= 25) {
   Console.WriteLine ("overweight"); }
 else if (bmi >= 30) {
   Console.WriteLine ("obese"); }
 }

}
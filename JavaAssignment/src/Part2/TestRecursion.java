/*****************************************************************************************************
* Project: < COMP2080_ASSIGN1_Garasymovych_Roman >
* Assignment: < assignment 1 >
* Author(s): < Roman Garasymovych >
* Student Number: < 100940045 >
* Date: February 16, 2015
* Description: < Driver class for testing methods and algorithms declared in StringRecursion.java >
****************************************************************************************************/

package Part2;

public class TestRecursion {

	public static void main(String[] args) throws COMP2080AssignmentInputException {

		System.out.println("String with spaces between characters:");
		StringRecursion.printWithSpaces("spaces");
		
		System.out.println("\nWeave:");
		System.out.println(StringRecursion.weave("wwww", "eeeeeeeeeeee"));
		
		System.out.println("Last Index:");
		System.out.print(StringRecursion.lastIndexOf('r', "recursion"));
	}
}
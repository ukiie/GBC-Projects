/*****************************************************************************************************
* Project: < COMP2080_ASSIGN1_Garasymovych_Roman >
* Assignment: < assignment 1 >
* Author(s): < Roman Garasymovych >
* Student Number: < 100940045 >
* Date: February 16, 2015
* Description: < Part 2 implementation of recursive methods >
****************************************************************************************************/
package Part2;

public class StringRecursion {
	
	public static void printWithSpaces(String str) {
		
		String step = "";
		int index = 0;
		if(index < str.length()){
			if(str.charAt(index) != ' ' ){
				index++;
				step = str.substring(0, index) + " ";
				System.out.print(step);
			}
			printWithSpaces(str.substring(index));
		}
	}
	
	public static String weave(String str1, String str2) throws COMP2080AssignmentInputException {
		
		String result;	
		//Handling Exceptions
		if(str1 == null || str2 == null){
			throw new COMP2080AssignmentInputException("Invalid input");
		}
		if(str1.isEmpty() || str2.isEmpty()){
			return str1 + str2;
		}
		//Recursive step
		result = str1.substring(0,1) + str2.substring(0,1);
		return result + weave(str1.substring(1), str2.substring(1));
		
	}
	
	public static int lastIndexOf(char ch, String str)
	{
		//return final result
		if(str.charAt(str.length() - 1) == ch){ 
			return str.length() - 1; 
		}
		//check for empty string
	    if (str.length() <= 1){
	    	return -1;
	    }
	    //recursive step
	    return lastIndexOf(ch, str.substring(0, str.length() - 1));
	    
	}


}
//Custom Exception class
@SuppressWarnings("serial")
class COMP2080AssignmentInputException extends Exception
{
	public COMP2080AssignmentInputException() {}
	
	public COMP2080AssignmentInputException(String message){
		super(message);
	}
}
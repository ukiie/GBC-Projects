/*****************************************************************************************************
* Project: < COMP2080_ASSIGN1_Garasymovych_Roman >
* Assignment: < assignment 1 >
* Author(s): < Roman Garasymovych >
* Student Number: < 100940045 >
* Date: February 16, 2015
* Description: < Driver class for testing methods and algorithms declared in Timing.java >
****************************************************************************************************/

package Part1;

import java.math.BigInteger;

public class TestTiming 
{

	public static void main(String[] args) {
		
		System.out.println("Daffy");
		testDaffy(30, 44);
		System.out.println("-----------------------------------------------");
		
		System.out.println("Donald");
		testDonald(30, 44);
		System.out.println("-----------------------------------------------");
		
		System.out.println("Mickey");
		testMickey(1000, 8192000);
		System.out.println("-----------------------------------------------");
		
		System.out.println("Minnie");
		testMinnie(1000, 256000);
		System.out.println("-----------------------------------------------");
		
		System.out.println("Goofy");
		testGoofy(1000, 256000);
		System.out.println("-----------------------------------------------");
		
		System.out.println("Pluto");
		testPluto(1000, 256000);
		System.out.println("-----------------------------------------------");
		
		System.out.println("Gyro");
		testGyro(1000, 256000);
		System.out.println("-----------------------------------------------");
		
		System.out.println("Fact");
		testFact();
		System.out.println("-----------------------------------------------");
	}
	// A
	public static void testDaffy(int start, int end)
	{
		
		Stopwatch timer = new Stopwatch();
		for( int n = start; n <= end; n++){
			timer.start();
			Timing.daffy(n);
			timer.stop();
			
			System.out.println("n value: " + n);
			System.out.println(timer);
		}
	}
	// B
	public static void testDonald(int start, int end)
	{
		
		Stopwatch timer = new Stopwatch();
		for( int n = start; n <= end; n++){
			timer.start();
			Timing.donald(n);
			timer.stop();
			
			System.out.println("n value: " + n);
			System.out.println(timer);
		}
	}
	// C
	public static void testMickey(int n, int end)
	{
		Stopwatch timer = new Stopwatch();
		int[] array = Timing.randomarr(n);
		 while(n < end){
			 timer.start();
			 Timing.mickey(array);
			 timer.stop();
			 n += n;
		 
			 System.out.println("n value: " + n);
			 System.out.println(timer);
		 }
	}
	
	// D
	public static void testMinnie(int n, int end){
		Stopwatch timer = new Stopwatch();
		int[] array = Timing.randomarr(n);
		 while(n < end){
			 timer.start();
			 Timing.minnie(array);
			 timer.stop();
			 n += n;
		 
			 System.out.println("n value: " + n);
			 System.out.println(timer);
		 }
	}
	
	// E
	public static void testGoofy(int n, int end){
		Stopwatch timer = new Stopwatch();
		int[] array = Timing.randomarr(n);
		 while(n < end){
			 timer.start();
			 Timing.goofy(array);
			 timer.stop();
			 n += n;
		 
			 System.out.println("n value: " + n);
			 System.out.println(timer);
		 }
	}
	public static void testPluto(int n, int end){
		Stopwatch timer = new Stopwatch();
		int[] array = Timing.randomarr(n);
		 while(n < end){
			 timer.start();
			 Timing.pluto(array);
			 timer.stop();
			 n += n;
		 
			 System.out.println("n value: " + n);
			 System.out.println(timer);
		 }
	}
	public static void testGyro(int n, int end){
		Stopwatch timer = new Stopwatch();
		int[] array = Timing.randomarr(n);
		 while(n < end){
			 Timing.pluto(array);
			 timer.start();
			 Timing.gyro(array);
			 timer.stop();
			 n += n;
		 
			 System.out.println("n value: " + n);
			 System.out.println(timer);
		}
	}
	public static void testFact()
	{
		Stopwatch timer = new Stopwatch();		
		for (int n = 1000; n <=64000; n+=n)
		{
			BigInteger bign = BigInteger.valueOf((long) n);
			timer.start();
			Timing.fact(bign);
			timer.stop();
			System.out.println("n value: " + n);
			System.out.println(timer);
		}
	}
}

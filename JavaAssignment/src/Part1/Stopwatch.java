/*****************************************************************************************************
* Project: < COMP2080_ASSIGN1_Garasymovych_Roman >
* Assignment: < assignment 1 >
* Author(s): < Roman Garasymovych >
* Student Number: < 100940045 >
* Date: February 16, 2015
* Description: <describe the java file and its purpose briefly only – 1 or 2 lines>
****************************************************************************************************/

package Part1;
public class Stopwatch
{
    private long startTime;
    private long stopTime;

    public static final double NANOS_PER_SEC = 1000000000.0;

	/**
	 start the stop watch.
	*/
	public void start()
	{	System.gc();
		startTime = System.nanoTime();
	}

	/**
	 stop the stop watch.
	*/
	public void stop()
	{	stopTime = System.nanoTime();	}

	/**
	elapsed time in secods.
	@return the time recorded on the stopwatch in seconds
	*/
	public double time()
	{	return (stopTime - startTime) / NANOS_PER_SEC;	}

	public String toString()
	{   return "elapsed time: " + time() + " seconds.";
	}

	/**
	elapsed time in nanoseconds.
	@return the time recorded on the stopwatch in nanoseconds
	*/
	public long timeInNanoseconds()
	{	return (stopTime - startTime);	}
}


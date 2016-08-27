package Part3;


class LinkedList<T> {
	private T value;
	private LinkedList<T> next;
	private int listcount;
	public LinkedList(){
		listcount = 0;
	}
	public T setValue(T v) {
		value = v;  return v; }

	public LinkedList<T> setNext(LinkedList<T> n) {
		next = n;  return next; }

	public T getValue() {
		return value; }

	public LinkedList<T> getNext() {
		return next; }

	public int size(){
		return listcount;
	}
	public void addAfter(LinkedList<T> a, T x) { 
		LinkedList<T> n = new LinkedList<T>();
	    n.value = x;
	    n.next = a.next;
	    a.next = n;
	    listcount++;
	}
	public LinkedList<T> last() {  
		LinkedList<T> n = this;
		while (n.next != null) n = n.next;
	    return n;
	}
	public T lastValue() {
		LinkedList<T> n = next;
		T v = null;
		while (n.next != null){
			n = n.next;
		}
		v = n.value;
		return v;
	}
	   
	public void addLast(T x) {    
		addAfter(last(),x); 
	    listcount++;
	}
	   
	public String toString() {
		LinkedList<T> a = next;
	    String s = "[";
	    
	    while (a != null) {
	    	s = s + a.value.toString() + " ";
	        a = a.next;
	    }
	    return s+ "]";
     }
	    
	           
}

package net.spe;
import org.apache.commons.math3.primes.Primes;

/**
 * Hello world!
 *
 */
public class App {
    public static int nextPrime(int n){
        return Primes.nextPrime(n);
    }
    public static void main( String[] args )
    {
        System.out.println( "Hello World!" );
    }
}

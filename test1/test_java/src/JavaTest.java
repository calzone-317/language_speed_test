public class JavaTest {
    public static void main(String[] args) {
        long start = System.nanoTime();
        long total = 0;
        for (int i = 1; i <= 100_000_000; i++) {
            total += i;
        }
        long end = System.nanoTime();
        System.out.printf("Java: %.5f sec\n", (end - start) / 1e9);
    }
}

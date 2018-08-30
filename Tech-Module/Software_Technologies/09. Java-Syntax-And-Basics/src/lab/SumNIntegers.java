package exercises;

import java.util.Scanner;

public class SumNIntegers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        int sum = 0;

        for (int i = 1; i <= n ; i++) {
            int currentNumber = Integer.parseInt(scanner.nextLine());
            sum += currentNumber;
        }

        System.out.println(sum);
    }
}

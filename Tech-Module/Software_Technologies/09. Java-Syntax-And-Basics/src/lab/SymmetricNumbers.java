package exercises;

import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i <= n; i++) {

            if (i == reverse(i)) {
                System.out.printf(i + " ");
            }
        }
    }

    public static int reverse(int n) {
        String number = Integer.toString(n);
        String output = "";

        for (int i = number.length() - 1; i >= 0; i--) {
            output += number.charAt(i);
        }

        return Integer.parseInt(output);
    }
}

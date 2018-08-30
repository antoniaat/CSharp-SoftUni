package exercises;

import java.util.Scanner;

public class ReverseString {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        char[] charArr = input.toCharArray();

        for (int i = charArr.length - 1; i >= 0; i--) {
            System.out.print(charArr[i]);
        }
    }
}

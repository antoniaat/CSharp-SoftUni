package exercises;

import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        char[] charArr = input.toCharArray();

        if (charArr.length >= 20) {
            for (int i = 0; i < 20; i++) {
                System.out.print(charArr[i]);
            }
        } else {
            int diff = 20 - charArr.length;
            for (int i = 0; i < charArr.length; i++) {
                System.out.print(charArr[i]);
            }
            for (int i = 0; i < diff; i++) {
                System.out.print('*');
            }
        }
    }
}

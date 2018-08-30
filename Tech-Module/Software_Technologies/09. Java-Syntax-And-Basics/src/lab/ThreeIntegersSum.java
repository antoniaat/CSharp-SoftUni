package exercises;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Integer> list = new ArrayList<Integer>();

        for (int i = 0; i < 3; i++) {
            list.add(scanner.nextInt());
        }

        int num1 = list.get(0);
        int num2 = list.get(1);
        int num3 = list.get(2);

        if (num1 + num2 == num3) {
            if (num1 < num2) {
                System.out.printf("%d + %d = %d", num1, num2, num3);
            } else {
                System.out.printf("%d + %d = %d", num2, num1, num3);
            }
        } else if (num1 + num3 == num2) {
            if (num1 < num3) {
                System.out.printf("%d + %d = %d", num1, num3, num2);
            } else {
                System.out.printf("%d + %d = %d", num3, num1, num2);
            }
        } else if (num2 + num3 == num1) {
            if (num2 < num3) {
                System.out.printf("%d + %d = %d", num2, num3, num1);
            } else {
                System.out.printf("%d + %d = %d", num3, num2, num1);
            }
        } else {
            System.out.println("No");
        }
    }
}

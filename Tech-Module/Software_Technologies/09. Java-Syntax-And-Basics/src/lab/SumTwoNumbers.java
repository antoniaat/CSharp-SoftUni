package exercises;

import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        float num1 = Float.parseFloat(console.nextLine());
        float num2 = Float.parseFloat(console.nextLine());
        float sum = num1 + num2;

        System.out.println(sum);
    }
}

package exercises;

import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        int leftSum = 0;
        int rightSum = 0;
        int count = 0;

        for (int i = 0; i < numbers.length; i++) {
            int currentNum = numbers[i];

            for (int j = 0; j < i; j++) {
                leftSum += numbers[j];
            }
            for (int j = i + 1; j < numbers.length; j++) {
                rightSum += numbers[j];
            }

            if (leftSum == rightSum) {
                System.out.println(i);
                count++;
                break;
            } else {
                leftSum = 0;
                rightSum = 0;
            }
        }
        if (count == 0) {
            System.out.println("no");
        }
    }
}

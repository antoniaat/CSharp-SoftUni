package exercises;

import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] numbers = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();

        int len = 1;
        int bestSeq = 0;
        int bestNumber = 0;

        for (int i = 1; i <= numbers.length-1; i++) {

            if(numbers[i] == numbers[i-1]) {
                len++;
            }

            else {
                len = 1;
            }

            if(len > bestSeq) {
                bestSeq = len;
                bestNumber = numbers[i];
            }
        }

        for (int i = 0; i < bestSeq; i++) {
            System.out.print(bestNumber + " ");
        }
    }
}

package exercises;

import java.util.*;

public class Largest3Numbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();

        Arrays.sort(numbers);

        Collections.reverse(Arrays.asList(numbers));

        if(numbers.length >= 3) {
            for (int i = numbers.length - 1; i > numbers.length - 4; i--) {
                System.out.println(numbers[i]);
            }
        }

        else {
            for (int i = numbers.length - 1; i >= 0; i--) {
                System.out.println(numbers[i]);
            }
        }
    }
}



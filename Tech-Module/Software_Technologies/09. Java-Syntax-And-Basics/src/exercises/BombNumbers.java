package exercises;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.LinkedHashMap;
import java.util.Scanner;
import java.lang.Object;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();

        ArrayList<Integer> arraylist = new ArrayList<>();

        for (int i = 0; i < numbers.length; i++) {
            arraylist.add(numbers[i]);
        }

        int[] bombNumbers = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        int bombNum = bombNumbers[0];
        int bombPower = bombNumbers[1];

        for (int i = 0; i < arraylist.size(); i++) {
            if (arraylist.get(i) == bombNum) {
                for (int j = arraylist.get(i - 1); j >= bombPower - j; j--) {
                    arraylist.remove(j);
                }
                break;
            }
        }

        int count = 0;

        for (int k = 0; k < arraylist.size(); k++) {
            if (arraylist.get(k) == bombNum) {
                for (int j = arraylist.get(k + 1); j <= bombPower + j; j++) {
                    arraylist.remove(j);
                    j--;
                    count++;

                    if (count == bombPower) {
                        break;
                    }
                }

                for (int i = 0; i < arraylist.size(); i++) {
                    if (arraylist.get(k) == bombNum) {
                        arraylist.remove(k);
                    }
                    break;
                }
                break;
            }
        }

        int sum = 0;

        for (int i = 0; i < arraylist.size(); i++) {
            sum += arraylist.get(i);
        }

        System.out.print(sum);
    }
}

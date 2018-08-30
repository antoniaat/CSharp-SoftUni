package exercises;

import java.util.*;

public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] numbers = Arrays.stream(scanner.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();

        LinkedHashMap <Integer, Integer> map = new LinkedHashMap <>();

        for (int i = 0; i < numbers.length; i++) {
            map.putIfAbsent(numbers[i], 0);
            map.put(numbers[i], map.get(numbers[i]) + 1);
        }

        int bestCountOfValue = 0;
        int bestNumber = 0;
        int currentCountOfValue = 0;

        for (Integer key : map.keySet()) {
            currentCountOfValue = map.get(key);

            if(currentCountOfValue > bestCountOfValue) {
                bestCountOfValue = currentCountOfValue;
                bestNumber = key;
            }
        }

        System.out.println(bestNumber);
    }
}

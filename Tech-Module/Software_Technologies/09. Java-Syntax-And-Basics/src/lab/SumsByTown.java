package exercises;

import java.util.*;

public class SumsByTown {
    public static void main(String[] args) {
            Scanner scanner = new Scanner(System.in);
            int n = Integer.parseInt(scanner.nextLine());

            TreeMap<String, Double> sumsByTown = new TreeMap<>();

            for (int i = 1; i <= n; i++) {
                String[] tokens = scanner.nextLine().split("\\|");

                String town = tokens[0].trim();
                double income = Double.parseDouble(tokens[1].trim());

                sumsByTown.putIfAbsent(town, 0.0);
                sumsByTown.put(town, sumsByTown.get(town) + income);
            }

            for (String key : sumsByTown.keySet()) {
                System.out.println(key + " -> " + sumsByTown.get(key));
        }
    }
}

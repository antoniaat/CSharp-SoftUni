package exercises;

import java.util.Scanner;

public class VariableinHexFormat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        Integer output = Integer.parseInt(input, 16);

        System.out.println(output);
    }
}

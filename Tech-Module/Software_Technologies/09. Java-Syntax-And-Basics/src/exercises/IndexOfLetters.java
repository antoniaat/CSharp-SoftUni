package exercises;

import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++) {
            alphabet[i] = ((char) ('a' + i));
        }

        for (int i = 0; i < input.length(); i++) {

            char currentLetter = input.charAt(i);

            for (int j = 0; j < alphabet.length; j++) {

                if (alphabet[j] == currentLetter)
                {
                    System.out.println(currentLetter + " -> " + j);
                }
            }
        }
    }
}

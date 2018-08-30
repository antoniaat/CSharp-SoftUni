package exercises;

import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char input = scanner.next().charAt(0);

        if(Character.isLetter(input)) {
            input = Character.toLowerCase(input);

            if(input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u') {
                System.out.println("vowel");
            }
            else {
                System.out.println("other");
            }
        }

        else if(Character.isDigit(input)) {
            System.out.println("digit");
        }

        else {
            System.out.println("other");
        }
    }
}

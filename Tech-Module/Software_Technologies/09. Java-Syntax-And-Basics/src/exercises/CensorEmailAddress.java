package exercises;

import java.util.Scanner;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] emailAdress = scanner.nextLine().split("@");
        String[] input = scanner.nextLine().split(" ");

        String username = emailAdress[0];
        String domain = emailAdress[1];

        String replacement = "";

        for (int i = 0; i < username.length(); i++) {
            replacement += "*";
        }

        String[] finalInput = new String[input.length];

        String email = username + "@" + domain;

        for (int i = 0; i < input.length; i++) {
            if (input[i].contains(email)) {
                String[] userName = input[i].split("@");
                String newUsername = replacement + "@" + userName[1];
                finalInput[i] = newUsername;
            } else {
                finalInput[i] = input[i];
            }
        }

        for (int i = 0; i < finalInput.length; i++) {
            System.out.print(finalInput[i] + " ");
        }
    }
}

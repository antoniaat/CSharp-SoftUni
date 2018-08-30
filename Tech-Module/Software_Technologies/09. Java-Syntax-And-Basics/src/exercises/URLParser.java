package exercises;

import java.util.ArrayList;
import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split("://");

        ArrayList<String> inputList = new ArrayList<>();

        for (int i = 0; i < input.length; i++) {
            inputList.add(input[i]);
        }

        String protocol = input[0];
        inputList.remove(0);

        String[] leftPart = input[1].split("/", 2);
        String server = leftPart[0];
        String resource = leftPart[1];

        System.out.printf("[protocol] = \"%s\"\n", protocol);
        System.out.printf("[server] = \"%s\"\n", server);
        System.out.printf("[resource] = \"%s\"\n", resource);
    }
}

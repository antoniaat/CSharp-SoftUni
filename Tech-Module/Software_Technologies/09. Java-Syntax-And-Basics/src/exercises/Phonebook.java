package exercises;

import java.util.*;

public class Phonebook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split(" ");
        Map<String, String> phonebook = new HashMap<>();

        while (!(input[0].equals("END"))) {
            if(input[0].equals("A")) {
                String name = input[1];
                String phone = input[2];

                phonebook.putIfAbsent(name, "");
                phonebook.put(name, phone);
            }

            if (input[0].equals("S")) {
                String name = input[1];

                int count = 0;

                for (String key : phonebook.keySet()) {
                    if(key.equals(name)) {
                        System.out.println(key + " -> " + phonebook.get(key));
                        count++;
                    }
                }

                if(count == 0) {
                    System.out.printf("Contact %s does not exist.\n", name);
                }
            }

            input = scanner.nextLine().split(" ");
        }
    }
}

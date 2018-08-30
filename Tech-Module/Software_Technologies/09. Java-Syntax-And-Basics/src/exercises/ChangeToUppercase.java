package exercises;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        Pattern p = Pattern.compile("(<upcase>.*?<\\/upcase>)");
        Matcher m = p.matcher(input);
        while (m.find()) {
            m.group(1); //is your string. do what you want

            String uppercase = m.group(1).substring(m.group(1).indexOf("<upcase>") + 8, m.group(1).indexOf("</upcase>"));
            uppercase = uppercase.toUpperCase();

            input = input.replace(m.group(1), uppercase);
        }

        System.out.println(input);
    }
}

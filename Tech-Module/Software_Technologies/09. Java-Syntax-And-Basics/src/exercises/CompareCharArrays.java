package exercises;

import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] firstArr = scanner.nextLine().split("\\s");
        String[] secondArr = scanner.nextLine().split("\\s");

        String s = "";
        String m = "";

        for (String n : firstArr)
            s += n;
        char[] firstCharArr = s.toCharArray();

        for (String n : secondArr)
            m += n;
        char[] secondCharArr = m.toCharArray();

        if (firstCharArr.length == secondCharArr.length) {
            for (int i = 0; i < secondCharArr.length; i++) {
                PrintArrays(firstCharArr, secondCharArr, i, firstArr, secondArr);
                return;
            }
        }
        else if (firstCharArr.length < secondCharArr.length) {
            for (int i = 0; i < firstCharArr.length; i++) {
                PrintArrays(firstCharArr, secondCharArr, i, firstArr, secondArr);
                return;
            }
        }
        else {
            for (int i = 0; i < secondCharArr.length; i++) {
                PrintArrays(firstCharArr, secondCharArr, i, firstArr, secondArr);
                return;
            }
        }
    }

    public static void PrintArrays(char[] firstCharArr, char[] secondCharArr, int i, String[] firstArr, String[] secondArr) {
        if (firstCharArr[i] >= secondCharArr[i]) {
            String joined = String.join("", secondArr);
            System.out.println(joined);
            joined = String.join("", firstArr);
            System.out.println(joined);
        } else {
            String joined = String.join("", firstArr);
            System.out.println(joined);
            joined = String.join("", secondArr);
            System.out.println(joined);
        }
    }
}

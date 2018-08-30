package exercises;

public class Expression {
    public static void main(String[] args) {
        double val = (((30D + 21D) * 1D/2D) * (35D - 12D - 1D/2D));
        double sqrVal = Math.pow(val, 2);
        System.out.println(sqrVal);
    }
}

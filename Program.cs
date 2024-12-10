// تعريف الكلاس SavingsAccount
class SavingsAccount
{

    private double balance;

    private int years;

    public SavingsAccount(double balance, int years)
    {

        this.balance = balance;

        this.years = years;

    }

    public double calculateInterest()
    {

        if (years < 3)
        {

            return balance * 0.03 * years;

        }
        else
        {

            return balance * 0.04 * years;

        }

    }
}

// تعريف الكلاس FixedDepositAccount
class FixedDepositAccount
{

    private double balance;

    private int years;

    public FixedDepositAccount(double balance, int years)
    {

        this.balance = balance;

        this.years = years;

    }

    public double calculateInterest()
    {

        if (years < 2)
        {

            return balance * 0.06 * years;

        }
        else
        {

            return balance * 0.08 * years + (500 + years);

        }

    }
}

// الكلاس الرئيسي
public class main
{

    public static void Main(String[] args)
    {

        // إنشاء مصفوفة من الحسابات

        Object[] accounts = new Object[2];

        // إنشاء حساب التوفير وإدخال البيانات

        SavingsAccount savingsAccount = new SavingsAccount(1000, 4);

        accounts[0] = savingsAccount;

        // حساب الفائدة لحساب التوفير

        double savingsInterest = savingsAccount.calculateInterest();

        Console.WriteLine("Savings Account Interest: " + savingsInterest);

        // إنشاء حساب الوديعة الثابتة وإدخال البيانات

        FixedDepositAccount fixedDepositAccount = new FixedDepositAccount(2000, 3);

        accounts[1] = fixedDepositAccount;

        // حساب الفائدة لحساب الوديعة الثابتة

        double fixedDepositInterest = fixedDepositAccount.calculateInterest();

        Console.WriteLine("Fixed Deposit Account Interest: " +  fixedDepositInterest);

    }

}
using System.ComponentModel;

public class sorting
{
    public static int[] GandalfBubblesort(int[] MOO )
    {

        int temp = 0;

        for (int write = 0; write < MOO.Length; write++)
        {

            for (int sort = 0; sort < MOO.Length - 1; sort++)
            {

                if (MOO[sort] > MOO[sort + 1])
                {

                    temp = MOO[sort + 1];
                    MOO[sort + 1] = MOO[sort];
                    MOO[sort] = temp;

                }

            }
            Console.Write("{0}", MOO[write]);

        }
        return MOO;

    }
}

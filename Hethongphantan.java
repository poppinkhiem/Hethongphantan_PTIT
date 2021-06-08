/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package htpt1;

import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 *  YOUTUBE.COM/POPPINKHIEM
 */
public class HTPT {
    public static void main(String[] args) {
        long sss = 60*60*24*25567L;
        // 00 01 02 03 04  05 06 07 08  09 10 11 12  13 14 15  16 17  18 19 20  21  22  23 24  25 26 27 28 29 30 31 32 33  34 35 36  37 38  39 40  41  42 43 44  45 46  47 
        //{28,03,00,223,00,00,00,114,00,00,12,160,25,66,230,04,225,72,40,195,105,242,38,249,00,00,00,00,00,00,00,00,225,72,40,208,41,242,12,33,225,72,40,208,41,242,52,101}
        short[] arr = {225,72,40,195,105,242,38,249,225,72,40,208,41,242,12,33,225,72,40,208,41,242,52,101};
        for(int pos = 0; pos < 3; pos++){
            double time = 0.0;
            int ind = pos * 8;
            for(int i = ind; i < ind + 8; i++) {
                time = time + arr[i]*Math.pow(2, (ind + 3 - i) * 8);
            }
            String result = new SimpleDateFormat("YYYY-MM-dd HH:mm:ss.SSS").format(new Date((long)(1000*(time - sss))));
            System.out.println(result);
        }
    }
}

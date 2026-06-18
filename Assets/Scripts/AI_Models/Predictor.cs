using static System.Math;
namespace ML {
    public static class Model {
        public static double[] Score(double[] input) {
            double var0;
            if (input[4] < 5.0) {
                var0 = -0.05649161;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 15.0) {
                        var0 = 0.069306776;
                    } else {
                        var0 = 0.26771593;
                    }
                } else {
                    var0 = -0.03296708;
                }
            }
            double var1;
            if (input[5] < 1.0) {
                var1 = -0.07284342;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 16.0) {
                        var1 = 0.13602498;
                    } else {
                        var1 = 0.042857196;
                    }
                } else {
                    var1 = 0.000000040871768;
                }
            }
            double var2;
            if (input[3] < 10.0) {
                if (input[2] < 8.0) {
                    var2 = -0.052659072;
                } else {
                    var2 = 0.057521768;
                }
            } else {
                var2 = 0.27847978;
            }
            double var3;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var3 = 0.115165256;
                    } else {
                        var3 = -0.06072867;
                    }
                } else {
                    var3 = -0.07838471;
                }
            } else {
                if (input[0] < 19.0) {
                    var3 = -0.08161902;
                } else {
                    var3 = -0.010169415;
                }
            }
            double var4;
            if (input[4] < 5.0) {
                var4 = -0.05576567;
            } else {
                if (input[2] < 7.0) {
                    var4 = 0.1976328;
                } else {
                    var4 = -0.032976788;
                }
            }
            double var5;
            if (input[5] < 1.0) {
                var5 = -0.070219405;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 5.0) {
                        var5 = 0.11987003;
                    } else {
                        var5 = 0.03653371;
                    }
                } else {
                    var5 = -0.00076706155;
                }
            }
            double var6;
            if (input[3] < 12.0) {
                if (input[2] < 10.0) {
                    var6 = -0.052355316;
                } else {
                    var6 = 0.10350976;
                }
            } else {
                var6 = 0.25017473;
            }
            double var7;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var7 = 0.104365446;
                    } else {
                        var7 = -0.05902594;
                    }
                } else {
                    var7 = -0.07522566;
                }
            } else {
                if (input[0] < 19.0) {
                    var7 = -0.07707514;
                } else {
                    var7 = -0.009817911;
                }
            }
            double var8;
            if (input[4] < 5.0) {
                var8 = -0.055048447;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 15.0) {
                        var8 = 0.054353096;
                    } else {
                        var8 = 0.17460404;
                    }
                } else {
                    var8 = -0.032794964;
                }
            }
            double var9;
            if (input[5] < 1.0) {
                var9 = -0.06791284;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 16.0) {
                        var9 = 0.107179634;
                    } else {
                        var9 = 0.035231035;
                    }
                } else {
                    var9 = -0.0017633698;
                }
            }
            double var10;
            if (input[3] < 10.0) {
                if (input[2] < 8.0) {
                    var10 = -0.051711112;
                } else {
                    var10 = 0.052249003;
                }
            } else {
                var10 = 0.18405877;
            }
            double var11;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var11 = 0.09575718;
                    } else {
                        var11 = -0.05706473;
                    }
                } else {
                    var11 = -0.07230723;
                }
            } else {
                if (input[0] < 19.0) {
                    var11 = -0.073329054;
                } else {
                    var11 = -0.00802436;
                }
            }
            double var12;
            if (input[4] < 5.0) {
                var12 = -0.05435282;
            } else {
                if (input[2] < 7.0) {
                    var12 = 0.14020857;
                } else {
                    var12 = -0.032604422;
                }
            }
            double var13;
            if (input[5] < 1.0) {
                var13 = -0.06585882;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var13 = 0.101564504;
                    } else {
                        var13 = 0.050411053;
                    }
                } else {
                    var13 = -0.002215468;
                }
            }
            double var14;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var14 = -0.051065158;
                } else {
                    var14 = 0.010101076;
                }
            } else {
                if (input[3] < 12.0) {
                    var14 = 0.06087443;
                } else {
                    var14 = 0.16934037;
                }
            }
            double var15;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var15 = 0.08893689;
                    } else {
                        var15 = -0.055277485;
                    }
                } else {
                    var15 = -0.06964686;
                }
            } else {
                if (input[0] < 19.0) {
                    var15 = -0.07010415;
                } else {
                    var15 = -0.0076870406;
                }
            }
            double var16;
            if (input[4] < 5.0) {
                var16 = -0.05368042;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 14.0) {
                        var16 = 0.017081557;
                    } else {
                        var16 = 0.13276249;
                    }
                } else {
                    var16 = -0.032292377;
                }
            }
            double var17;
            if (input[5] < 1.0) {
                var17 = -0.064032815;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var17 = 0.09348895;
                    } else {
                        var17 = 0.04687181;
                    }
                } else {
                    var17 = -0.003056674;
                }
            }
            double var18;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var18 = -0.050567545;
                } else {
                    var18 = 0.009889717;
                }
            } else {
                if (input[3] < 5.0) {
                    var18 = 0.020537099;
                } else {
                    var18 = 0.14183451;
                }
            }
            double var19;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var19 = 0.08335749;
                    } else {
                        var19 = -0.053687073;
                    }
                } else {
                    var19 = -0.06720921;
                }
            } else {
                if (input[0] < 19.0) {
                    var19 = -0.0673901;
                } else {
                    var19 = -0.0063445936;
                }
            }
            double var20;
            if (input[4] < 5.0) {
                var20 = -0.05302718;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 14.0) {
                        var20 = 0.016502356;
                    } else {
                        var20 = 0.11777792;
                    }
                } else {
                    var20 = -0.03187488;
                }
            }
            double var21;
            if (input[5] < 1.0) {
                var21 = -0.062372684;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var21 = 0.08696413;
                    } else {
                        var21 = 0.043033034;
                    }
                } else {
                    var21 = -0.0033226572;
                }
            }
            double var22;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var22 = -0.05006532;
                } else {
                    var22 = 0.009753574;
                }
            } else {
                if (input[3] < 5.0) {
                    var22 = 0.020357408;
                } else {
                    var22 = 0.123833;
                }
            }
            double var23;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var23 = 0.07871281;
                    } else {
                        var23 = -0.052174658;
                    }
                } else {
                    var23 = -0.064866684;
                }
            } else {
                if (input[0] < 19.0) {
                    var23 = -0.06504751;
                } else {
                    var23 = -0.0050543547;
                }
            }
            double var24;
            if (input[4] < 5.0) {
                var24 = -0.052395232;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 14.0) {
                        var24 = 0.015987199;
                    } else {
                        var24 = 0.10619234;
                    }
                } else {
                    var24 = -0.031408235;
                }
            }
            double var25;
            if (input[5] < 1.0) {
                var25 = -0.06087757;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var25 = 0.08159938;
                    } else {
                        var25 = 0.039582804;
                    }
                } else {
                    var25 = -0.0034914692;
                }
            }
            double var26;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var26 = -0.049559206;
                } else {
                    var26 = 0.009663985;
                }
            } else {
                if (input[2] < 10.0) {
                    var26 = 0.017182207;
                } else {
                    if (input[4] < 1.0) {
                        var26 = 0.011944366;
                    } else {
                        var26 = 0.13230847;
                    }
                }
            }
            double var27;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var27 = 0.074807785;
                    } else {
                        var27 = -0.050722163;
                    }
                } else {
                    var27 = -0.06273311;
                }
            } else {
                if (input[0] < 19.0) {
                    var27 = -0.062989146;
                } else {
                    var27 = -0.0038173292;
                }
            }
            double var28;
            if (input[4] < 5.0) {
                var28 = -0.051788446;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 14.0) {
                        var28 = 0.015523598;
                    } else {
                        var28 = 0.09700486;
                    }
                } else {
                    var28 = -0.030770196;
                }
            }
            double var29;
            if (input[5] < 1.0) {
                var29 = -0.059515834;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var29 = 0.07712283;
                    } else {
                        var29 = 0.03645535;
                    }
                } else {
                    var29 = -0.0040214346;
                }
            }
            double var30;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var30 = -0.049049232;
                } else {
                    var30 = 0.009610696;
                }
            } else {
                if (input[2] < 10.0) {
                    var30 = 0.016619103;
                } else {
                    if (input[4] < 1.0) {
                        var30 = 0.01130768;
                    } else {
                        var30 = 0.118758164;
                    }
                }
            }
            double var31;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var31 = 0.07146357;
                    } else {
                        var31 = -0.049387265;
                    }
                } else {
                    var31 = -0.06072844;
                }
            } else {
                if (input[0] < 19.0) {
                    var31 = -0.061184805;
                } else {
                    var31 = -0.0026305437;
                }
            }
            double var32;
            if (input[4] < 5.0) {
                var32 = -0.051199388;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 14.0) {
                        var32 = 0.015101114;
                    } else {
                        var32 = 0.089567184;
                    }
                } else {
                    var32 = -0.030093608;
                }
            }
            double var33;
            if (input[5] < 1.0) {
                var33 = -0.058276225;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var33 = 0.07333895;
                    } else {
                        var33 = 0.033599194;
                    }
                } else {
                    var33 = -0.004463449;
                }
            }
            double var34;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var34 = -0.04853496;
                } else {
                    var34 = 0.009584672;
                }
            } else {
                if (input[2] < 10.0) {
                    var34 = 0.016098436;
                } else {
                    if (input[4] < 1.0) {
                        var34 = 0.010715771;
                    } else {
                        var34 = 0.10795065;
                    }
                }
            }
            double var35;
            if (input[0] < 16.0) {
                if (input[5] < 1.0) {
                    var35 = -0.009671512;
                } else {
                    var35 = -0.059356667;
                }
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var35 = 0.064034134;
                    } else {
                        var35 = -0.03558781;
                    }
                } else {
                    var35 = -0.058133524;
                }
            }
            double var36;
            if (input[4] < 5.0) {
                var36 = -0.050635893;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 14.0) {
                        var36 = 0.014712985;
                    } else {
                        var36 = 0.08357659;
                    }
                } else {
                    var36 = -0.029384086;
                }
            }
            double var37;
            if (input[5] < 1.0) {
                var37 = -0.05716619;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var37 = 0.070238255;
                    } else {
                        var37 = 0.031225601;
                    }
                } else {
                    var37 = -0.004735766;
                }
            }
            double var38;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var38 = -0.04802006;
                } else {
                    var38 = 0.009184341;
                }
            } else {
                if (input[2] < 10.0) {
                    var38 = 0.015631517;
                } else {
                    if (input[4] < 1.0) {
                        var38 = 0.0102130845;
                    } else {
                        var38 = 0.09927447;
                    }
                }
            }
            double var39;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var39 = 0.06628121;
                    } else {
                        var39 = -0.047150742;
                    }
                } else {
                    var39 = -0.057287432;
                }
            } else {
                if (input[1] < 5.0) {
                    var39 = -0.058924563;
                } else {
                    var39 = -0.005301645;
                }
            }
            double var40;
            if (input[4] < 5.0) {
                var40 = -0.050074663;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 14.0) {
                        var40 = 0.014347835;
                    } else {
                        var40 = 0.07843014;
                    }
                } else {
                    var40 = -0.028654987;
                }
            }
            double var41;
            if (input[5] < 1.0) {
                var41 = -0.05612048;
            } else {
                if (input[0] < 16.0) {
                    if (input[4] < 5.0) {
                        var41 = 0.06511613;
                    } else {
                        var41 = 0.017322648;
                    }
                } else {
                    var41 = 0.00008073154;
                }
            }
            double var42;
            if (input[2] < 8.0) {
                if (input[1] < 8.0) {
                    var42 = -0.047620688;
                } else {
                    var42 = 0.008872035;
                }
            } else {
                if (input[2] < 10.0) {
                    var42 = 0.015180443;
                } else {
                    if (input[4] < 1.0) {
                        var42 = 0.00968741;
                    } else {
                        var42 = 0.09198904;
                    }
                }
            }
            double var43;
            if (input[0] < 16.0) {
                if (input[5] < 1.0) {
                    var43 = -0.009169026;
                } else {
                    var43 = -0.056602675;
                }
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var43 = 0.05766485;
                    } else {
                        var43 = -0.045983493;
                    }
                } else {
                    var43 = -0.054847;
                }
            }
            double var44;
            if (input[4] < 5.0) {
                var44 = -0.049525302;
            } else {
                if (input[3] < 5.0) {
                    var44 = 0.07304765;
                } else {
                    if (input[0] < 20.0) {
                        var44 = -0.0038581614;
                    } else {
                        var44 = 0.0048267785;
                    }
                }
            }
            double var45;
            if (input[5] < 1.0) {
                var45 = -0.055181175;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var45 = 0.0652865;
                    } else {
                        var45 = 0.02649474;
                    }
                } else {
                    var45 = -0.0062488746;
                }
            }
            double var46;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var46 = -0.046998996;
                } else {
                    var46 = 0.009995054;
                }
            } else {
                if (input[2] < 10.0) {
                    var46 = 0.01467397;
                } else {
                    if (input[4] < 1.0) {
                        var46 = 0.009967922;
                    } else {
                        var46 = 0.086141475;
                    }
                }
            }
            double var47;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var47 = 0.062270757;
                    } else {
                        var47 = -0.04487313;
                    }
                } else {
                    var47 = -0.0543194;
                }
            } else {
                if (input[1] < 5.0) {
                    var47 = -0.056602027;
                } else {
                    var47 = -0.002301924;
                }
            }
            double var48;
            if (input[4] < 5.0) {
                var48 = -0.048980992;
            } else {
                if (input[3] < 5.0) {
                    var48 = 0.06913122;
                } else {
                    if (input[1] < 2.0) {
                        var48 = -0.0041663437;
                    } else {
                        var48 = 0.0047241556;
                    }
                }
            }
            double var49;
            if (input[5] < 1.0) {
                var49 = -0.054293435;
            } else {
                if (input[0] < 16.0) {
                    if (input[4] < 5.0) {
                        var49 = 0.060335375;
                    } else {
                        var49 = 0.015406019;
                    }
                } else {
                    var49 = -0.0014868971;
                }
            }
            double var50;
            if (input[2] < 8.0) {
                if (input[1] < 8.0) {
                    var50 = -0.046576556;
                } else {
                    var50 = 0.00957772;
                }
            } else {
                if (input[2] < 10.0) {
                    var50 = 0.014279556;
                } else {
                    if (input[4] < 1.0) {
                        var50 = 0.0094693;
                    } else {
                        var50 = 0.081070095;
                    }
                }
            }
            double var51;
            if (input[0] < 16.0) {
                if (input[5] < 1.0) {
                    var51 = -0.008658449;
                } else {
                    var51 = -0.054210585;
                }
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var51 = 0.055868357;
                    } else {
                        var51 = -0.033385478;
                    }
                } else {
                    var51 = -0.05203888;
                }
            }
            double var52;
            if (input[4] < 5.0) {
                var52 = -0.048445143;
            } else {
                if (input[3] < 5.0) {
                    var52 = 0.06575451;
                } else {
                    if (input[0] < 20.0) {
                        var52 = -0.0044463887;
                    } else {
                        var52 = 0.004626161;
                    }
                }
            }
            double var53;
            if (input[5] < 1.0) {
                var53 = -0.053486504;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var53 = 0.0614718;
                    } else {
                        var53 = 0.022962824;
                    }
                } else {
                    var53 = -0.0077611255;
                }
            }
            double var54;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var54 = -0.045950707;
                } else {
                    var54 = 0.010047882;
                }
            } else {
                if (input[3] < 5.0) {
                    var54 = 0.015357618;
                } else {
                    var54 = 0.06639341;
                }
            }
            double var55;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var55 = 0.059113797;
                    } else {
                        var55 = -0.042986795;
                    }
                } else {
                    var55 = -0.05182391;
                }
            } else {
                if (input[1] < 5.0) {
                    var55 = -0.054598924;
                } else {
                    var55 = 0.0003915194;
                }
            }
            double var56;
            if (input[4] < 5.0) {
                var56 = -0.047901798;
            } else {
                if (input[3] < 5.0) {
                    var56 = 0.06269028;
                } else {
                    var56 = -0.00048569829;
                }
            }
            double var57;
            if (input[5] < 1.0) {
                var57 = -0.05270507;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var57 = 0.061039675;
                    } else {
                        var57 = 0.014386708;
                    }
                } else {
                    if (input[2] < 2.0) {
                        var57 = 0.040073127;
                    } else {
                        var57 = -0.012284182;
                    }
                }
            }
            double var58;
            if (input[2] < 8.0) {
                if (input[1] < 8.0) {
                    var58 = -0.045522634;
                } else {
                    var58 = 0.010042534;
                }
            } else {
                if (input[2] < 10.0) {
                    var58 = 0.012578425;
                } else {
                    if (input[4] < 1.0) {
                        var58 = 0.007763958;
                    } else {
                        var58 = 0.07384478;
                    }
                }
            }
            double var59;
            if (input[0] < 16.0) {
                var59 = -0.04918767;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var59 = 0.052763607;
                    } else {
                        var59 = -0.031982843;
                    }
                } else {
                    var59 = -0.049635507;
                }
            }
            double var60;
            if (input[4] < 5.0) {
                var60 = -0.047376376;
            } else {
                if (input[3] < 5.0) {
                    var60 = 0.059925437;
                } else {
                    if (input[0] < 18.0) {
                        var60 = -0.0009058534;
                    } else {
                        var60 = -0.00010448715;
                    }
                }
            }
            double var61;
            if (input[5] < 1.0) {
                var61 = -0.051994663;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var61 = 0.059415188;
                    } else {
                        var61 = 0.014143561;
                    }
                } else {
                    if (input[2] < 2.0) {
                        var61 = 0.039105646;
                    } else {
                        var61 = -0.011865005;
                    }
                }
            }
            double var62;
            if (input[2] < 8.0) {
                if (input[1] < 8.0) {
                    var62 = -0.04498431;
                } else {
                    var62 = 0.009834595;
                }
            } else {
                if (input[2] < 12.0) {
                    if (input[0] < 19.0) {
                        var62 = 0.036617246;
                    } else {
                        var62 = -0.00045851417;
                    }
                } else {
                    var62 = 0.06416477;
                }
            }
            double var63;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var63 = 0.056569006;
                    } else {
                        var63 = -0.041157942;
                    }
                } else {
                    var63 = -0.049555033;
                }
            } else {
                if (input[1] < 5.0) {
                    var63 = -0.052866172;
                } else {
                    var63 = 0.0024230229;
                }
            }
            double var64;
            if (input[4] < 5.0) {
                var64 = -0.046828818;
            } else {
                if (input[3] < 5.0) {
                    var64 = 0.057399835;
                } else {
                    if (input[0] < 18.0) {
                        var64 = -0.0013585221;
                    } else {
                        var64 = -0.0001672764;
                    }
                }
            }
            double var65;
            if (input[5] < 1.0) {
                var65 = -0.05129796;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var65 = 0.058032155;
                    } else {
                        var65 = 0.0139058605;
                    }
                } else {
                    if (input[2] < 2.0) {
                        var65 = 0.037471127;
                    } else {
                        var65 = -0.0120104775;
                    }
                }
            }
            double var66;
            if (input[2] < 8.0) {
                if (input[3] < 8.0) {
                    var66 = -0.04432083;
                } else {
                    var66 = 0.010369319;
                }
            } else {
                if (input[3] < 5.0) {
                    var66 = 0.014303434;
                } else {
                    var66 = 0.05693179;
                }
            }
            double var67;
            if (input[0] < 16.0) {
                var67 = -0.047260415;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var67 = 0.049915325;
                    } else {
                        var67 = -0.030950485;
                    }
                } else {
                    var67 = -0.047478087;
                }
            }
            double var68;
            if (input[4] < 5.0) {
                var68 = -0.046294343;
            } else {
                if (input[3] < 5.0) {
                    var68 = 0.055090632;
                } else {
                    if (input[0] < 18.0) {
                        var68 = -0.0017730959;
                    } else {
                        var68 = -0.00006989311;
                    }
                }
            }
            double var69;
            if (input[5] < 1.0) {
                var69 = -0.0506514;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var69 = 0.05675889;
                    } else {
                        var69 = 0.013749708;
                    }
                } else {
                    if (input[2] < 2.0) {
                        var69 = 0.036695965;
                    } else {
                        var69 = -0.0115823345;
                    }
                }
            }
            double var70;
            if (input[2] < 8.0) {
                if (input[1] < 8.0) {
                    var70 = -0.043884438;
                } else {
                    var70 = 0.010094839;
                }
            } else {
                if (input[2] < 12.0) {
                    if (input[0] < 19.0) {
                        var70 = 0.033239424;
                    } else {
                        var70 = -0.0010151308;
                    }
                } else {
                    var70 = 0.058359127;
                }
            }
            double var71;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var71 = 0.054436862;
                    } else {
                        var71 = -0.03947386;
                    }
                } else {
                    var71 = -0.04753371;
                }
            } else {
                if (input[1] < 5.0) {
                    var71 = -0.05137685;
                } else {
                    var71 = 0.0036207084;
                }
            }
            double var72;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var72 = -0.045736555;
                } else {
                    if (input[0] < 18.0) {
                        var72 = -0.01583857;
                    } else {
                        var72 = 0.020950222;
                    }
                }
            } else {
                var72 = 0.05631861;
            }
            double var73;
            if (input[5] < 1.0) {
                var73 = -0.050004482;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var73 = 0.0556134;
                    } else {
                        var73 = 0.013589354;
                    }
                } else {
                    if (input[2] < 2.0) {
                        var73 = 0.035207372;
                    } else {
                        var73 = -0.011666405;
                    }
                }
            }
            double var74;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var74 = -0.04531107;
                } else {
                    var74 = 0.04517851;
                }
            } else {
                var74 = 0.06375767;
            }
            double var75;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var75 = 0.05340342;
                    } else {
                        var75 = -0.03863811;
                    }
                } else {
                    var75 = -0.046584062;
                }
            } else {
                if (input[1] < 5.0) {
                    var75 = -0.050521344;
                } else {
                    var75 = 0.0039245593;
                }
            }
            double var76;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var76 = -0.045160238;
                } else {
                    if (input[0] < 18.0) {
                        var76 = -0.01581523;
                    } else {
                        var76 = 0.019955264;
                    }
                }
            } else {
                if (input[2] < 4.0) {
                    var76 = 0.0588901;
                } else {
                    var76 = 0.017150607;
                }
            }
            double var77;
            if (input[5] < 1.0) {
                var77 = -0.049342114;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var77 = 0.054534078;
                    } else {
                        var77 = 0.012925747;
                    }
                } else {
                    if (input[2] < 2.0) {
                        var77 = 0.03379604;
                    } else {
                        var77 = -0.011799599;
                    }
                }
            }
            double var78;
            if (input[2] < 8.0) {
                if (input[1] < 8.0) {
                    var78 = -0.04263695;
                } else {
                    var78 = 0.010229143;
                }
            } else {
                if (input[2] < 12.0) {
                    var78 = 0.020224145;
                } else {
                    var78 = 0.053303506;
                }
            }
            double var79;
            if (input[0] < 16.0) {
                var79 = -0.04485665;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var79 = 0.046303984;
                    } else {
                        var79 = -0.029092932;
                    }
                } else {
                    var79 = -0.04450619;
                }
            }
            double var80;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var80 = -0.04460953;
                } else {
                    if (input[0] < 18.0) {
                        var80 = -0.015738782;
                    } else {
                        var80 = 0.018852303;
                    }
                }
            } else {
                if (input[2] < 4.0) {
                    var80 = 0.057333358;
                } else {
                    var80 = 0.016478026;
                }
            }
            double var81;
            if (input[5] < 1.0) {
                var81 = -0.048762765;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var81 = 0.053548682;
                    } else {
                        var81 = 0.012378839;
                    }
                } else {
                    if (input[2] < 2.0) {
                        var81 = 0.033112593;
                    } else {
                        var81 = -0.0111342305;
                    }
                }
            }
            double var82;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var82 = -0.04431245;
                } else {
                    var82 = 0.040674146;
                }
            } else {
                var82 = 0.059879255;
            }
            double var83;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var83 = 0.05160569;
                    } else {
                        var83 = -0.036860045;
                    }
                } else {
                    var83 = -0.044768263;
                }
            } else {
                if (input[1] < 5.0) {
                    var83 = -0.04926495;
                } else {
                    var83 = 0.00485149;
                }
            }
            double var84;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var84 = -0.044012513;
                } else {
                    if (input[0] < 18.0) {
                        var84 = -0.015697299;
                    } else {
                        var84 = 0.017978868;
                    }
                }
            } else {
                if (input[2] < 4.0) {
                    var84 = 0.055874;
                } else {
                    var84 = 0.015759958;
                }
            }
            double var85;
            if (input[5] < 1.0) {
                var85 = -0.048127346;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var85 = 0.052608307;
                    } else {
                        var85 = 0.011834429;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var85 = 0.022632992;
                    } else {
                        var85 = -0.017197873;
                    }
                }
            }
            double var86;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var86 = -0.04370826;
                } else {
                    var86 = 0.038821492;
                }
            } else {
                var86 = 0.057772662;
            }
            double var87;
            if (input[0] < 16.0) {
                var87 = -0.043345995;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var87 = 0.04394226;
                    } else {
                        var87 = -0.027910529;
                    }
                } else {
                    var87 = -0.04263252;
                }
            }
            double var88;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var88 = -0.04342815;
                } else {
                    if (input[0] < 18.0) {
                        var88 = -0.01563364;
                    } else {
                        var88 = 0.01716674;
                    }
                }
            } else {
                if (input[2] < 4.0) {
                    var88 = 0.054528553;
                } else {
                    var88 = 0.015091616;
                }
            }
            double var89;
            if (input[5] < 1.0) {
                var89 = -0.04753692;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var89 = 0.05171166;
                    } else {
                        var89 = 0.011364761;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var89 = 0.022185018;
                    } else {
                        var89 = -0.016841292;
                    }
                }
            }
            double var90;
            if (input[2] < 8.0) {
                if (input[1] < 8.0) {
                    var90 = -0.04076918;
                } else {
                    var90 = 0.010262376;
                }
            } else {
                if (input[4] < 1.0) {
                    var90 = 0.015773514;
                } else {
                    if (input[2] < 12.0) {
                        var90 = 0.013841971;
                    } else {
                        var90 = 0.054529645;
                    }
                }
            }
            double var91;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var91 = 0.049914323;
                    } else {
                        var91 = -0.034755222;
                    }
                } else {
                    var91 = -0.043053575;
                }
            } else {
                if (input[1] < 5.0) {
                    var91 = -0.048066817;
                } else {
                    var91 = 0.0055181677;
                }
            }
            double var92;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var92 = -0.042823557;
                } else {
                    if (input[0] < 18.0) {
                        var92 = -0.0155319935;
                    } else {
                        var92 = 0.016223677;
                    }
                }
            } else {
                var92 = 0.048915677;
            }
            double var93;
            if (input[5] < 1.0) {
                var93 = -0.04693784;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var93 = 0.05082156;
                    } else {
                        var93 = 0.010901631;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var93 = 0.020870535;
                    } else {
                        var93 = -0.016704712;
                    }
                }
            }
            double var94;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var94 = -0.042664826;
                } else {
                    var94 = 0.036065586;
                }
            } else {
                var94 = 0.054644465;
            }
            double var95;
            if (input[0] < 16.0) {
                var95 = -0.041912403;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var95 = 0.041773293;
                    } else {
                        var95 = -0.026835132;
                    }
                } else {
                    var95 = -0.040822793;
                }
            }
            double var96;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var96 = -0.042219706;
                } else {
                    if (input[0] < 18.0) {
                        var96 = -0.015455886;
                    } else {
                        var96 = 0.015508211;
                    }
                }
            } else {
                var96 = 0.047532912;
            }
            double var97;
            if (input[5] < 1.0) {
                var97 = -0.046349917;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var97 = 0.050003916;
                    } else {
                        var97 = 0.010466214;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var97 = 0.020508429;
                    } else {
                        var97 = -0.01634706;
                    }
                }
            }
            double var98;
            if (input[2] < 8.0) {
                if (input[1] < 8.0) {
                    var98 = -0.039465062;
                } else {
                    var98 = 0.010139435;
                }
            } else {
                if (input[4] < 1.0) {
                    var98 = 0.014351455;
                } else {
                    if (input[2] < 12.0) {
                        var98 = 0.013086833;
                    } else {
                        var98 = 0.051841278;
                    }
                }
            }
            double var99;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var99 = 0.04841432;
                    } else {
                        var99 = -0.03312732;
                    }
                } else {
                    var99 = -0.04139762;
                }
            } else {
                if (input[1] < 5.0) {
                    var99 = -0.046888623;
                } else {
                    var99 = 0.0059498413;
                }
            }
            double var100;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var100 = -0.041591898;
                } else {
                    if (input[2] < 2.0) {
                        var100 = -0.017688012;
                    } else {
                        var100 = 0.012931446;
                    }
                }
            } else {
                var100 = 0.046243716;
            }
            double var101;
            if (input[5] < 1.0) {
                var101 = -0.04574529;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var101 = 0.049175527;
                    } else {
                        var101 = 0.010031147;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var101 = 0.019302063;
                    } else {
                        var101 = -0.016187599;
                    }
                }
            }
            double var102;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var102 = -0.04157;
                } else {
                    var102 = 0.0336847;
                }
            } else {
                var102 = 0.05196434;
            }
            double var103;
            if (input[0] < 16.0) {
                var103 = -0.040545933;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var103 = 0.039674483;
                    } else {
                        var103 = -0.02580363;
                    }
                } else {
                    var103 = -0.039019402;
                }
            }
            double var104;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var104 = -0.040968835;
                } else {
                    if (input[0] < 18.0) {
                        var104 = -0.015571557;
                    } else {
                        var104 = 0.014224097;
                    }
                }
            } else {
                var104 = 0.04498673;
            }
            double var105;
            if (input[5] < 1.0) {
                var105 = -0.045155417;
            } else {
                if (input[2] < 7.0) {
                    if (input[4] < 3.0) {
                        var105 = 0.049052726;
                    } else {
                        var105 = 0.0074177566;
                    }
                } else {
                    var105 = -0.0090668695;
                }
            }
            double var106;
            if (input[2] < 8.0) {
                if (input[1] < 7.0) {
                    var106 = -0.037898045;
                } else {
                    var106 = 0.007986528;
                }
            } else {
                if (input[4] < 1.0) {
                    var106 = 0.013087814;
                } else {
                    var106 = 0.044351127;
                }
            }
            double var107;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var107 = 0.04699425;
                    } else {
                        var107 = -0.03156652;
                    }
                } else {
                    var107 = -0.039768856;
                }
            } else {
                if (input[1] < 5.0) {
                    var107 = -0.045756977;
                } else {
                    var107 = 0.006251254;
                }
            }
            double var108;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var108 = -0.040308308;
                } else {
                    if (input[0] < 18.0) {
                        var108 = -0.015474915;
                    } else {
                        var108 = 0.013567922;
                    }
                }
            } else {
                var108 = 0.043767665;
            }
            double var109;
            if (input[5] < 1.0) {
                var109 = -0.044539806;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var109 = 0.047892693;
                    } else {
                        var109 = 0.009299531;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var109 = 0.017681232;
                    } else {
                        var109 = -0.016775398;
                    }
                }
            }
            double var110;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var110 = -0.04046467;
                } else {
                    var110 = 0.031127606;
                }
            } else {
                var110 = 0.049517423;
            }
            double var111;
            if (input[0] < 16.0) {
                var111 = -0.039182816;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var111 = 0.03789499;
                    } else {
                        var111 = -0.024770042;
                    }
                } else {
                    var111 = -0.037279826;
                }
            }
            double var112;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var112 = -0.039666023;
                } else {
                    if (input[3] < 3.0) {
                        var112 = 0.009983926;
                    } else {
                        var112 = -0.015593397;
                    }
                }
            } else {
                var112 = 0.04260817;
            }
            double var113;
            if (input[5] < 1.0) {
                var113 = -0.043947212;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var113 = 0.04716632;
                    } else {
                        var113 = 0.008962027;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var113 = 0.017457323;
                    } else {
                        var113 = -0.016383486;
                    }
                }
            }
            double var114;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var114 = -0.039842874;
                } else {
                    var114 = 0.030163908;
                }
            } else {
                var114 = 0.048218526;
            }
            double var115;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 12.0) {
                        var115 = 0.045641016;
                    } else {
                        var115 = -0.030038783;
                    }
                } else {
                    var115 = -0.03820023;
                }
            } else {
                if (input[1] < 5.0) {
                    var115 = -0.04455529;
                } else {
                    var115 = 0.007041508;
                }
            }
            double var116;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var116 = -0.03897087;
                } else {
                    if (input[0] < 15.0) {
                        var116 = -0.012663515;
                    } else {
                        var116 = 0.007687621;
                    }
                }
            } else {
                var116 = 0.041478347;
            }
            double var117;
            if (input[5] < 1.0) {
                var117 = -0.043295026;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var117 = 0.046461593;
                    } else {
                        var117 = 0.008795623;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var117 = 0.016307792;
                    } else {
                        var117 = -0.016053325;
                    }
                }
            }
            double var118;
            if (input[2] < 8.0) {
                if (input[1] < 6.0) {
                    var118 = -0.035216123;
                } else {
                    var118 = 0.004799442;
                }
            } else {
                if (input[4] < 1.0) {
                    var118 = 0.010803163;
                } else {
                    var118 = 0.041956577;
                }
            }
            double var119;
            if (input[0] < 16.0) {
                var119 = -0.037883595;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var119 = 0.035793822;
                    } else {
                        var119 = -0.023475042;
                    }
                } else {
                    var119 = -0.03559868;
                }
            }
            double var120;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var120 = -0.038336933;
                } else {
                    if (input[0] < 15.0) {
                        var120 = -0.012678768;
                    } else {
                        var120 = 0.0073334323;
                    }
                }
            } else {
                if (input[3] < 4.0) {
                    var120 = 0.04564492;
                } else {
                    var120 = 0.012215021;
                }
            }
            double var121;
            if (input[5] < 1.0) {
                var121 = -0.04272124;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var121 = 0.045704942;
                    } else {
                        var121 = 0.00853268;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var121 = 0.016243014;
                    } else {
                        var121 = -0.015773006;
                    }
                }
            }
            double var122;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var122 = -0.03872911;
                } else {
                    var122 = 0.02855427;
                }
            } else {
                var122 = 0.046108525;
            }
            double var123;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var123 = 0.043808162;
                    } else {
                        var123 = -0.019709123;
                    }
                } else {
                    var123 = -0.036674496;
                }
            } else {
                if (input[1] < 5.0) {
                    var123 = -0.043472033;
                } else {
                    var123 = 0.0071079843;
                }
            }
            double var124;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var124 = -0.03763507;
                } else {
                    if (input[0] < 15.0) {
                        var124 = -0.012698621;
                    } else {
                        var124 = 0.0069402778;
                    }
                }
            } else {
                var124 = 0.039564084;
            }
            double var125;
            if (input[5] < 1.0) {
                var125 = -0.042077392;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var125 = 0.04501846;
                    } else {
                        var125 = 0.008298641;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var125 = 0.015167266;
                    } else {
                        var125 = -0.015440066;
                    }
                }
            }
            double var126;
            if (input[2] < 8.0) {
                if (input[3] < 6.0) {
                    var126 = -0.033693325;
                } else {
                    var126 = 0.0044901567;
                }
            } else {
                if (input[4] < 1.0) {
                    var126 = 0.009893057;
                } else {
                    var126 = 0.04049833;
                }
            }
            double var127;
            if (input[0] < 16.0) {
                var127 = -0.036632698;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var127 = 0.033862464;
                    } else {
                        var127 = -0.02227607;
                    }
                } else {
                    var127 = -0.033990208;
                }
            }
            double var128;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var128 = -0.03699357;
                } else {
                    if (input[0] < 15.0) {
                        var128 = -0.012696467;
                    } else {
                        var128 = 0.0066114697;
                    }
                }
            } else {
                var128 = 0.038555156;
            }
            double var129;
            if (input[5] < 1.0) {
                var129 = -0.041496504;
            } else {
                if (input[2] < 7.0) {
                    if (input[0] < 2.0) {
                        var129 = -0.006866204;
                    } else {
                        var129 = 0.040419735;
                    }
                } else {
                    var129 = -0.009305574;
                }
            }
            double var130;
            if (input[2] < 8.0) {
                if (input[1] < 5.0) {
                    var130 = -0.032339733;
                } else {
                    var130 = 0.0012592134;
                }
            } else {
                if (input[4] < 1.0) {
                    var130 = 0.009680319;
                } else {
                    var130 = 0.039563764;
                }
            }
            double var131;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var131 = 0.042467903;
                    } else {
                        var131 = -0.01844654;
                    }
                } else {
                    var131 = -0.035238028;
                }
            } else {
                if (input[1] < 4.0) {
                    var131 = -0.04219837;
                } else {
                    var131 = 0.004304554;
                }
            }
            double var132;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var132 = -0.036310628;
                } else {
                    if (input[0] < 15.0) {
                        var132 = -0.012254457;
                    } else {
                        var132 = 0.0063137785;
                    }
                }
            } else {
                var132 = 0.03748081;
            }
            double var133;
            if (input[5] < 1.0) {
                var133 = -0.04085913;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var133 = 0.043897312;
                    } else {
                        var133 = 0.007422823;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var133 = 0.014036997;
                    } else {
                        var133 = -0.016110444;
                    }
                }
            }
            double var134;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var134 = -0.03720108;
                } else {
                    var134 = 0.026000366;
                }
            } else {
                var134 = 0.043547705;
            }
            double var135;
            if (input[0] < 16.0) {
                var135 = -0.035398547;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var135 = 0.03249511;
                    } else {
                        var135 = -0.02134898;
                    }
                } else {
                    var135 = -0.032384034;
                }
            }
            double var136;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var136 = -0.03563979;
                } else {
                    var136 = -0.0043240897;
                }
            } else {
                if (input[4] < 7.0) {
                    var136 = 0.011425118;
                } else {
                    var136 = 0.0422546;
                }
            }
            double var137;
            if (input[5] < 1.0) {
                var137 = -0.040245056;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var137 = 0.04322305;
                    } else {
                        var137 = 0.007227171;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var137 = 0.013955985;
                    } else {
                        var137 = -0.015717229;
                    }
                }
            }
            double var138;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var138 = -0.036566008;
                } else {
                    var138 = 0.025362307;
                }
            } else {
                var138 = 0.04254392;
            }
            double var139;
            if (input[0] < 16.0) {
                var139 = -0.0346581;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var139 = 0.03121317;
                    } else {
                        var139 = -0.020648707;
                    }
                } else {
                    var139 = -0.031621415;
                }
            }
            double var140;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var140 = -0.034970887;
                } else {
                    var140 = -0.0045490735;
                }
            } else {
                if (input[4] < 7.0) {
                    var140 = 0.01097837;
                } else {
                    var140 = 0.04137288;
                }
            }
            double var141;
            if (input[5] < 1.0) {
                var141 = -0.039647087;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var141 = 0.042555276;
                    } else {
                        var141 = 0.0071980073;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var141 = 0.013883586;
                    } else {
                        var141 = -0.015337129;
                    }
                }
            }
            double var142;
            if (input[2] < 8.0) {
                if (input[1] < 4.0) {
                    var142 = -0.029401643;
                } else {
                    var142 = -0.0008039062;
                }
            } else {
                if (input[4] < 1.0) {
                    var142 = 0.0079343235;
                } else {
                    var142 = 0.037832104;
                }
            }
            double var143;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var143 = 0.04049569;
                    } else {
                        var143 = -0.016682675;
                    }
                } else {
                    var143 = -0.033197712;
                }
            } else {
                if (input[1] < 4.0) {
                    var143 = -0.04075327;
                } else {
                    var143 = 0.0055991923;
                }
            }
            double var144;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var144 = -0.034278367;
                } else {
                    var144 = -0.0047256383;
                }
            } else {
                var144 = 0.035084367;
            }
            double var145;
            if (input[5] < 1.0) {
                var145 = -0.03901291;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var145 = 0.041844737;
                    } else {
                        var145 = 0.007154014;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var145 = -0.015262795;
                    } else {
                        var145 = 0.01327339;
                    }
                }
            }
            double var146;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var146 = -0.03552719;
                } else {
                    var146 = 0.024244426;
                }
            } else {
                var146 = 0.04088592;
            }
            double var147;
            if (input[0] < 16.0) {
                var147 = -0.033460386;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var147 = 0.029418414;
                    } else {
                        var147 = -0.019627385;
                    }
                } else {
                    var147 = -0.03026999;
                }
            }
            double var148;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var148 = -0.033619095;
                } else {
                    var148 = -0.0049180607;
                }
            } else {
                var148 = 0.034211095;
            }
            double var149;
            if (input[5] < 1.0) {
                var149 = -0.038399722;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var149 = 0.041186;
                    } else {
                        var149 = 0.007076734;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var149 = 0.013434375;
                    } else {
                        var149 = -0.015151768;
                    }
                }
            }
            double var150;
            if (input[2] < 8.0) {
                if (input[1] < 4.0) {
                    var150 = -0.028102195;
                } else {
                    var150 = -0.00044247202;
                }
            } else {
                if (input[4] < 1.0) {
                    var150 = 0.0072902613;
                } else {
                    var150 = 0.03652924;
                }
            }
            double var151;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 9.0) {
                        var151 = 0.038713224;
                    } else {
                        var151 = -0.011064206;
                    }
                } else {
                    var151 = -0.03192057;
                }
            } else {
                if (input[3] < 4.0) {
                    var151 = -0.038336813;
                } else {
                    var151 = -0.002215439;
                }
            }
            double var152;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    if (input[3] < 4.0) {
                        var152 = 0.010618943;
                    } else {
                        var152 = -0.019115178;
                    }
                } else {
                    var152 = -0.03463335;
                }
            } else {
                var152 = 0.03336476;
            }
            double var153;
            if (input[5] < 1.0) {
                var153 = -0.037756093;
            } else {
                if (input[0] < 14.0) {
                    if (input[0] < 2.0) {
                        var153 = 0.007132083;
                    } else {
                        var153 = 0.04099058;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var153 = -0.015094407;
                    } else {
                        var153 = 0.012777722;
                    }
                }
            }
            double var154;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var154 = -0.034507565;
                } else {
                    var154 = 0.02314632;
                }
            } else {
                var154 = 0.03944728;
            }
            double var155;
            if (input[0] < 16.0) {
                var155 = -0.032316472;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var155 = 0.027856275;
                    } else {
                        var155 = -0.018855784;
                    }
                } else {
                    var155 = -0.028865704;
                }
            }
            double var156;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var156 = -0.032457586;
                } else {
                    var156 = -0.004601909;
                }
            } else {
                var156 = 0.032546237;
            }
            double var157;
            if (input[5] < 1.0) {
                var157 = -0.037129696;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var157 = 0.040065806;
                    } else {
                        var157 = 0.006035243;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var157 = 0.013044447;
                    } else {
                        var157 = -0.014944975;
                    }
                }
            }
            double var158;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var158 = -0.03389245;
                } else {
                    var158 = 0.02213396;
                }
            } else {
                var158 = 0.03859763;
            }
            double var159;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 9.0) {
                        var159 = 0.037471842;
                    } else {
                        var159 = -0.010478761;
                    }
                } else {
                    var159 = -0.030618507;
                }
            } else {
                if (input[3] < 4.0) {
                    var159 = -0.03730431;
                } else {
                    var159 = -0.001696555;
                }
            }
            double var160;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    var160 = -0.0056876284;
                } else {
                    var160 = -0.03338912;
                }
            } else {
                var160 = 0.031733703;
            }
            double var161;
            if (input[5] < 1.0) {
                var161 = -0.036455072;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var161 = 0.03943428;
                    } else {
                        var161 = 0.0060344567;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var161 = -0.014930566;
                    } else {
                        var161 = 0.012277154;
                    }
                }
            }
            double var162;
            if (input[2] < 8.0) {
                var162 = -0.018025434;
            } else {
                if (input[4] < 1.0) {
                    var162 = 0.006196119;
                } else {
                    var162 = 0.035109997;
                }
            }
            double var163;
            if (input[0] < 16.0) {
                var163 = -0.031210998;
            } else {
                if (input[4] < 5.0) {
                    if (input[3] < 10.0) {
                        var163 = 0.026301628;
                    } else {
                        var163 = -0.017815528;
                    }
                } else {
                    var163 = -0.027520824;
                }
            }
            double var164;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    var164 = -0.0055751083;
                } else {
                    var164 = -0.0327764;
                }
            } else {
                var164 = 0.030969938;
            }
            double var165;
            if (input[5] < 1.0) {
                var165 = -0.035881113;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var165 = 0.03873023;
                    } else {
                        var165 = 0.005650673;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var165 = 0.012699403;
                    } else {
                        var165 = -0.014735885;
                    }
                }
            }
            double var166;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var166 = -0.0328996;
                } else {
                    var166 = 0.021195412;
                }
            } else {
                var166 = 0.03741887;
            }
            double var167;
            if (input[5] < 1.0) {
                if (input[4] < 5.0) {
                    if (input[3] < 9.0) {
                        var167 = 0.036233377;
                    } else {
                        var167 = -0.009989812;
                    }
                } else {
                    var167 = -0.02940973;
                }
            } else {
                if (input[3] < 4.0) {
                    var167 = -0.03627641;
                } else {
                    var167 = -0.0012784832;
                }
            }
            double var168;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    var168 = -0.005334441;
                } else {
                    var168 = -0.032176733;
                }
            } else {
                var168 = 0.030207379;
            }
            double var169;
            if (input[5] < 1.0) {
                var169 = -0.03520727;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var169 = 0.038106795;
                    } else {
                        var169 = 0.005309608;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var169 = -0.0146941915;
                    } else {
                        var169 = 0.0118210865;
                    }
                }
            }
            double var170;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var170 = -0.03225863;
                } else {
                    var170 = 0.020809803;
                }
            } else {
                var170 = 0.036717813;
            }
            double var171;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var171 = 0.002671775;
                } else {
                    var171 = -0.037351135;
                }
            } else {
                if (input[4] < 4.0) {
                    if (input[1] < 4.0) {
                        var171 = 0.007215958;
                    } else {
                        var171 = 0.029358072;
                    }
                } else {
                    var171 = -0.016296646;
                }
            }
            double var172;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var172 = -0.030402064;
                } else {
                    var172 = -0.0040482217;
                }
            } else {
                var172 = 0.029561102;
            }
            double var173;
            if (input[5] < 1.0) {
                var173 = -0.034653157;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var173 = 0.037446;
                    } else {
                        var173 = 0.004925206;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var173 = 0.011729559;
                    } else {
                        var173 = -0.014498288;
                    }
                }
            }
            double var174;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var174 = -0.031731553;
                } else {
                    var174 = 0.020202367;
                }
            } else {
                var174 = 0.036090773;
            }
            double var175;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var175 = 0.0024425914;
                } else {
                    var175 = -0.03668805;
                }
            } else {
                if (input[4] < 4.0) {
                    if (input[1] < 4.0) {
                        var175 = 0.00679917;
                    } else {
                        var175 = 0.028848374;
                    }
                } else {
                    var175 = -0.015797913;
                }
            }
            double var176;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    var176 = -0.004692403;
                } else {
                    var176 = -0.03127071;
                }
            } else {
                var176 = 0.028933069;
            }
            double var177;
            if (input[5] < 1.0) {
                var177 = -0.034104418;
            } else {
                if (input[0] < 14.0) {
                    if (input[0] < 2.0) {
                        var177 = 0.0047103236;
                    } else {
                        var177 = 0.03683028;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var177 = -0.014660055;
                    } else {
                        var177 = 0.011291192;
                    }
                }
            }
            double var178;
            if (input[2] < 8.0) {
                var178 = -0.016313223;
            } else {
                if (input[4] < 1.0) {
                    var178 = 0.0050456133;
                } else {
                    var178 = 0.03334404;
                }
            }
            double var179;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var179 = 0.0021113001;
                } else {
                    var179 = -0.036040116;
                }
            } else {
                if (input[4] < 4.0) {
                    if (input[1] < 4.0) {
                        var179 = 0.0063071647;
                    } else {
                        var179 = 0.028092239;
                    }
                } else {
                    var179 = -0.015367338;
                }
            }
            double var180;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var180 = -0.029536579;
                } else {
                    var180 = -0.0033461358;
                }
            } else {
                var180 = 0.02833424;
            }
            double var181;
            if (input[5] < 1.0) {
                var181 = -0.033596504;
            } else {
                if (input[0] < 14.0) {
                    if (input[4] < 5.0) {
                        var181 = 0.03634505;
                    } else {
                        var181 = 0.004056668;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var181 = 0.011193294;
                    } else {
                        var181 = -0.014323539;
                    }
                }
            }
            double var182;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var182 = -0.030962942;
                } else {
                    var182 = 0.019047612;
                }
            } else {
                var182 = 0.03518046;
            }
            double var183;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var183 = 0.0019343598;
                } else {
                    var183 = -0.03540763;
                }
            } else {
                if (input[4] < 4.0) {
                    var183 = 0.022426527;
                } else {
                    var183 = -0.015008499;
                }
            }
            double var184;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    var184 = -0.004089046;
                } else {
                    var184 = -0.030181084;
                }
            } else {
                var184 = 0.027740225;
            }
            double var185;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var185 = 0.03571261;
                } else {
                    var185 = 0.004066141;
                }
            } else {
                if (input[5] < 1.0) {
                    var185 = -0.033037823;
                } else {
                    if (input[1] < 1.0) {
                        var185 = -0.0145310685;
                    } else {
                        var185 = 0.010870672;
                    }
                }
            }
            double var186;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var186 = -0.030434359;
                } else {
                    var186 = 0.018690612;
                }
            } else {
                var186 = 0.034577545;
            }
            double var187;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var187 = 0.001631172;
                } else {
                    var187 = -0.034776594;
                }
            } else {
                if (input[4] < 4.0) {
                    var187 = 0.02155876;
                } else {
                    var187 = -0.014604889;
                }
            }
            double var188;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    var188 = -0.003934596;
                } else {
                    var188 = -0.029653717;
                }
            } else {
                var188 = 0.027165247;
            }
            double var189;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var189 = 0.035089355;
                } else {
                    var189 = 0.003753467;
                }
            } else {
                if (input[5] < 1.0) {
                    var189 = -0.03248572;
                } else {
                    if (input[3] < 3.0) {
                        var189 = 0.010748663;
                    } else {
                        var189 = -0.0141738625;
                    }
                }
            }
            double var190;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var190 = -0.02991871;
                } else {
                    var190 = 0.018173119;
                }
            } else {
                var190 = 0.03402567;
            }
            double var191;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var191 = 0.0014563029;
                } else {
                    var191 = -0.034147874;
                }
            } else {
                if (input[2] < 4.0) {
                    var191 = -0.005611125;
                } else {
                    var191 = 0.019920243;
                }
            }
            double var192;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var192 = -0.028284717;
                } else {
                    var192 = -0.0027554347;
                }
            } else {
                var192 = 0.026653072;
            }
            double var193;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var193 = 0.034477033;
                } else {
                    var193 = 0.0034584333;
                }
            } else {
                if (input[5] < 1.0) {
                    var193 = -0.031971347;
                } else {
                    if (input[1] < 1.0) {
                        var193 = -0.01443887;
                    } else {
                        var193 = 0.010353434;
                    }
                }
            }
            double var194;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var194 = -0.029426435;
                } else {
                    var194 = 0.017847102;
                }
            } else {
                var194 = 0.03354068;
            }
            double var195;
            if (input[4] < 5.0) {
                if (input[5] < 1.0) {
                    if (input[3] < 7.0) {
                        var195 = 0.031888213;
                    } else {
                        var195 = -0.0034889919;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var195 = -0.030129332;
                    } else {
                        var195 = -0.00045113984;
                    }
                }
            } else {
                var195 = -0.029231349;
            }
            double var196;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    var196 = -0.0034101722;
                } else {
                    var196 = -0.028863985;
                }
            } else {
                var196 = 0.026008794;
            }
            double var197;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var197 = 0.03394937;
                } else {
                    var197 = 0.0035053466;
                }
            } else {
                if (input[5] < 1.0) {
                    var197 = -0.031335842;
                } else {
                    if (input[3] < 3.0) {
                        var197 = 0.009952102;
                    } else {
                        var197 = -0.0139515195;
                    }
                }
            }
            double var198;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var198 = -0.02885881;
                } else {
                    var198 = 0.017402995;
                }
            } else {
                var198 = 0.032963384;
            }
            double var199;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var199 = 0.0010420835;
                } else {
                    var199 = -0.03311635;
                }
            } else {
                if (input[2] < 4.0) {
                    var199 = -0.005775863;
                } else {
                    var199 = 0.019503223;
                }
            }
            double var200;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    var200 = -0.0033138094;
                } else {
                    var200 = -0.02836643;
                }
            } else {
                var200 = 0.025528807;
            }
            double var201;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var201 = 0.033358425;
                } else {
                    var201 = 0.0032276397;
                }
            } else {
                if (input[5] < 1.0) {
                    var201 = -0.030834187;
                } else {
                    if (input[1] < 1.0) {
                        var201 = -0.014210491;
                    } else {
                        var201 = 0.009530333;
                    }
                }
            }
            double var202;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var202 = -0.028383598;
                } else {
                    var202 = 0.017101377;
                }
            } else {
                var202 = 0.03250624;
            }
            double var203;
            if (input[4] < 5.0) {
                if (input[5] < 1.0) {
                    if (input[3] < 6.0) {
                        var203 = 0.029747566;
                    } else {
                        var203 = -0.00007486392;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var203 = -0.028962463;
                    } else {
                        var203 = 0.00013292882;
                    }
                }
            } else {
                var203 = -0.028518736;
            }
            double var204;
            if (input[4] < 6.0) {
                if (input[5] < 1.0) {
                    var204 = -0.0032406372;
                } else {
                    var204 = -0.027886888;
                }
            } else {
                var204 = 0.024921484;
            }
            double var205;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var205 = 0.032850478;
                } else {
                    var205 = 0.002976827;
                }
            } else {
                if (input[4] < 3.0) {
                    if (input[1] < 1.0) {
                        var205 = -0.020300217;
                    } else {
                        var205 = 0.017370991;
                    }
                } else {
                    var205 = -0.03006343;
                }
            }
            double var206;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var206 = -0.027842766;
                } else {
                    var206 = 0.016683437;
                }
            } else {
                var206 = 0.032007124;
            }
            double var207;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var207 = 0.00078967866;
                } else {
                    var207 = -0.032134797;
                }
            } else {
                if (input[2] < 4.0) {
                    var207 = -0.005778859;
                } else {
                    var207 = 0.019160217;
                }
            }
            double var208;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var208 = -0.026663983;
                } else {
                    var208 = -0.002347358;
                }
            } else {
                var208 = 0.024470866;
            }
            double var209;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var209 = 0.032282587;
                } else {
                    var209 = 0.0027276145;
                }
            } else {
                if (input[5] < 1.0) {
                    var209 = -0.029864563;
                } else {
                    if (input[3] < 3.0) {
                        var209 = 0.009089935;
                    } else {
                        var209 = -0.01343385;
                    }
                }
            }
            double var210;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var210 = -0.02739125;
                } else {
                    var210 = 0.016173283;
                }
            } else {
                var210 = 0.03157981;
            }
            double var211;
            if (input[4] < 5.0) {
                if (input[5] < 1.0) {
                    if (input[3] < 6.0) {
                        var211 = 0.028896177;
                    } else {
                        var211 = 0.0000821172;
                    }
                } else {
                    var211 = -0.018172726;
                }
            } else {
                var211 = -0.027840426;
            }
            double var212;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var212 = -0.026093576;
                } else {
                    var212 = -0.0025727737;
                }
            } else {
                var212 = 0.023896521;
            }
            double var213;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var213 = 0.03178438;
                } else {
                    var213 = 0.0027925726;
                }
            } else {
                if (input[4] < 3.0) {
                    if (input[1] < 1.0) {
                        var213 = -0.019677402;
                    } else {
                        var213 = 0.016728858;
                    }
                } else {
                    var213 = -0.029159123;
                }
            }
            double var214;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var214 = -0.026869455;
                } else {
                    var214 = 0.015917508;
                }
            } else {
                var214 = 0.031078676;
            }
            double var215;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var215 = 0.00056820473;
                } else {
                    var215 = -0.031138716;
                }
            } else {
                if (input[2] < 4.0) {
                    var215 = -0.005746955;
                } else {
                    var215 = 0.018680347;
                }
            }
            double var216;
            if (input[4] < 6.0) {
                if (input[4] < 5.0) {
                    var216 = -0.025656616;
                } else {
                    var216 = -0.0025727213;
                }
            } else {
                var216 = 0.023474911;
            }
            double var217;
            if (input[0] < 14.0) {
                if (input[0] < 2.0) {
                    var217 = 0.0023344927;
                } else {
                    var217 = 0.031013358;
                }
            } else {
                if (input[5] < 1.0) {
                    var217 = -0.028926173;
                } else {
                    if (input[3] < 3.0) {
                        var217 = 0.008570506;
                    } else {
                        var217 = -0.013126132;
                    }
                }
            }
            double var218;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var218 = -0.026435006;
                } else {
                    var218 = 0.015442672;
                }
            } else {
                var218 = 0.030646533;
            }
            double var219;
            if (input[4] < 5.0) {
                if (input[5] < 1.0) {
                    if (input[3] < 6.0) {
                        var219 = 0.027893364;
                    } else {
                        var219 = 0.00007459599;
                    }
                } else {
                    var219 = -0.01724718;
                }
            } else {
                var219 = -0.027168864;
            }
            double var220;
            if (input[4] < 6.0) {
                if (input[3] < 3.0) {
                    var220 = -0.0041466528;
                } else {
                    var220 = -0.021613268;
                }
            } else {
                var220 = 0.022932114;
            }
            double var221;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var221 = 0.031031746;
                } else {
                    var221 = 0.0024922292;
                }
            } else {
                if (input[4] < 3.0) {
                    if (input[1] < 1.0) {
                        var221 = -0.019078275;
                    } else {
                        var221 = 0.016124574;
                    }
                } else {
                    var221 = -0.028285274;
                }
            }
            double var222;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var222 = -0.025933424;
                } else {
                    var222 = 0.014937381;
                }
            } else {
                var222 = 0.030171279;
            }
            double var223;
            if (input[4] < 5.0) {
                if (input[5] < 1.0) {
                    var223 = 0.018685928;
                } else {
                    var223 = -0.016746253;
                }
            } else {
                var223 = -0.026652802;
            }
            double var224;
            if (input[4] < 6.0) {
                if (input[3] < 3.0) {
                    var224 = -0.004242446;
                } else {
                    var224 = -0.021124603;
                }
            } else {
                var224 = 0.022411082;
            }
            double var225;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var225 = 0.030587107;
                } else {
                    var225 = 0.0024561645;
                }
            } else {
                if (input[4] < 3.0) {
                    var225 = -0.002239561;
                } else {
                    var225 = -0.027829418;
                }
            }
            double var226;
            if (input[3] < 12.0) {
                if (input[2] < 12.0) {
                    var226 = -0.02544467;
                } else {
                    var226 = 0.0144882;
                }
            } else {
                var226 = 0.02979867;
            }
            double var227;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var227 = 0.00016147898;
                } else {
                    var227 = -0.029782413;
                }
            } else {
                if (input[2] < 4.0) {
                    var227 = -0.0058810282;
                } else {
                    var227 = 0.018132843;
                }
            }
            double var228;
            if (input[4] < 6.0) {
                if (input[3] < 3.0) {
                    var228 = -0.0042176764;
                } else {
                    var228 = -0.02066165;
                }
            } else {
                var228 = 0.022030061;
            }
            double var229;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var229 = 0.030097513;
                } else {
                    var229 = 0.0024130514;
                }
            } else {
                if (input[4] < 3.0) {
                    var229 = -0.002362373;
                } else {
                    var229 = -0.02722675;
                }
            }
            double var230;
            if (input[3] < 12.0) {
                if (input[2] < 13.0) {
                    var230 = -0.0186152;
                } else {
                    var230 = 0.010985496;
                }
            } else {
                var230 = 0.029387949;
            }
            double var231;
            if (input[4] < 5.0) {
                if (input[5] < 1.0) {
                    var231 = 0.018110914;
                } else {
                    var231 = -0.016102735;
                }
            } else {
                var231 = -0.02607729;
            }
            double var232;
            if (input[4] < 6.0) {
                if (input[3] < 3.0) {
                    var232 = -0.0043002437;
                } else {
                    var232 = -0.020238953;
                }
            } else {
                var232 = 0.021549523;
            }
            double var233;
            if (input[0] < 14.0) {
                if (input[4] < 5.0) {
                    var233 = 0.029654399;
                } else {
                    var233 = 0.0023862706;
                }
            } else {
                if (input[4] < 3.0) {
                    var233 = -0.0023261965;
                } else {
                    var233 = -0.026794031;
                }
            }
            double var234;
            if (input[3] < 12.0) {
                if (input[2] < 13.0) {
                    var234 = -0.018195152;
                } else {
                    var234 = 0.010914604;
                }
            } else {
                var234 = 0.029043982;
            }
            double var235;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var235 = -0.000055097196;
                } else {
                    var235 = -0.028975418;
                }
            } else {
                if (input[2] < 4.0) {
                    var235 = -0.005985999;
                } else {
                    var235 = 0.017543882;
                }
            }
            double var236;
            if (input[4] < 6.0) {
                if (input[3] < 3.0) {
                    var236 = -0.004264882;
                } else {
                    var236 = -0.01984029;
                }
            } else {
                var236 = 0.021202235;
            }
            double var237;
            if (input[0] < 14.0) {
                var237 = 0.020758146;
            } else {
                if (input[5] < 1.0) {
                    var237 = -0.026882354;
                } else {
                    var237 = -0.002683873;
                }
            }
            double var238;
            if (input[2] < 8.0) {
                var238 = -0.012187957;
            } else {
                if (input[4] < 2.0) {
                    var238 = 0.002721898;
                } else {
                    var238 = 0.028612414;
                }
            }
            double var239;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var239 = -0.00013547055;
                } else {
                    var239 = -0.028506551;
                }
            } else {
                if (input[2] < 4.0) {
                    var239 = -0.0059023197;
                } else {
                    var239 = 0.01703458;
                }
            }
            double var240;
            if (input[4] < 6.0) {
                if (input[3] < 3.0) {
                    var240 = -0.004105128;
                } else {
                    var240 = -0.01936601;
                }
            } else {
                var240 = 0.021019613;
            }
            double var241;
            if (input[0] < 14.0) {
                var241 = 0.020165628;
            } else {
                if (input[5] < 1.0) {
                    var241 = -0.02649559;
                } else {
                    var241 = -0.0026698655;
                }
            }
            double var242;
            if (input[3] < 12.0) {
                if (input[2] < 13.0) {
                    var242 = -0.01786617;
                } else {
                    var242 = 0.010616556;
                }
            } else {
                var242 = 0.02847783;
            }
            double var243;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var243 = -0.00025571272;
                } else {
                    var243 = -0.028048087;
                }
            } else {
                if (input[1] < 4.0) {
                    var243 = -0.004352604;
                } else {
                    var243 = 0.013581901;
                }
            }
            double var244;
            if (input[4] < 6.0) {
                if (input[3] < 3.0) {
                    var244 = -0.0039594914;
                } else {
                    var244 = -0.018931918;
                }
            } else {
                var244 = 0.020830316;
            }
            double var245;
            if (input[0] < 14.0) {
                var245 = 0.01963113;
            } else {
                if (input[4] < 3.0) {
                    var245 = -0.0023081019;
                } else {
                    var245 = -0.025582546;
                }
            }
            double var246;
            if (input[3] < 12.0) {
                if (input[2] < 13.0) {
                    var246 = -0.017521217;
                } else {
                    var246 = 0.010431656;
                }
            } else {
                var246 = 0.02811776;
            }
            double var247;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var247 = -0.00039587237;
                } else {
                    var247 = -0.027597502;
                }
            } else {
                if (input[1] < 4.0) {
                    var247 = -0.0044542756;
                } else {
                    var247 = 0.013331856;
                }
            }
            double var248;
            if (input[4] < 6.0) {
                var248 = -0.014432852;
            } else {
                var248 = 0.020645358;
            }
            double var249;
            if (input[0] < 14.0) {
                var249 = 0.019117774;
            } else {
                if (input[5] < 1.0) {
                    var249 = -0.0258028;
                } else {
                    var249 = -0.0026418373;
                }
            }
            double var250;
            if (input[3] < 12.0) {
                if (input[2] < 13.0) {
                    var250 = -0.017191974;
                } else {
                    var250 = 0.010254896;
                }
            } else {
                var250 = 0.027778218;
            }
            double var251;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var251 = -0.00046267948;
                } else {
                    var251 = -0.02716783;
                }
            } else {
                if (input[1] < 4.0) {
                    var251 = -0.004473343;
                } else {
                    var251 = 0.012957739;
                }
            }
            double var252;
            if (input[4] < 6.0) {
                var252 = -0.013955327;
            } else {
                var252 = 0.020462608;
            }
            double var253;
            if (input[0] < 14.0) {
                var253 = 0.018586755;
            } else {
                if (input[5] < 1.0) {
                    var253 = -0.025427824;
                } else {
                    var253 = -0.0027169762;
                }
            }
            double var254;
            if (input[3] < 12.0) {
                if (input[2] < 13.0) {
                    var254 = -0.016863903;
                } else {
                    var254 = 0.010076036;
                }
            } else {
                var254 = 0.027443642;
            }
            double var255;
            if (input[0] < 20.0) {
                if (input[5] < 1.0) {
                    var255 = -0.00065836916;
                } else {
                    var255 = -0.026737288;
                }
            } else {
                if (input[1] < 5.0) {
                    var255 = -0.0025696536;
                } else {
                    var255 = 0.011307997;
                }
            }
            double var256;
            if (input[3] < 5.0) {
                if (input[3] < 2.0) {
                    var256 = 0.00048811347;
                } else {
                    var256 = 0.020614741;
                }
            } else {
                var256 = -0.020485405;
            }
            double var257;
            if (input[0] < 14.0) {
                var257 = 0.018078122;
            } else {
                if (input[4] < 3.0) {
                    var257 = -0.0023174684;
                } else {
                    var257 = -0.024533069;
                }
            }
            double var258;
            if (input[2] < 10.0) {
                var258 = -0.008753623;
            } else {
                var258 = 0.020616142;
            }
            double var259;
            if (input[0] < 20.0) {
                if (input[0] < 17.0) {
                    var259 = -0.020651734;
                } else {
                    var259 = -0.005104522;
                }
            } else {
                var259 = 0.005435993;
            }
            double var260;
            if (input[4] < 6.0) {
                var260 = -0.013493421;
            } else {
                var260 = 0.020494485;
            }
            double var261;
            if (input[0] < 14.0) {
                var261 = 0.017751908;
            } else {
                if (input[4] < 3.0) {
                    var261 = -0.0021386554;
                } else {
                    var261 = -0.024076486;
                }
            }
            double var262;
            if (input[2] < 10.0) {
                var262 = -0.008580482;
            } else {
                var262 = 0.02004295;
            }
            double var263;
            if (input[0] < 20.0) {
                if (input[0] < 17.0) {
                    var263 = -0.02023746;
                } else {
                    var263 = -0.004983723;
                }
            } else {
                var263 = 0.005143731;
            }
            double var264;
            if (input[3] < 5.0) {
                if (input[3] < 2.0) {
                    var264 = 0.0005398196;
                } else {
                    var264 = 0.020323955;
                }
            } else {
                var264 = -0.01983945;
            }
            double var265;
            if (input[0] < 14.0) {
                var265 = 0.017374618;
            } else {
                if (input[4] < 3.0) {
                    var265 = -0.0019906464;
                } else {
                    var265 = -0.02366891;
                }
            }
            double var266;
            if (input[2] < 10.0) {
                var266 = -0.008406727;
            } else {
                var266 = 0.019612946;
            }
            double var267;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var267 = 0.018265845;
                } else {
                    var267 = -0.013285701;
                }
            } else {
                var267 = -0.019459;
            }
            double var268;
            if (input[4] < 6.0) {
                var268 = -0.013133444;
            } else {
                var268 = 0.020384004;
            }
            double var269;
            if (input[0] < 14.0) {
                var269 = 0.017092926;
            } else {
                if (input[4] < 3.0) {
                    var269 = -0.0018237971;
                } else {
                    var269 = -0.02333391;
                }
            }
            double var270;
            if (input[2] < 10.0) {
                var270 = -0.008203859;
            } else {
                var270 = 0.019084137;
            }
            double var271;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var271 = 0.017854052;
                } else {
                    var271 = -0.0130695;
                }
            } else {
                var271 = -0.019033534;
            }
            double var272;
            if (input[4] < 6.0) {
                var272 = -0.012777242;
            } else {
                var272 = 0.020080214;
            }
            double var273;
            if (input[0] < 14.0) {
                var273 = 0.016760139;
            } else {
                if (input[4] < 3.0) {
                    var273 = -0.0016875614;
                } else {
                    var273 = -0.023042742;
                }
            }
            double var274;
            if (input[2] < 10.0) {
                var274 = -0.008002105;
            } else {
                var274 = 0.018696286;
            }
            double var275;
            if (input[0] < 20.0) {
                if (input[0] < 17.0) {
                    var275 = -0.019745188;
                } else {
                    var275 = -0.00467881;
                }
            } else {
                var275 = 0.0047838446;
            }
            double var276;
            if (input[4] < 6.0) {
                var276 = -0.01239914;
            } else {
                var276 = 0.019854171;
            }
            double var277;
            if (input[0] < 14.0) {
                var277 = 0.016420225;
            } else {
                if (input[4] < 3.0) {
                    var277 = -0.001564024;
                } else {
                    var277 = -0.022657132;
                }
            }
            double var278;
            if (input[2] < 10.0) {
                var278 = -0.0078475205;
            } else {
                var278 = 0.018306356;
            }
            double var279;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var279 = 0.017388226;
                } else {
                    var279 = -0.012897678;
                }
            } else {
                var279 = -0.01871027;
            }
            double var280;
            if (input[4] < 6.0) {
                var280 = -0.012071739;
            } else {
                var280 = 0.019562561;
            }
            double var281;
            if (input[0] < 14.0) {
                var281 = 0.016111841;
            } else {
                if (input[3] < 3.0) {
                    var281 = -0.00014864658;
                } else {
                    var281 = -0.020096574;
                }
            }
            double var282;
            if (input[2] < 10.0) {
                var282 = -0.0076592923;
            } else {
                var282 = 0.017942894;
            }
            double var283;
            if (input[0] < 20.0) {
                if (input[0] < 17.0) {
                    var283 = -0.019376455;
                } else {
                    var283 = -0.004485784;
                }
            } else {
                var283 = 0.004398798;
            }
            double var284;
            if (input[4] < 6.0) {
                var284 = -0.011669385;
            } else {
                var284 = 0.019365607;
            }
            double var285;
            if (input[0] < 14.0) {
                var285 = 0.015796445;
            } else {
                if (input[3] < 3.0) {
                    var285 = -0.00010989243;
                } else {
                    var285 = -0.01964664;
                }
            }
            double var286;
            if (input[2] < 10.0) {
                var286 = -0.0075370106;
            } else {
                var286 = 0.017521234;
            }
            double var287;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var287 = 0.016915614;
                } else {
                    var287 = -0.012756027;
                }
            } else {
                var287 = -0.018367028;
            }
            double var288;
            if (input[4] < 6.0) {
                var288 = -0.011319139;
            } else {
                var288 = 0.019104613;
            }
            double var289;
            if (input[4] < 3.0) {
                if (input[2] < 7.0) {
                    var289 = 0.02154912;
                } else {
                    var289 = -0.0048003867;
                }
            } else {
                var289 = -0.016024744;
            }
            double var290;
            if (input[2] < 10.0) {
                var290 = -0.0073802187;
            } else {
                var290 = 0.017129654;
            }
            double var291;
            if (input[1] < 4.0) {
                if (input[3] < 3.0) {
                    var291 = -0.019825147;
                } else {
                    var291 = -0.0019130625;
                }
            } else {
                var291 = 0.0056731105;
            }
            double var292;
            if (input[4] < 6.0) {
                var292 = -0.011146151;
            } else {
                var292 = 0.018598838;
            }
            double var293;
            if (input[0] < 14.0) {
                var293 = 0.015877364;
            } else {
                if (input[3] < 3.0) {
                    var293 = -0.00043956988;
                } else {
                    var293 = -0.01919796;
                }
            }
            double var294;
            if (input[2] < 10.0) {
                var294 = -0.00716659;
            } else {
                var294 = 0.016595352;
            }
            double var295;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var295 = 0.01651237;
                } else {
                    var295 = -0.012255679;
                }
            } else {
                var295 = -0.01801894;
            }
            double var296;
            if (input[3] < 4.0) {
                var296 = 0.014371841;
            } else {
                var296 = -0.014883126;
            }
            double var297;
            if (input[4] < 3.0) {
                if (input[2] < 7.0) {
                    var297 = 0.02090438;
                } else {
                    var297 = -0.0039748973;
                }
            } else {
                var297 = -0.015738899;
            }
            double var298;
            if (input[2] < 10.0) {
                var298 = -0.007020539;
            } else {
                var298 = 0.01623475;
            }
            double var299;
            if (input[0] < 20.0) {
                var299 = -0.015341158;
            } else {
                var299 = 0.00409244;
            }
            double var300;
            if (input[4] < 6.0) {
                var300 = -0.01105974;
            } else {
                var300 = 0.018254159;
            }
            double var301;
            if (input[0] < 14.0) {
                var301 = 0.015998011;
            } else {
                if (input[3] < 3.0) {
                    var301 = -0.00050340546;
                } else {
                    var301 = -0.018904652;
                }
            }
            double var302;
            if (input[2] < 10.0) {
                var302 = -0.0068764547;
            } else {
                var302 = 0.015601078;
            }
            double var303;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var303 = 0.016259903;
                } else {
                    var303 = -0.011802251;
                }
            } else {
                var303 = -0.017587932;
            }
            double var304;
            if (input[4] < 6.0) {
                var304 = -0.010729651;
            } else {
                var304 = 0.018018935;
            }
            double var305;
            if (input[0] < 14.0) {
                var305 = 0.015707096;
            } else {
                if (input[3] < 3.0) {
                    var305 = -0.0005098525;
                } else {
                    var305 = -0.018521797;
                }
            }
            double var306;
            if (input[2] < 10.0) {
                var306 = -0.006738417;
            } else {
                var306 = 0.015273358;
            }
            double var307;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var307 = 0.015810087;
                } else {
                    var307 = -0.011665309;
                }
            } else {
                var307 = -0.017254893;
            }
            double var308;
            if (input[3] < 4.0) {
                var308 = 0.0140344715;
            } else {
                var308 = -0.014475129;
            }
            double var309;
            if (input[4] < 3.0) {
                if (input[2] < 7.0) {
                    var309 = 0.020412508;
                } else {
                    var309 = -0.002917843;
                }
            } else {
                var309 = -0.015571191;
            }
            double var310;
            if (input[2] < 10.0) {
                var310 = -0.0066053285;
            } else {
                var310 = 0.014956876;
            }
            double var311;
            if (input[1] < 4.0) {
                if (input[3] < 3.0) {
                    var311 = -0.018402288;
                } else {
                    var311 = -0.0019312127;
                }
            } else {
                var311 = 0.005413932;
            }
            double var312;
            if (input[3] < 4.0) {
                var312 = 0.013332307;
            } else {
                var312 = -0.014114799;
            }
            double var313;
            if (input[0] < 14.0) {
                var313 = 0.015847847;
            } else {
                if (input[3] < 3.0) {
                    var313 = -0.0007165869;
                } else {
                    var313 = -0.018141573;
                }
            }
            double var314;
            if (input[2] < 10.0) {
                var314 = -0.0064109094;
            } else {
                var314 = 0.014405715;
            }
            double var315;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var315 = 0.015486603;
                } else {
                    var315 = -0.011234783;
                }
            } else {
                var315 = -0.016890671;
            }
            double var316;
            if (input[3] < 4.0) {
                var316 = 0.013092431;
            } else {
                var316 = -0.013797817;
            }
            double var317;
            if (input[4] < 3.0) {
                if (input[2] < 6.0) {
                    var317 = 0.01738633;
                } else {
                    var317 = 0.0025395926;
                }
            } else {
                var317 = -0.01505858;
            }
            double var318;
            if (input[4] < 1.0) {
                var318 = -0.0067022652;
            } else {
                var318 = 0.013866729;
            }
            double var319;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var319 = 0.015107646;
                } else {
                    var319 = -0.011112503;
                }
            } else {
                var319 = -0.016519539;
            }
            double var320;
            if (input[3] < 4.0) {
                var320 = 0.01248354;
            } else {
                var320 = -0.013500526;
            }
            double var321;
            if (input[0] < 14.0) {
                var321 = 0.015860444;
            } else {
                if (input[3] < 3.0) {
                    var321 = -0.00059708057;
                } else {
                    var321 = -0.017959265;
                }
            }
            double var322;
            if (input[2] < 10.0) {
                var322 = -0.0064731687;
            } else {
                var322 = 0.013892682;
            }
            double var323;
            if (input[0] < 20.0) {
                var323 = -0.013984712;
            } else {
                var323 = 0.0042073247;
            }
            double var324;
            if (input[3] < 4.0) {
                var324 = 0.012246123;
            } else {
                var324 = -0.0131349405;
            }
            double var325;
            if (input[0] < 14.0) {
                var325 = 0.015624146;
            } else {
                if (input[3] < 3.0) {
                    var325 = -0.00051267893;
                } else {
                    var325 = -0.017595394;
                }
            }
            double var326;
            if (input[2] < 10.0) {
                var326 = -0.006388498;
            } else {
                var326 = 0.0134766875;
            }
            double var327;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var327 = 0.014941548;
                } else {
                    var327 = -0.010827346;
                }
            } else {
                var327 = -0.015979279;
            }
            double var328;
            if (input[1] < 1.0) {
                var328 = 0.013018114;
            } else {
                var328 = -0.011880759;
            }
            double var329;
            if (input[4] < 3.0) {
                if (input[0] < 15.0) {
                    var329 = 0.015289021;
                } else {
                    var329 = 0.003733574;
                }
            } else {
                var329 = -0.014658855;
            }
            double var330;
            if (input[4] < 2.0) {
                var330 = -0.0062716478;
            } else {
                var330 = 0.013335245;
            }
            double var331;
            if (input[1] < 4.0) {
                if (input[3] < 3.0) {
                    var331 = -0.016701756;
                } else {
                    var331 = -0.0021207891;
                }
            } else {
                var331 = 0.005382178;
            }
            double var332;
            if (input[3] < 4.0) {
                var332 = 0.011756586;
            } else {
                var332 = -0.012841711;
            }
            double var333;
            if (input[0] < 14.0) {
                var333 = 0.015517004;
            } else {
                if (input[3] < 3.0) {
                    var333 = -0.0005910765;
                } else {
                    var333 = -0.01717689;
                }
            }
            double var334;
            if (input[2] < 10.0) {
                var334 = -0.006419507;
            } else {
                var334 = 0.01321135;
            }
            double var335;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var335 = 0.014613372;
                } else {
                    var335 = -0.010627659;
                }
            } else {
                var335 = -0.01548585;
            }
            double var336;
            if (input[1] < 1.0) {
                var336 = 0.0125062885;
            } else {
                var336 = -0.011618627;
            }
            double var337;
            if (input[4] < 3.0) {
                if (input[0] < 15.0) {
                    var337 = 0.014984079;
                } else {
                    var337 = 0.0037114553;
                }
            } else {
                var337 = -0.014216991;
            }
            double var338;
            if (input[2] < 10.0) {
                var338 = -0.006287387;
            } else {
                var338 = 0.012871024;
            }
            double var339;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var339 = 0.014253502;
                } else {
                    var339 = -0.010518679;
                }
            } else {
                var339 = -0.015157066;
            }
            double var340;
            if (input[1] < 1.0) {
                var340 = 0.011944258;
            } else {
                var340 = -0.011433548;
            }
            double var341;
            if (input[0] < 16.0) {
                if (input[4] < 3.0) {
                    var341 = 0.017489696;
                } else {
                    var341 = -0.00008358215;
                }
            } else {
                var341 = -0.014894093;
            }
            double var342;
            if (input[2] < 10.0) {
                var342 = -0.006128403;
            } else {
                var342 = 0.012708031;
            }
            double var343;
            if (input[0] < 20.0) {
                var343 = -0.013078185;
            } else {
                var343 = 0.0039535793;
            }
            double var344;
            if (input[1] < 1.0) {
                var344 = 0.01159333;
            } else {
                var344 = -0.011172793;
            }
            double var345;
            if (input[0] < 14.0) {
                var345 = 0.0154679185;
            } else {
                if (input[3] < 3.0) {
                    var345 = -0.00046585873;
                } else {
                    var345 = -0.016784599;
                }
            }
            double var346;
            if (input[4] < 2.0) {
                var346 = -0.0060558966;
            } else {
                var346 = 0.012645942;
            }
            double var347;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var347 = 0.013963262;
                } else {
                    var347 = -0.010298626;
                }
            } else {
                var347 = -0.0147913685;
            }
            double var348;
            if (input[1] < 1.0) {
                var348 = 0.011396998;
            } else {
                var348 = -0.010804223;
            }
            double var349;
            if (input[4] < 2.0) {
                var349 = 0.016112652;
            } else {
                if (input[2] < 2.0) {
                    var349 = 0.004832971;
                } else {
                    var349 = -0.02167625;
                }
            }
            double var350;
            if (input[2] < 10.0) {
                var350 = -0.0062020356;
            } else {
                var350 = 0.0124732535;
            }
            double var351;
            if (input[1] < 4.0) {
                var351 = -0.011741321;
            } else {
                var351 = 0.005062728;
            }
            double var352;
            if (input[1] < 1.0) {
                var352 = 0.011044936;
            } else {
                var352 = -0.01050632;
            }
            double var353;
            if (input[0] < 16.0) {
                if (input[4] < 3.0) {
                    var353 = 0.017298091;
                } else {
                    var353 = -0.00023549794;
                }
            } else {
                var353 = -0.014474422;
            }
            double var354;
            if (input[2] < 10.0) {
                var354 = -0.006090924;
            } else {
                var354 = 0.012156918;
            }
            double var355;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var355 = 0.013726397;
                } else {
                    var355 = -0.010203476;
                }
            } else {
                var355 = -0.01426009;
            }
            double var356;
            if (input[1] < 1.0) {
                var356 = 0.010711897;
            } else {
                var356 = -0.010294507;
            }
            double var357;
            if (input[4] < 3.0) {
                var357 = 0.012242341;
            } else {
                var357 = -0.013471826;
            }
            double var358;
            if (input[2] < 10.0) {
                var358 = -0.005930106;
            } else {
                var358 = 0.011999546;
            }
            double var359;
            if (input[0] < 20.0) {
                var359 = -0.012313759;
            } else {
                var359 = 0.003569876;
            }
            double var360;
            if (input[1] < 1.0) {
                var360 = 0.010216763;
            } else {
                var360 = -0.01011426;
            }
            double var361;
            if (input[0] < 14.0) {
                var361 = 0.015188254;
            } else {
                if (input[3] < 3.0) {
                    var361 = -0.00048163632;
                } else {
                    var361 = -0.016294962;
                }
            }
            double var362;
            if (input[2] < 10.0) {
                var362 = -0.0058231438;
            } else {
                var362 = 0.0118163;
            }
            double var363;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var363 = 0.013488625;
                } else {
                    var363 = -0.009922987;
                }
            } else {
                var363 = -0.013927789;
            }
            double var364;
            if (input[1] < 1.0) {
                var364 = 0.01004966;
            } else {
                var364 = -0.009822591;
            }
            double var365;
            if (input[0] < 16.0) {
                if (input[4] < 3.0) {
                    var365 = 0.01689149;
                } else {
                    var365 = -0.000008814162;
                }
            } else {
                var365 = -0.0141072795;
            }
            double var366;
            if (input[4] < 2.0) {
                var366 = -0.0057718526;
            } else {
                var366 = 0.011684343;
            }
            double var367;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var367 = 0.01314036;
                } else {
                    var367 = -0.009830508;
                }
            } else {
                var367 = -0.013633333;
            }
            double var368;
            if (input[1] < 1.0) {
                var368 = 0.009764209;
            } else {
                var368 = -0.009585689;
            }
            double var369;
            if (input[4] < 2.0) {
                var369 = 0.015680162;
            } else {
                if (input[2] < 2.0) {
                    var369 = 0.0049766037;
                } else {
                    var369 = -0.02106796;
                }
            }
            double var370;
            if (input[2] < 10.0) {
                var370 = -0.0058441265;
            } else {
                var370 = 0.011679494;
            }
            double var371;
            if (input[1] < 4.0) {
                var371 = -0.010861806;
            } else {
                var371 = 0.004598303;
            }
            double var372;
            if (input[1] < 1.0) {
                var372 = 0.009470243;
            } else {
                var372 = -0.009323156;
            }
            double var373;
            if (input[0] < 16.0) {
                if (input[4] < 3.0) {
                    var373 = 0.016680429;
                } else {
                    var373 = 0.00007228154;
                }
            } else {
                var373 = -0.013929266;
            }
            double var374;
            if (input[2] < 10.0) {
                var374 = -0.005742892;
            } else {
                var374 = 0.0113923615;
            }
            double var375;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var375 = 0.0129018845;
                } else {
                    var375 = -0.009725996;
                }
            } else {
                var375 = -0.013169536;
            }
            double var376;
            if (input[1] < 1.0) {
                var376 = 0.009191509;
            } else {
                var376 = -0.00914304;
            }
            double var377;
            if (input[0] < 14.0) {
                var377 = 0.01463182;
            } else {
                if (input[3] < 3.0) {
                    var377 = -0.0002896083;
                } else {
                    var377 = -0.01573128;
                }
            }
            double var378;
            if (input[2] < 10.0) {
                var378 = -0.0055934796;
            } else {
                var378 = 0.011260398;
            }
            double var379;
            if (input[0] < 20.0) {
                var379 = -0.011473305;
            } else {
                var379 = 0.0033015439;
            }
            double var380;
            if (input[1] < 1.0) {
                var380 = 0.009058878;
            } else {
                var380 = -0.0088592535;
            }
            double var381;
            if (input[4] < 3.0) {
                var381 = 0.012108729;
            } else {
                var381 = -0.012916033;
            }
            double var382;
            if (input[4] < 2.0) {
                var382 = -0.005539959;
            } else {
                var382 = 0.010978921;
            }
            double var383;
            if (input[4] < 4.0) {
                if (input[5] < 1.0) {
                    var383 = 0.012599944;
                } else {
                    var383 = -0.009671397;
                }
            } else {
                var383 = -0.012840933;
            }
            double var384;
            if (input[1] < 1.0) {
                var384 = 0.008628741;
            } else {
                var384 = -0.008695418;
            }
            double var385;
            if (input[0] < 16.0) {
                if (input[4] < 3.0) {
                    var385 = 0.016165381;
                } else {
                    var385 = 0.0002845159;
                }
            } else {
                var385 = -0.013632141;
            }
            double var386;
            if (input[2] < 10.0) {
                var386 = -0.00565759;
            } else {
                var386 = 0.011127426;
            }
            double var387;
            if (input[0] < 20.0) {
                var387 = -0.011025745;
            } else {
                var387 = 0.0032442217;
            }
            double var388;
            if (input[1] < 1.0) {
                var388 = 0.008381743;
            } else {
                var388 = -0.008509026;
            }
            double var389;
            if (input[0] < 14.0) {
                var389 = 0.014427262;
            } else {
                if (input[3] < 3.0) {
                    var389 = -0.0003190427;
                } else {
                    var389 = -0.015456188;
                }
            }
            double var390;
            if (input[2] < 10.0) {
                var390 = -0.005559371;
            } else {
                var390 = 0.010959251;
            }
            double var391;
            if (input[4] < 4.0) {
                if (input[0] < 20.0) {
                    var391 = -0.008767613;
                } else {
                    var391 = 0.011769741;
                }
            } else {
                var391 = -0.0124471225;
            }
            double var392;
            if (input[1] < 1.0) {
                var392 = 0.008254026;
            } else {
                var392 = -0.008294556;
            }
            double var393;
            if (input[4] < 3.0) {
                var393 = 0.011893748;
            } else {
                var393 = -0.012461868;
            }
            double var394;
            if (input[2] < 10.0) {
                var394 = -0.005543274;
            } else {
                var394 = 0.010709207;
            }
            double var395;
            if (input[4] < 4.0) {
                var395 = 0.0018569231;
            } else {
                var395 = -0.012191684;
            }
            double var396;
            if (input[1] < 1.0) {
                var396 = 0.007817388;
            } else {
                var396 = -0.008209547;
            }
            double var397;
            if (input[0] < 14.0) {
                var397 = 0.014383244;
            } else {
                if (input[3] < 3.0) {
                    var397 = -0.00030377466;
                } else {
                    var397 = -0.015081681;
                }
            }
            double var398;
            if (input[2] < 10.0) {
                var398 = -0.0054723877;
            } else {
                var398 = 0.010593657;
            }
            double var399;
            if (input[4] < 4.0) {
                var399 = 0.0019000488;
            } else {
                var399 = -0.011975615;
            }
            return Softmax(new double[4] {0.0 + (var0 + var1 + var2 + var3 + var4 + var5 + var6 + var7 + var8 + var9 + var10 + var11 + var12 + var13 + var14 + var15 + var16 + var17 + var18 + var19 + var20 + var21 + var22 + var23 + var24 + var25 + var26 + var27 + var28 + var29 + var30 + var31 + var32 + var33 + var34 + var35 + var36 + var37 + var38 + var39 + var40 + var41 + var42 + var43 + var44 + var45 + var46 + var47 + var48 + var49 + var50 + var51 + var52 + var53 + var54 + var55 + var56 + var57 + var58 + var59 + var60 + var61 + var62 + var63 + var64 + var65 + var66 + var67 + var68 + var69 + var70 + var71 + var72 + var73 + var74 + var75 + var76 + var77 + var78 + var79 + var80 + var81 + var82 + var83 + var84 + var85 + var86 + var87 + var88 + var89 + var90 + var91 + var92 + var93 + var94 + var95 + var96 + var97 + var98 + var99), 0.0 + (var100 + var101 + var102 + var103 + var104 + var105 + var106 + var107 + var108 + var109 + var110 + var111 + var112 + var113 + var114 + var115 + var116 + var117 + var118 + var119 + var120 + var121 + var122 + var123 + var124 + var125 + var126 + var127 + var128 + var129 + var130 + var131 + var132 + var133 + var134 + var135 + var136 + var137 + var138 + var139 + var140 + var141 + var142 + var143 + var144 + var145 + var146 + var147 + var148 + var149 + var150 + var151 + var152 + var153 + var154 + var155 + var156 + var157 + var158 + var159 + var160 + var161 + var162 + var163 + var164 + var165 + var166 + var167 + var168 + var169 + var170 + var171 + var172 + var173 + var174 + var175 + var176 + var177 + var178 + var179 + var180 + var181 + var182 + var183 + var184 + var185 + var186 + var187 + var188 + var189 + var190 + var191 + var192 + var193 + var194 + var195 + var196 + var197 + var198 + var199), 0.0 + (var200 + var201 + var202 + var203 + var204 + var205 + var206 + var207 + var208 + var209 + var210 + var211 + var212 + var213 + var214 + var215 + var216 + var217 + var218 + var219 + var220 + var221 + var222 + var223 + var224 + var225 + var226 + var227 + var228 + var229 + var230 + var231 + var232 + var233 + var234 + var235 + var236 + var237 + var238 + var239 + var240 + var241 + var242 + var243 + var244 + var245 + var246 + var247 + var248 + var249 + var250 + var251 + var252 + var253 + var254 + var255 + var256 + var257 + var258 + var259 + var260 + var261 + var262 + var263 + var264 + var265 + var266 + var267 + var268 + var269 + var270 + var271 + var272 + var273 + var274 + var275 + var276 + var277 + var278 + var279 + var280 + var281 + var282 + var283 + var284 + var285 + var286 + var287 + var288 + var289 + var290 + var291 + var292 + var293 + var294 + var295 + var296 + var297 + var298 + var299), 0.0 + (var300 + var301 + var302 + var303 + var304 + var305 + var306 + var307 + var308 + var309 + var310 + var311 + var312 + var313 + var314 + var315 + var316 + var317 + var318 + var319 + var320 + var321 + var322 + var323 + var324 + var325 + var326 + var327 + var328 + var329 + var330 + var331 + var332 + var333 + var334 + var335 + var336 + var337 + var338 + var339 + var340 + var341 + var342 + var343 + var344 + var345 + var346 + var347 + var348 + var349 + var350 + var351 + var352 + var353 + var354 + var355 + var356 + var357 + var358 + var359 + var360 + var361 + var362 + var363 + var364 + var365 + var366 + var367 + var368 + var369 + var370 + var371 + var372 + var373 + var374 + var375 + var376 + var377 + var378 + var379 + var380 + var381 + var382 + var383 + var384 + var385 + var386 + var387 + var388 + var389 + var390 + var391 + var392 + var393 + var394 + var395 + var396 + var397 + var398 + var399)});
        }
        private static double[] Softmax(double[] x) {
            int size = x.Length;
            double[] result = new double[size];
            double max = x[0];
            for (int i = 1; i < size; ++i) {
                if (x[i] > max)
                    max = x[i];
            }
            double sum = 0.0;
            for (int i = 0; i < size; ++i) {
                result[i] = Exp(x[i] - max);
                sum += result[i];
            }
            for (int i = 0; i < size; ++i)
                result[i] /= sum;
            return result;
        }
    }
}

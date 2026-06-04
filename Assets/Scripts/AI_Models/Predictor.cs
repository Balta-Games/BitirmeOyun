using static System.Math;
namespace ML {
    public static class Model {
        public static double[] Score(double[] input) {
            double var0;
            if (input[2] < 6.0) {
                var0 = -0.14566574;
            } else {
                if (input[1] < 34.0) {
                    var0 = 0.16093703;
                } else {
                    var0 = 0.0032290674;
                }
            }
            double var1;
            if (input[2] < 6.0) {
                var1 = -0.13250306;
            } else {
                if (input[1] < 34.0) {
                    var1 = 0.14546771;
                } else {
                    var1 = 0.0030136788;
                }
            }
            double var2;
            if (input[2] < 6.0) {
                var2 = -0.12158165;
            } else {
                if (input[1] < 34.0) {
                    var2 = 0.13297908;
                } else {
                    var2 = 0.002812663;
                }
            }
            double var3;
            if (input[2] < 6.0) {
                var3 = -0.11227467;
            } else {
                if (input[1] < 34.0) {
                    var3 = 0.12257411;
                } else {
                    var3 = 0.0026250787;
                }
            }
            double var4;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    var4 = -0.12730496;
                } else {
                    if (input[0] < 8.0) {
                        var4 = -0.07481784;
                    } else {
                        var4 = -0.11216755;
                    }
                }
            } else {
                if (input[1] < 34.0) {
                    var4 = 0.11367766;
                } else {
                    var4 = 0.002450016;
                }
            }
            double var5;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    var5 = -0.11985166;
                } else {
                    if (input[0] < 8.0) {
                        var5 = -0.06912608;
                    } else {
                        var5 = -0.10488254;
                    }
                }
            } else {
                if (input[2] < 14.0) {
                    var5 = 0.10577448;
                } else {
                    var5 = -0.009190767;
                }
            }
            double var6;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    var6 = -0.11333574;
                } else {
                    if (input[0] < 8.0) {
                        var6 = -0.06391092;
                    } else {
                        var6 = -0.09837035;
                    }
                }
            } else {
                if (input[1] < 34.0) {
                    if (input[1] < 31.0) {
                        var6 = 0.102253996;
                    } else {
                        var6 = 0.055011757;
                    }
                } else {
                    var6 = -0.002849782;
                }
            }
            double var7;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    var7 = -0.10754098;
                } else {
                    if (input[0] < 9.0) {
                        var7 = -0.063757695;
                    } else {
                        var7 = -0.099774584;
                    }
                }
            } else {
                if (input[2] < 14.0) {
                    var7 = 0.092718;
                } else {
                    var7 = -0.011822697;
                }
            }
            double var8;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    var8 = -0.10230886;
                } else {
                    if (input[0] < 8.0) {
                        var8 = -0.054308873;
                    } else {
                        var8 = -0.08736796;
                    }
                }
            } else {
                if (input[1] < 34.0) {
                    if (input[1] < 31.0) {
                        var8 = 0.0904107;
                    } else {
                        var8 = 0.046151306;
                    }
                } else {
                    var8 = -0.0071048536;
                }
            }
            double var9;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[1] < 10.0) {
                        var9 = -0.059999276;
                    } else {
                        var9 = -0.114537776;
                    }
                } else {
                    if (input[0] < 11.0) {
                        var9 = -0.059213895;
                    } else {
                        var9 = -0.11042873;
                    }
                }
            } else {
                if (input[2] < 14.0) {
                    if (input[1] < 31.0) {
                        var9 = 0.084492445;
                    } else {
                        var9 = 0.049704548;
                    }
                } else {
                    var9 = -0.01375138;
                }
            }
            double var10;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[1] < 10.0) {
                        var10 = -0.05653385;
                    } else {
                        var10 = -0.11058011;
                    }
                } else {
                    if (input[0] < 10.0) {
                        var10 = -0.053744495;
                    } else {
                        var10 = -0.099199936;
                    }
                }
            } else {
                if (input[1] < 34.0) {
                    if (input[3] < 11.0) {
                        var10 = 0.09410583;
                    } else {
                        var10 = 0.06525702;
                    }
                } else {
                    var10 = -0.008894111;
                }
            }
            double var11;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[1] < 10.0) {
                        var11 = -0.053257104;
                    } else {
                        var11 = -0.10700549;
                    }
                } else {
                    if (input[0] < 11.0) {
                        var11 = -0.050872024;
                    } else {
                        var11 = -0.10292057;
                    }
                }
            } else {
                if (input[2] < 14.0) {
                    if (input[3] < 9.0) {
                        var11 = 0.107327186;
                    } else {
                        var11 = 0.06672373;
                    }
                } else {
                    var11 = -0.016604522;
                }
            }
            double var12;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[1] < 10.0) {
                        var12 = -0.050153952;
                    } else {
                        var12 = -0.10374125;
                    }
                } else {
                    if (input[0] < 11.0) {
                        var12 = -0.047127847;
                    } else {
                        var12 = -0.099519126;
                    }
                }
            } else {
                if (input[1] < 31.0) {
                    if (input[2] < 12.0) {
                        var12 = 0.062437028;
                    } else {
                        var12 = 0.10997707;
                    }
                } else {
                    if (input[3] < 10.0) {
                        var12 = 0.043392736;
                    } else {
                        var12 = -0.03388988;
                    }
                }
            }
            double var13;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[1] < 10.0) {
                        var13 = -0.04721219;
                    } else {
                        var13 = -0.10073;
                    }
                } else {
                    if (input[0] < 9.0) {
                        var13 = -0.03853696;
                    } else {
                        var13 = -0.07515072;
                    }
                }
            } else {
                if (input[1] < 34.0) {
                    if (input[3] < 9.0) {
                        var13 = 0.10396782;
                    } else {
                        var13 = 0.05785306;
                    }
                } else {
                    var13 = -0.013332385;
                }
            }
            double var14;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[1] < 10.0) {
                        var14 = -0.04442177;
                    } else {
                        var14 = -0.09792602;
                    }
                } else {
                    if (input[0] < 11.0) {
                        var14 = -0.040118173;
                    } else {
                        var14 = -0.09407592;
                    }
                }
            } else {
                if (input[2] < 14.0) {
                    if (input[3] < 9.0) {
                        var14 = 0.09794375;
                    } else {
                        var14 = 0.054796785;
                    }
                } else {
                    var14 = -0.021879924;
                }
            }
            double var15;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[1] < 10.0) {
                        var15 = -0.041774295;
                    } else {
                        var15 = -0.09529255;
                    }
                } else {
                    if (input[0] < 11.0) {
                        var15 = -0.037044913;
                    } else {
                        var15 = -0.091281384;
                    }
                }
            } else {
                if (input[1] < 31.0) {
                    if (input[2] < 12.0) {
                        var15 = 0.050830096;
                    } else {
                        var15 = 0.102311134;
                    }
                } else {
                    if (input[3] < 10.0) {
                        var15 = 0.034449592;
                    } else {
                        var15 = -0.037377175;
                    }
                }
            }
            double var16;
            if (input[2] < 6.0) {
                if (input[3] < 5.0) {
                    var16 = -0.089266665;
                } else {
                    if (input[0] < 11.0) {
                        var16 = -0.037633475;
                    } else {
                        var16 = -0.088641666;
                    }
                }
            } else {
                if (input[1] < 31.0) {
                    if (input[2] < 12.0) {
                        var16 = 0.047405288;
                    } else {
                        var16 = 0.09932994;
                    }
                } else {
                    if (input[2] < 14.0) {
                        var16 = 0.027405022;
                    } else {
                        var16 = -0.048794623;
                    }
                }
            }
            double var17;
            if (input[2] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[1] < 10.0) {
                        var17 = -0.036059022;
                    } else {
                        var17 = -0.09123921;
                    }
                } else {
                    if (input[0] < 8.0) {
                        var17 = -0.021457506;
                    } else {
                        var17 = -0.05544231;
                    }
                }
            } else {
                if (input[1] < 34.0) {
                    if (input[3] < 9.0) {
                        var17 = 0.09484228;
                    } else {
                        var17 = 0.043528855;
                    }
                } else {
                    var17 = -0.016887972;
                }
            }
            double var18;
            if (input[2] < 6.0) {
                if (input[0] < 4.0) {
                    var18 = -0.08719396;
                } else {
                    if (input[0] < 11.0) {
                        var18 = -0.032028135;
                    } else {
                        var18 = -0.08458703;
                    }
                }
            } else {
                if (input[2] < 14.0) {
                    if (input[3] < 9.0) {
                        var18 = 0.088685185;
                    } else {
                        var18 = 0.041373275;
                    }
                } else {
                    var18 = -0.024987297;
                }
            }
            double var19;
            if (input[2] < 6.0) {
                if (input[3] < 5.0) {
                    var19 = -0.0836144;
                } else {
                    if (input[0] < 11.0) {
                        var19 = -0.029023036;
                    } else {
                        var19 = -0.08225519;
                    }
                }
            } else {
                if (input[1] < 31.0) {
                    if (input[2] < 12.0) {
                        var19 = 0.037909243;
                    } else {
                        var19 = 0.09365266;
                    }
                } else {
                    if (input[3] < 10.0) {
                        var19 = 0.02658132;
                    } else {
                        var19 = -0.039661363;
                    }
                }
            }
            double var20;
            if (input[1] < 18.0) {
                if (input[3] < 5.0) {
                    var20 = -0.08130654;
                } else {
                    if (input[0] < 13.0) {
                        var20 = -0.027092535;
                    } else {
                        var20 = -0.07560637;
                    }
                }
            } else {
                if (input[1] < 31.0) {
                    if (input[2] < 12.0) {
                        var20 = 0.036296863;
                    } else {
                        var20 = 0.091172844;
                    }
                } else {
                    if (input[3] < 10.0) {
                        var20 = 0.024731599;
                    } else {
                        var20 = -0.036673896;
                    }
                }
            }
            double var21;
            if (input[1] < 18.0) {
                if (input[0] < 4.0) {
                    var21 = -0.08198989;
                } else {
                    if (input[0] < 13.0) {
                        var21 = -0.024881525;
                    } else {
                        var21 = -0.07350361;
                    }
                }
            } else {
                if (input[2] < 14.0) {
                    if (input[3] < 9.0) {
                        var21 = 0.08311538;
                    } else {
                        var21 = 0.03393151;
                    }
                } else {
                    var21 = -0.026116436;
                }
            }
            double var22;
            if (input[2] < 6.0) {
                if (input[3] < 5.0) {
                    var22 = -0.07808327;
                } else {
                    if (input[0] < 11.0) {
                        var22 = -0.022191163;
                    } else {
                        var22 = -0.076447494;
                    }
                }
            } else {
                if (input[1] < 31.0) {
                    if (input[2] < 12.0) {
                        var22 = 0.03007575;
                    } else {
                        var22 = 0.0878277;
                    }
                } else {
                    if (input[2] < 14.0) {
                        var22 = 0.016184065;
                    } else {
                        var22 = -0.04541718;
                    }
                }
            }
            double var23;
            if (input[1] < 18.0) {
                if (input[0] < 4.0) {
                    var23 = -0.0785022;
                } else {
                    if (input[3] < 5.0) {
                        var23 = -0.070334904;
                    } else {
                        var23 = -0.020687444;
                    }
                }
            } else {
                if (input[1] < 34.0) {
                    if (input[3] < 9.0) {
                        var23 = 0.08518398;
                    } else {
                        var23 = 0.027940435;
                    }
                } else {
                    var23 = -0.02093767;
                }
            }
            double var24;
            if (input[2] < 6.0) {
                if (input[0] < 4.0) {
                    var24 = -0.07616083;
                } else {
                    if (input[0] < 11.0) {
                        var24 = -0.018385522;
                    } else {
                        var24 = -0.07384531;
                    }
                }
            } else {
                if (input[3] < 11.0) {
                    if (input[1] < 31.0) {
                        var24 = 0.065104626;
                    } else {
                        var24 = 0.013649953;
                    }
                } else {
                    if (input[0] < 17.0) {
                        var24 = 0.031524394;
                    } else {
                        var24 = -0.029367507;
                    }
                }
            }
            double var25;
            if (input[1] < 18.0) {
                if (input[3] < 5.0) {
                    var25 = -0.07323794;
                } else {
                    if (input[0] < 9.0) {
                        var25 = -0.012988067;
                    } else {
                        var25 = -0.04197123;
                    }
                }
            } else {
                if (input[3] < 9.0) {
                    var25 = 0.06841445;
                } else {
                    if (input[2] < 9.0) {
                        var25 = 0.04640865;
                    } else {
                        var25 = 0.0071265856;
                    }
                }
            }
            double var26;
            if (input[2] < 6.0) {
                if (input[0] < 4.0) {
                    var26 = -0.07322533;
                } else {
                    if (input[0] < 11.0) {
                        var26 = -0.014980735;
                    } else {
                        var26 = -0.07075454;
                    }
                }
            } else {
                if (input[2] < 14.0) {
                    if (input[3] < 9.0) {
                        var26 = 0.07445467;
                    } else {
                        var26 = 0.022649188;
                    }
                } else {
                    var26 = -0.02978901;
                }
            }
            double var27;
            if (input[2] < 6.0) {
                if (input[3] < 5.0) {
                    var27 = -0.07058594;
                } else {
                    if (input[0] < 11.0) {
                        var27 = -0.013423535;
                    } else {
                        var27 = -0.06886989;
                    }
                }
            } else {
                if (input[3] < 9.0) {
                    var27 = 0.06424647;
                } else {
                    if (input[1] < 31.0) {
                        var27 = 0.02435535;
                    } else {
                        var27 = -0.022931427;
                    }
                }
            }
            double var28;
            if (input[1] < 18.0) {
                if (input[0] < 4.0) {
                    var28 = -0.0704331;
                } else {
                    if (input[3] < 5.0) {
                        var28 = -0.063557856;
                    } else {
                        var28 = -0.012613783;
                    }
                }
            } else {
                if (input[3] < 11.0) {
                    if (input[0] < 19.0) {
                        var28 = 0.069394544;
                    } else {
                        var28 = 0.018878326;
                    }
                } else {
                    if (input[3] < 13.0) {
                        var28 = -0.02031386;
                    } else {
                        var28 = 0.033249613;
                    }
                }
            }
            double var29;
            if (input[1] < 18.0) {
                if (input[0] < 4.0) {
                    var29 = -0.06841599;
                } else {
                    if (input[3] < 5.0) {
                        var29 = -0.061832435;
                    } else {
                        var29 = -0.011485864;
                    }
                }
            } else {
                if (input[2] < 14.0) {
                    if (input[3] < 9.0) {
                        var29 = 0.069657095;
                    } else {
                        var29 = 0.01841912;
                    }
                } else {
                    var29 = -0.031154275;
                }
            }
            double var30;
            if (input[2] < 6.0) {
                if (input[0] < 11.0) {
                    if (input[0] < 6.0) {
                        var30 = -0.035028644;
                    } else {
                        var30 = -0.0019596245;
                    }
                } else {
                    var30 = -0.06639569;
                }
            } else {
                if (input[3] < 9.0) {
                    var30 = 0.05905221;
                } else {
                    if (input[1] < 31.0) {
                        var30 = 0.019693082;
                    } else {
                        var30 = -0.023692863;
                    }
                }
            }
            double var31;
            if (input[1] < 18.0) {
                if (input[3] < 5.0) {
                    var31 = -0.064684294;
                } else {
                    if (input[0] < 8.0) {
                        var31 = -0.0015229869;
                    } else {
                        var31 = -0.028540576;
                    }
                }
            } else {
                if (input[3] < 11.0) {
                    if (input[0] < 19.0) {
                        var31 = 0.065028965;
                    } else {
                        var31 = 0.015025887;
                    }
                } else {
                    if (input[2] < 9.0) {
                        var31 = 0.034448337;
                    } else {
                        var31 = -0.019092409;
                    }
                }
            }
            double var32;
            if (input[2] < 10.0) {
                if (input[3] < 6.0) {
                    if (input[1] < 10.0) {
                        var32 = 0.0009973312;
                    } else {
                        var32 = -0.078063406;
                    }
                } else {
                    if (input[0] < 17.0) {
                        var32 = -0.0011470641;
                    } else {
                        var32 = -0.057380646;
                    }
                }
            } else {
                if (input[1] < 31.0) {
                    if (input[3] < 12.0) {
                        var32 = 0.061085608;
                    } else {
                        var32 = -0.0010288579;
                    }
                } else {
                    if (input[2] < 14.0) {
                        var32 = 0.006485913;
                    } else {
                        var32 = -0.046903357;
                    }
                }
            }
            double var33;
            if (input[1] < 16.0) {
                if (input[0] < 9.0) {
                    if (input[2] < 4.0) {
                        var33 = 0.0047073932;
                    } else {
                        var33 = -0.05131187;
                    }
                } else {
                    if (input[1] < 14.0) {
                        var33 = -0.08216232;
                    } else {
                        var33 = 0.0031298741;
                    }
                }
            } else {
                if (input[3] < 9.0) {
                    var33 = 0.054956015;
                } else {
                    if (input[1] < 31.0) {
                        var33 = 0.015309781;
                    } else {
                        var33 = -0.022996448;
                    }
                }
            }
            double var34;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    if (input[1] < 9.0) {
                        var34 = -0.019281123;
                    } else {
                        var34 = 0.019665897;
                    }
                } else {
                    var34 = -0.07947903;
                }
            } else {
                if (input[2] < 10.0) {
                    if (input[0] < 17.0) {
                        var34 = -0.0007656338;
                    } else {
                        var34 = -0.053355135;
                    }
                } else {
                    if (input[1] < 28.0) {
                        var34 = 0.057052214;
                    } else {
                        var34 = 0.008949433;
                    }
                }
            }
            double var35;
            if (input[0] < 6.0) {
                if (input[1] < 8.0) {
                    var35 = 0.0071902247;
                } else {
                    if (input[1] < 11.0) {
                        var35 = -0.027618622;
                    } else {
                        var35 = -0.07070469;
                    }
                }
            } else {
                if (input[3] < 11.0) {
                    if (input[3] < 7.0) {
                        var35 = -0.020987412;
                    } else {
                        var35 = 0.05140819;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var35 = -0.07339262;
                    } else {
                        var35 = 0.0009768134;
                    }
                }
            }
            double var36;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    if (input[1] < 9.0) {
                        var36 = -0.018228723;
                    } else {
                        var36 = 0.019952858;
                    }
                } else {
                    var36 = -0.07603831;
                }
            } else {
                if (input[3] < 20.0) {
                    if (input[2] < 3.0) {
                        var36 = -0.019343795;
                    } else {
                        var36 = 0.01475391;
                    }
                } else {
                    var36 = -0.03458772;
                }
            }
            double var37;
            if (input[0] < 6.0) {
                if (input[1] < 8.0) {
                    var37 = 0.008059147;
                } else {
                    if (input[1] < 11.0) {
                        var37 = -0.024403734;
                    } else {
                        var37 = -0.068145655;
                    }
                }
            } else {
                if (input[3] < 11.0) {
                    if (input[3] < 7.0) {
                        var37 = -0.01792991;
                    } else {
                        var37 = 0.047194403;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var37 = -0.07089258;
                    } else {
                        var37 = 0.00019843255;
                    }
                }
            }
            double var38;
            if (input[0] < 4.0) {
                var38 = -0.0643781;
            } else {
                if (input[3] < 20.0) {
                    if (input[3] < 6.0) {
                        var38 = -0.027826456;
                    } else {
                        var38 = 0.0073590474;
                    }
                } else {
                    var38 = -0.03231154;
                }
            }
            double var39;
            if (input[0] < 4.0) {
                var39 = -0.06257667;
            } else {
                if (input[3] < 20.0) {
                    if (input[3] < 6.0) {
                        var39 = -0.026031917;
                    } else {
                        var39 = 0.0066424133;
                    }
                } else {
                    if (input[1] < 14.0) {
                        var39 = -0.009190439;
                    } else {
                        var39 = -0.03366158;
                    }
                }
            }
            double var40;
            if (input[0] < 4.0) {
                var40 = -0.060837448;
            } else {
                if (input[3] < 20.0) {
                    if (input[3] < 6.0) {
                        var40 = -0.024334548;
                    } else {
                        var40 = 0.0059950836;
                    }
                } else {
                    if (input[1] < 14.0) {
                        var40 = -0.008753453;
                    } else {
                        var40 = -0.03178094;
                    }
                }
            }
            double var41;
            if (input[0] < 6.0) {
                if (input[1] < 8.0) {
                    var41 = 0.012836829;
                } else {
                    if (input[1] < 11.0) {
                        var41 = -0.022194488;
                    } else {
                        var41 = -0.066258796;
                    }
                }
            } else {
                if (input[3] < 9.0) {
                    if (input[3] < 7.0) {
                        var41 = -0.014284982;
                    } else {
                        var41 = 0.10896336;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var41 = -0.0692529;
                    } else {
                        var41 = 0.0011125017;
                    }
                }
            }
            double var42;
            if (input[0] < 4.0) {
                var42 = -0.05923031;
            } else {
                if (input[3] < 20.0) {
                    if (input[1] < 31.0) {
                        var42 = 0.005858702;
                    } else {
                        var42 = -0.021350019;
                    }
                } else {
                    if (input[1] < 14.0) {
                        var42 = -0.007842012;
                    } else {
                        var42 = -0.030052636;
                    }
                }
            }
            double var43;
            if (input[0] < 4.0) {
                var43 = -0.05760497;
            } else {
                if (input[1] < 24.0) {
                    if (input[0] < 13.0) {
                        var43 = 0.0005189173;
                    } else {
                        var43 = -0.027813857;
                    }
                } else {
                    if (input[0] < 17.0) {
                        var43 = 0.055684615;
                    } else {
                        var43 = -0.0058062;
                    }
                }
            }
            double var44;
            if (input[0] < 4.0) {
                var44 = -0.056034636;
            } else {
                if (input[2] < 10.0) {
                    if (input[2] < 9.0) {
                        var44 = 0.0015472027;
                    } else {
                        var44 = -0.035965286;
                    }
                } else {
                    if (input[1] < 28.0) {
                        var44 = 0.050679486;
                    } else {
                        var44 = -0.004957423;
                    }
                }
            }
            double var45;
            if (input[0] < 6.0) {
                if (input[1] < 8.0) {
                    var45 = 0.016222596;
                } else {
                    if (input[1] < 11.0) {
                        var45 = -0.020499798;
                    } else {
                        var45 = -0.06454017;
                    }
                }
            } else {
                if (input[3] < 9.0) {
                    if (input[3] < 7.0) {
                        var45 = -0.014222649;
                    } else {
                        var45 = 0.10163629;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var45 = -0.067167394;
                    } else {
                        var45 = 0.0010545123;
                    }
                }
            }
            double var46;
            if (input[0] < 4.0) {
                var46 = -0.05467367;
            } else {
                if (input[3] < 20.0) {
                    if (input[2] < 14.0) {
                        var46 = 0.0043971124;
                    } else {
                        var46 = -0.03691153;
                    }
                } else {
                    if (input[1] < 14.0) {
                        var46 = -0.0069956235;
                    } else {
                        var46 = -0.02849299;
                    }
                }
            }
            double var47;
            if (input[3] < 5.0) {
                var47 = -0.053560197;
            } else {
                if (input[0] < 6.0) {
                    if (input[1] < 11.0) {
                        var47 = -0.0036831626;
                    } else {
                        var47 = -0.060340382;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var47 = 0.039752778;
                    } else {
                        var47 = -0.0031302;
                    }
                }
            }
            double var48;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    var48 = 0.01606221;
                } else {
                    var48 = -0.069529794;
                }
            } else {
                if (input[3] < 11.0) {
                    if (input[0] < 6.0) {
                        var48 = -0.012143452;
                    } else {
                        var48 = 0.027869193;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var48 = -0.06531643;
                    } else {
                        var48 = -0.0006088208;
                    }
                }
            }
            double var49;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    if (input[1] < 9.0) {
                        var49 = -0.0052043567;
                    } else {
                        var49 = 0.026070302;
                    }
                } else {
                    var49 = -0.06710517;
                }
            } else {
                if (input[1] < 9.0) {
                    if (input[2] < 2.0) {
                        var49 = 0.009429297;
                    } else {
                        var49 = -0.068363674;
                    }
                } else {
                    if (input[2] < 2.0) {
                        var49 = -0.06431204;
                    } else {
                        var49 = 0.0070621273;
                    }
                }
            }
            double var50;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    var50 = 0.013879708;
                } else {
                    var50 = -0.064714946;
                }
            } else {
                if (input[3] < 11.0) {
                    if (input[0] < 6.0) {
                        var50 = -0.010447533;
                    } else {
                        var50 = 0.025139648;
                    }
                } else {
                    if (input[0] < 17.0) {
                        var50 = 0.0018722849;
                    } else {
                        var50 = -0.04088338;
                    }
                }
            }
            double var51;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    if (input[1] < 9.0) {
                        var51 = -0.0056201085;
                    } else {
                        var51 = 0.023420634;
                    }
                } else {
                    var51 = -0.06236244;
                }
            } else {
                if (input[3] < 9.0) {
                    if (input[0] < 6.0) {
                        var51 = -0.009589709;
                    } else {
                        var51 = 0.045992877;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var51 = -0.06281826;
                    } else {
                        var51 = -0.00009224636;
                    }
                }
            }
            double var52;
            if (input[0] < 6.0) {
                if (input[1] < 8.0) {
                    var52 = 0.017738499;
                } else {
                    if (input[3] < 6.0) {
                        var52 = -0.058626063;
                    } else {
                        var52 = -0.015048929;
                    }
                }
            } else {
                if (input[0] < 7.0) {
                    if (input[3] < 7.0) {
                        var52 = -0.003849155;
                    } else {
                        var52 = 0.09116508;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var52 = -0.06992851;
                    } else {
                        var52 = 0.0017202244;
                    }
                }
            }
            double var53;
            if (input[1] < 31.0) {
                if (input[2] < 12.0) {
                    if (input[1] < 28.0) {
                        var53 = -0.0008531323;
                    } else {
                        var53 = -0.0411628;
                    }
                } else {
                    var53 = 0.0729746;
                }
            } else {
                if (input[3] < 10.0) {
                    if (input[0] < 22.0) {
                        var53 = 0.03122591;
                    } else {
                        var53 = -0.04037137;
                    }
                } else {
                    var53 = -0.04427099;
                }
            }
            double var54;
            if (input[1] < 24.0) {
                if (input[0] < 13.0) {
                    if (input[1] < 21.0) {
                        var54 = -0.0072718835;
                    } else {
                        var54 = 0.069261394;
                    }
                } else {
                    if (input[2] < 8.0) {
                        var54 = 0.018132685;
                    } else {
                        var54 = -0.038419496;
                    }
                }
            } else {
                if (input[2] < 9.0) {
                    var54 = 0.073768474;
                } else {
                    if (input[3] < 11.0) {
                        var54 = 0.019427253;
                    } else {
                        var54 = -0.031618673;
                    }
                }
            }
            double var55;
            if (input[1] < 31.0) {
                if (input[2] < 12.0) {
                    if (input[1] < 28.0) {
                        var55 = -0.0002607878;
                    } else {
                        var55 = -0.036963064;
                    }
                } else {
                    var55 = 0.071159445;
                }
            } else {
                if (input[2] < 13.0) {
                    var55 = -0.045772716;
                } else {
                    if (input[0] < 22.0) {
                        var55 = 0.058881074;
                    } else {
                        var55 = -0.044992965;
                    }
                }
            }
            double var56;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    var56 = 0.01378634;
                } else {
                    var56 = -0.0596114;
                }
            } else {
                if (input[3] < 20.0) {
                    if (input[2] < 3.0) {
                        var56 = -0.011349609;
                    } else {
                        var56 = 0.0076844664;
                    }
                } else {
                    if (input[3] < 21.0) {
                        var56 = -0.010908428;
                    } else {
                        var56 = -0.029118398;
                    }
                }
            }
            double var57;
            if (input[1] < 31.0) {
                if (input[2] < 12.0) {
                    if (input[1] < 28.0) {
                        var57 = -0.00021601701;
                    } else {
                        var57 = -0.034329694;
                    }
                } else {
                    var57 = 0.06916575;
                }
            } else {
                if (input[2] < 13.0) {
                    var57 = -0.04287007;
                } else {
                    if (input[1] < 34.0) {
                        var57 = 0.042096402;
                    } else {
                        var57 = -0.054165263;
                    }
                }
            }
            double var58;
            if (input[2] < 14.0) {
                if (input[2] < 10.0) {
                    if (input[2] < 9.0) {
                        var58 = 0.00045691672;
                    } else {
                        var58 = -0.03145345;
                    }
                } else {
                    if (input[0] < 15.0) {
                        var58 = 0.06447551;
                    } else {
                        var58 = 0.0062158788;
                    }
                }
            } else {
                var58 = -0.03605097;
            }
            double var59;
            if (input[0] < 6.0) {
                if (input[1] < 11.0) {
                    if (input[3] < 7.0) {
                        var59 = 0.010788069;
                    } else {
                        var59 = -0.03973143;
                    }
                } else {
                    var59 = -0.057896107;
                }
            } else {
                if (input[0] < 7.0) {
                    if (input[3] < 7.0) {
                        var59 = -0.002417687;
                    } else {
                        var59 = 0.084447704;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var59 = -0.067709476;
                    } else {
                        var59 = 0.0020100093;
                    }
                }
            }
            double var60;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    if (input[1] < 9.0) {
                        var60 = -0.006100343;
                    } else {
                        var60 = 0.023093348;
                    }
                } else {
                    var60 = -0.057410087;
                }
            } else {
                if (input[3] < 20.0) {
                    if (input[1] < 9.0) {
                        var60 = -0.018808091;
                    } else {
                        var60 = 0.005781959;
                    }
                } else {
                    if (input[3] < 21.0) {
                        var60 = -0.010108179;
                    } else {
                        var60 = -0.027854903;
                    }
                }
            }
            double var61;
            if (input[1] < 31.0) {
                if (input[2] < 12.0) {
                    if (input[1] < 28.0) {
                        var61 = -0.00009085831;
                    } else {
                        var61 = -0.03243221;
                    }
                } else {
                    var61 = 0.06705708;
                }
            } else {
                if (input[3] < 10.0) {
                    if (input[0] < 22.0) {
                        var61 = 0.02735358;
                    } else {
                        var61 = -0.033638835;
                    }
                } else {
                    var61 = -0.03923487;
                }
            }
            double var62;
            if (input[2] < 14.0) {
                if (input[2] < 10.0) {
                    if (input[0] < 17.0) {
                        var62 = -0.0011997762;
                    } else {
                        var62 = -0.04544588;
                    }
                } else {
                    if (input[0] < 15.0) {
                        var62 = 0.06251215;
                    } else {
                        var62 = 0.0053404067;
                    }
                }
            } else {
                var62 = -0.033792716;
            }
            double var63;
            if (input[1] < 31.0) {
                if (input[2] < 12.0) {
                    if (input[1] < 28.0) {
                        var63 = 0.000018474158;
                    } else {
                        var63 = -0.029924056;
                    }
                } else {
                    var63 = 0.065173924;
                }
            } else {
                if (input[2] < 13.0) {
                    var63 = -0.040388595;
                } else {
                    if (input[1] < 34.0) {
                        var63 = 0.040954866;
                    } else {
                        var63 = -0.04848168;
                    }
                }
            }
            double var64;
            if (input[1] < 24.0) {
                if (input[0] < 8.0) {
                    if (input[2] < 4.0) {
                        var64 = 0.013346517;
                    } else {
                        var64 = -0.07019713;
                    }
                } else {
                    if (input[1] < 12.0) {
                        var64 = -0.06171579;
                    } else {
                        var64 = -0.0058698086;
                    }
                }
            } else {
                if (input[2] < 9.0) {
                    var64 = 0.07162398;
                } else {
                    if (input[3] < 11.0) {
                        var64 = 0.018430075;
                    } else {
                        var64 = -0.028709147;
                    }
                }
            }
            double var65;
            if (input[0] < 6.0) {
                if (input[1] < 11.0) {
                    if (input[3] < 7.0) {
                        var65 = 0.00949677;
                    } else {
                        var65 = -0.03852209;
                    }
                } else {
                    var65 = -0.056525894;
                }
            } else {
                if (input[0] < 7.0) {
                    if (input[3] < 7.0) {
                        var65 = -0.0016034348;
                    } else {
                        var65 = 0.07637211;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var65 = -0.064994685;
                    } else {
                        var65 = 0.0019759913;
                    }
                }
            }
            double var66;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    if (input[1] < 9.0) {
                        var66 = -0.006782984;
                    } else {
                        var66 = 0.020569582;
                    }
                } else {
                    var66 = -0.05535522;
                }
            } else {
                if (input[3] < 20.0) {
                    if (input[3] < 18.0) {
                        var66 = -0.00061971496;
                    } else {
                        var66 = 0.018042391;
                    }
                } else {
                    if (input[3] < 21.0) {
                        var66 = -0.008863953;
                    } else {
                        var66 = -0.026121527;
                    }
                }
            }
            double var67;
            if (input[1] < 31.0) {
                if (input[2] < 12.0) {
                    if (input[1] < 28.0) {
                        var67 = -0.000038901577;
                    } else {
                        var67 = -0.027060708;
                    }
                } else {
                    var67 = 0.06353426;
                }
            } else {
                if (input[2] < 13.0) {
                    var67 = -0.0388437;
                } else {
                    if (input[1] < 34.0) {
                        var67 = 0.03858621;
                    } else {
                        var67 = -0.046143133;
                    }
                }
            }
            double var68;
            if (input[0] < 6.0) {
                if (input[1] < 8.0) {
                    var68 = 0.01707772;
                } else {
                    if (input[3] < 6.0) {
                        var68 = -0.05665898;
                    } else {
                        var68 = -0.011340212;
                    }
                }
            } else {
                if (input[3] < 9.0) {
                    if (input[3] < 7.0) {
                        var68 = -0.01080207;
                    } else {
                        var68 = 0.07165951;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var68 = -0.054407507;
                    } else {
                        var68 = 0.00018545914;
                    }
                }
            }
            double var69;
            if (input[1] < 31.0) {
                if (input[2] < 12.0) {
                    if (input[1] < 28.0) {
                        var69 = 0.00007227222;
                    } else {
                        var69 = -0.024875542;
                    }
                } else {
                    var69 = 0.061649527;
                }
            } else {
                if (input[2] < 13.0) {
                    var69 = -0.03702703;
                } else {
                    if (input[1] < 34.0) {
                        var69 = 0.03631287;
                    } else {
                        var69 = -0.04341563;
                    }
                }
            }
            double var70;
            if (input[1] < 24.0) {
                if (input[1] < 13.0) {
                    if (input[0] < 9.0) {
                        var70 = 0.010102839;
                    } else {
                        var70 = -0.060996115;
                    }
                } else {
                    if (input[3] < 12.0) {
                        var70 = -0.060154345;
                    } else {
                        var70 = -0.00404065;
                    }
                }
            } else {
                if (input[2] < 9.0) {
                    var70 = 0.069673374;
                } else {
                    if (input[3] < 11.0) {
                        var70 = 0.017603789;
                    } else {
                        var70 = -0.026082799;
                    }
                }
            }
            double var71;
            if (input[0] < 6.0) {
                if (input[3] < 7.0) {
                    if (input[1] < 10.0) {
                        var71 = 0.014494978;
                    } else {
                        var71 = -0.05749489;
                    }
                } else {
                    var71 = -0.0425532;
                }
            } else {
                if (input[0] < 7.0) {
                    if (input[3] < 7.0) {
                        var71 = -0.0007975413;
                    } else {
                        var71 = 0.06444319;
                    }
                } else {
                    if (input[1] < 11.0) {
                        var71 = -0.06218936;
                    } else {
                        var71 = 0.001973506;
                    }
                }
            }
            double var72;
            if (input[1] < 31.0) {
                if (input[0] < 20.0) {
                    if (input[2] < 10.0) {
                        var72 = -0.004612064;
                    } else {
                        var72 = 0.015195215;
                    }
                } else {
                    var72 = 0.056608554;
                }
            } else {
                if (input[3] < 10.0) {
                    if (input[0] < 22.0) {
                        var72 = 0.022758855;
                    } else {
                        var72 = -0.027028045;
                    }
                } else {
                    var72 = -0.03579006;
                }
            }
            double var73;
            if (input[1] < 9.0) {
                if (input[2] < 2.0) {
                    if (input[1] < 8.0) {
                        var73 = 0.0271543;
                    } else {
                        var73 = 0.00031516692;
                    }
                } else {
                    var73 = -0.07097363;
                }
            } else {
                if (input[0] < 5.0) {
                    var73 = -0.06238988;
                } else {
                    if (input[1] < 13.0) {
                        var73 = 0.0216062;
                    } else {
                        var73 = -0.0025637003;
                    }
                }
            }
            double var74;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    if (input[1] < 9.0) {
                        var74 = -0.006617824;
                    } else {
                        var74 = 0.019519463;
                    }
                } else {
                    var74 = -0.05242559;
                }
            } else {
                if (input[1] < 9.0) {
                    if (input[2] < 2.0) {
                        var74 = 0.010419063;
                    } else {
                        var74 = -0.061347306;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var74 = 0.02163363;
                    } else {
                        var74 = -0.001429553;
                    }
                }
            }
            double var75;
            if (input[0] < 6.0) {
                if (input[3] < 7.0) {
                    if (input[1] < 10.0) {
                        var75 = 0.013775137;
                    } else {
                        var75 = -0.055758674;
                    }
                } else {
                    var75 = -0.041296244;
                }
            } else {
                if (input[3] < 9.0) {
                    if (input[3] < 7.0) {
                        var75 = -0.010963639;
                    } else {
                        var75 = 0.061174568;
                    }
                } else {
                    if (input[1] < 12.0) {
                        var75 = -0.035753056;
                    } else {
                        var75 = 0.0017708841;
                    }
                }
            }
            double var76;
            if (input[3] < 13.0) {
                if (input[0] < 16.0) {
                    if (input[1] < 22.0) {
                        var76 = 0.0009313519;
                    } else {
                        var76 = -0.080873184;
                    }
                } else {
                    if (input[1] < 27.0) {
                        var76 = 0.065643236;
                    } else {
                        var76 = -0.004612843;
                    }
                }
            } else {
                if (input[0] < 17.0) {
                    if (input[1] < 23.0) {
                        var76 = -0.005960064;
                    } else {
                        var76 = 0.09028773;
                    }
                } else {
                    var76 = -0.082523115;
                }
            }
            double var77;
            if (input[1] < 31.0) {
                if (input[2] < 12.0) {
                    if (input[3] < 13.0) {
                        var77 = -0.008108686;
                    } else {
                        var77 = 0.0051821396;
                    }
                } else {
                    var77 = 0.058941532;
                }
            } else {
                if (input[1] < 33.0) {
                    if (input[2] < 13.0) {
                        var77 = -0.080415845;
                    } else {
                        var77 = 0.027802765;
                    }
                } else {
                    var77 = 0.0020507332;
                }
            }
            double var78;
            if (input[0] < 6.0) {
                if (input[1] < 8.0) {
                    var78 = 0.014389175;
                } else {
                    if (input[3] < 6.0) {
                        var78 = -0.054455023;
                    } else {
                        var78 = -0.008990787;
                    }
                }
            } else {
                if (input[3] < 9.0) {
                    if (input[3] < 7.0) {
                        var78 = -0.009302807;
                    } else {
                        var78 = 0.057445146;
                    }
                } else {
                    if (input[1] < 12.0) {
                        var78 = -0.033695247;
                    } else {
                        var78 = 0.0015453403;
                    }
                }
            }
            double var79;
            if (input[1] < 31.0) {
                if (input[0] < 20.0) {
                    if (input[0] < 19.0) {
                        var79 = 0.00013621712;
                    } else {
                        var79 = -0.028987447;
                    }
                } else {
                    var79 = 0.05419114;
                }
            } else {
                if (input[1] < 33.0) {
                    if (input[2] < 13.0) {
                        var79 = -0.074921;
                    } else {
                        var79 = 0.026257697;
                    }
                } else {
                    var79 = 0.0014670116;
                }
            }
            double var80;
            if (input[1] < 9.0) {
                if (input[2] < 2.0) {
                    if (input[1] < 8.0) {
                        var80 = 0.02405914;
                    } else {
                        var80 = 0.00004586155;
                    }
                } else {
                    var80 = -0.06782494;
                }
            } else {
                if (input[0] < 5.0) {
                    var80 = -0.05959207;
                } else {
                    if (input[1] < 13.0) {
                        var80 = 0.020426525;
                    } else {
                        var80 = -0.0026473398;
                    }
                }
            }
            double var81;
            if (input[2] < 10.0) {
                if (input[0] < 17.0) {
                    if (input[1] < 24.0) {
                        var81 = -0.007082518;
                    } else {
                        var81 = 0.058132093;
                    }
                } else {
                    var81 = -0.038905133;
                }
            } else {
                if (input[0] < 19.0) {
                    if (input[3] < 11.0) {
                        var81 = 0.07027846;
                    } else {
                        var81 = 0.0041162674;
                    }
                } else {
                    if (input[3] < 10.0) {
                        var81 = -0.03256659;
                    } else {
                        var81 = 0.008424717;
                    }
                }
            }
            double var82;
            if (input[2] < 10.0) {
                if (input[2] < 9.0) {
                    if (input[1] < 22.0) {
                        var82 = -0.007648124;
                    } else {
                        var82 = 0.0646581;
                    }
                } else {
                    if (input[3] < 12.0) {
                        var82 = -0.12468473;
                    } else {
                        var82 = 0.015347897;
                    }
                }
            } else {
                if (input[0] < 15.0) {
                    var82 = 0.061196744;
                } else {
                    if (input[3] < 12.0) {
                        var82 = 0.010450973;
                    } else {
                        var82 = -0.043874368;
                    }
                }
            }
            double var83;
            if (input[1] < 31.0) {
                if (input[0] < 20.0) {
                    if (input[0] < 19.0) {
                        var83 = 0.0001352719;
                    } else {
                        var83 = -0.025318144;
                    }
                } else {
                    var83 = 0.052897673;
                }
            } else {
                if (input[1] < 32.0) {
                    var83 = -0.033168115;
                } else {
                    if (input[0] < 22.0) {
                        var83 = 0.018840639;
                    } else {
                        var83 = -0.016934345;
                    }
                }
            }
            double var84;
            if (input[2] < 10.0) {
                if (input[0] < 17.0) {
                    if (input[1] < 24.0) {
                        var84 = -0.0059928433;
                    } else {
                        var84 = 0.054812826;
                    }
                } else {
                    var84 = -0.03697468;
                }
            } else {
                if (input[0] < 19.0) {
                    if (input[3] < 11.0) {
                        var84 = 0.06797275;
                    } else {
                        var84 = 0.0036598232;
                    }
                } else {
                    if (input[3] < 10.0) {
                        var84 = -0.029774291;
                    } else {
                        var84 = 0.008190065;
                    }
                }
            }
            double var85;
            if (input[3] < 18.0) {
                if (input[3] < 17.0) {
                    if (input[3] < 15.0) {
                        var85 = -0.002695286;
                    } else {
                        var85 = 0.03296875;
                    }
                } else {
                    var85 = -0.03807143;
                }
            } else {
                if (input[1] < 12.0) {
                    var85 = -0.040996864;
                } else {
                    if (input[1] < 13.0) {
                        var85 = 0.09701364;
                    } else {
                        var85 = -0.0051591406;
                    }
                }
            }
            double var86;
            if (input[3] < 20.0) {
                if (input[3] < 18.0) {
                    if (input[3] < 17.0) {
                        var86 = -0.00045162693;
                    } else {
                        var86 = -0.036303308;
                    }
                } else {
                    if (input[1] < 12.0) {
                        var86 = -0.034370895;
                    } else {
                        var86 = 0.033870753;
                    }
                }
            } else {
                if (input[3] < 21.0) {
                    var86 = -0.006250053;
                } else {
                    var86 = -0.023132864;
                }
            }
            double var87;
            if (input[2] < 10.0) {
                if (input[2] < 9.0) {
                    if (input[1] < 22.0) {
                        var87 = -0.00657998;
                    } else {
                        var87 = 0.06169766;
                    }
                } else {
                    if (input[3] < 12.0) {
                        var87 = -0.11207151;
                    } else {
                        var87 = 0.014258777;
                    }
                }
            } else {
                if (input[0] < 15.0) {
                    var87 = 0.058768004;
                } else {
                    if (input[3] < 12.0) {
                        var87 = 0.010192985;
                    } else {
                        var87 = -0.040083375;
                    }
                }
            }
            double var88;
            if (input[1] < 31.0) {
                if (input[0] < 20.0) {
                    if (input[0] < 13.0) {
                        var88 = 0.0030424378;
                    } else {
                        var88 = -0.010094721;
                    }
                } else {
                    var88 = 0.051328488;
                }
            } else {
                if (input[1] < 33.0) {
                    if (input[2] < 13.0) {
                        var88 = -0.0695634;
                    } else {
                        var88 = 0.025467819;
                    }
                } else {
                    var88 = 0.0046072267;
                }
            }
            double var89;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    var89 = 0.012303657;
                } else {
                    var89 = -0.049678326;
                }
            } else {
                if (input[0] < 8.0) {
                    if (input[2] < 4.0) {
                        var89 = 0.018162424;
                    } else {
                        var89 = -0.058389075;
                    }
                } else {
                    if (input[2] < 4.0) {
                        var89 = -0.036039308;
                    } else {
                        var89 = 0.0017195333;
                    }
                }
            }
            double var90;
            if (input[1] < 9.0) {
                if (input[2] < 2.0) {
                    if (input[1] < 8.0) {
                        var90 = 0.023231922;
                    } else {
                        var90 = 0.0006256145;
                    }
                } else {
                    var90 = -0.06545854;
                }
            } else {
                if (input[0] < 5.0) {
                    var90 = -0.057489056;
                } else {
                    if (input[1] < 13.0) {
                        var90 = 0.020152954;
                    } else {
                        var90 = -0.002796986;
                    }
                }
            }
            double var91;
            if (input[2] < 10.0) {
                if (input[0] < 17.0) {
                    if (input[1] < 24.0) {
                        var91 = -0.005755504;
                    } else {
                        var91 = 0.052140832;
                    }
                } else {
                    var91 = -0.034172732;
                }
            } else {
                if (input[0] < 19.0) {
                    if (input[3] < 11.0) {
                        var91 = 0.06619049;
                    } else {
                        var91 = 0.0038792398;
                    }
                } else {
                    if (input[3] < 10.0) {
                        var91 = -0.027328758;
                    } else {
                        var91 = 0.007984865;
                    }
                }
            }
            double var92;
            if (input[3] < 18.0) {
                if (input[3] < 17.0) {
                    if (input[3] < 15.0) {
                        var92 = -0.0027636485;
                    } else {
                        var92 = 0.031100659;
                    }
                } else {
                    var92 = -0.034235884;
                }
            } else {
                if (input[1] < 12.0) {
                    var92 = -0.03754161;
                } else {
                    if (input[1] < 13.0) {
                        var92 = 0.08236765;
                    } else {
                        var92 = -0.004635704;
                    }
                }
            }
            double var93;
            if (input[2] < 10.0) {
                if (input[2] < 9.0) {
                    if (input[1] < 22.0) {
                        var93 = -0.006251788;
                    } else {
                        var93 = 0.059209086;
                    }
                } else {
                    if (input[3] < 12.0) {
                        var93 = -0.10006074;
                    } else {
                        var93 = 0.013936298;
                    }
                }
            } else {
                if (input[0] < 15.0) {
                    var93 = 0.056637544;
                } else {
                    if (input[3] < 12.0) {
                        var93 = 0.009981758;
                    } else {
                        var93 = -0.03643652;
                    }
                }
            }
            double var94;
            if (input[3] < 18.0) {
                if (input[3] < 17.0) {
                    if (input[3] < 15.0) {
                        var94 = -0.002618876;
                    } else {
                        var94 = 0.029008482;
                    }
                } else {
                    var94 = -0.03234363;
                }
            } else {
                if (input[1] < 12.0) {
                    var94 = -0.0355093;
                } else {
                    if (input[1] < 13.0) {
                        var94 = 0.07483011;
                    } else {
                        var94 = -0.0036960065;
                    }
                }
            }
            double var95;
            if (input[1] < 31.0) {
                if (input[0] < 20.0) {
                    if (input[0] < 13.0) {
                        var95 = 0.0028408635;
                    } else {
                        var95 = -0.009410271;
                    }
                } else {
                    var95 = 0.04991315;
                }
            } else {
                if (input[1] < 33.0) {
                    if (input[2] < 13.0) {
                        var95 = -0.06481354;
                    } else {
                        var95 = 0.024233017;
                    }
                } else {
                    var95 = 0.005942055;
                }
            }
            double var96;
            if (input[2] < 10.0) {
                if (input[0] < 17.0) {
                    if (input[1] < 24.0) {
                        var96 = -0.0048331036;
                    } else {
                        var96 = 0.04956568;
                    }
                } else {
                    var96 = -0.031738874;
                }
            } else {
                if (input[0] < 19.0) {
                    if (input[3] < 11.0) {
                        var96 = 0.06437456;
                    } else {
                        var96 = 0.004047805;
                    }
                } else {
                    if (input[3] < 10.0) {
                        var96 = -0.02521272;
                    } else {
                        var96 = 0.007871229;
                    }
                }
            }
            double var97;
            if (input[3] < 21.0) {
                if (input[3] < 18.0) {
                    if (input[3] < 16.0) {
                        var97 = -0.00030687996;
                    } else {
                        var97 = -0.02877748;
                    }
                } else {
                    if (input[1] < 12.0) {
                        var97 = -0.031454988;
                    } else {
                        var97 = 0.022920465;
                    }
                }
            } else {
                var97 = -0.020778244;
            }
            double var98;
            if (input[2] < 10.0) {
                if (input[2] < 9.0) {
                    if (input[1] < 22.0) {
                        var98 = -0.0056566796;
                    } else {
                        var98 = 0.056767326;
                    }
                } else {
                    if (input[3] < 12.0) {
                        var98 = -0.089693874;
                    } else {
                        var98 = 0.0135471895;
                    }
                }
            } else {
                if (input[0] < 15.0) {
                    var98 = 0.05449924;
                } else {
                    if (input[3] < 12.0) {
                        var98 = 0.009590064;
                    } else {
                        var98 = -0.033233788;
                    }
                }
            }
            double var99;
            if (input[3] < 6.0) {
                if (input[1] < 10.0) {
                    var99 = 0.013068832;
                } else {
                    var99 = -0.048894208;
                }
            } else {
                if (input[3] < 9.0) {
                    if (input[0] < 5.0) {
                        var99 = -0.0110449325;
                    } else {
                        var99 = 0.022190535;
                    }
                } else {
                    if (input[0] < 8.0) {
                        var99 = 0.019637415;
                    } else {
                        var99 = -0.0052633765;
                    }
                }
            }
            double var100;
            var100 = Sigmoid(-0.04842654165884018 + (var0 + var1 + var2 + var3 + var4 + var5 + var6 + var7 + var8 + var9 + var10 + var11 + var12 + var13 + var14 + var15 + var16 + var17 + var18 + var19 + var20 + var21 + var22 + var23 + var24 + var25 + var26 + var27 + var28 + var29 + var30 + var31 + var32 + var33 + var34 + var35 + var36 + var37 + var38 + var39 + var40 + var41 + var42 + var43 + var44 + var45 + var46 + var47 + var48 + var49 + var50 + var51 + var52 + var53 + var54 + var55 + var56 + var57 + var58 + var59 + var60 + var61 + var62 + var63 + var64 + var65 + var66 + var67 + var68 + var69 + var70 + var71 + var72 + var73 + var74 + var75 + var76 + var77 + var78 + var79 + var80 + var81 + var82 + var83 + var84 + var85 + var86 + var87 + var88 + var89 + var90 + var91 + var92 + var93 + var94 + var95 + var96 + var97 + var98 + var99));
            return new double[2] {1.0 - var100, var100};
        }
        private static double Sigmoid(double x) {
            if (x < 0.0) {
                double z = Exp(x);
                return z / (1.0 + z);
            }
            return 1.0 / (1.0 + Exp(-x));
        }
    }
}

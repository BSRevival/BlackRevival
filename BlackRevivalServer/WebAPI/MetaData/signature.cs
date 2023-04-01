﻿using BlackRevivalServer.Common.Util;
using Grapevine;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlackRevivalServer.WebAPI
{
    [RestResource]
    public class APIsignature
    {
        //This is something we have to come back to in the future
        [RestRoute("Get", "/api/metaData/signature")]
        public static async Task signature(IHttpContext context)
        {
            string resp = "{\"cod\":200,\"msg\":\"SUCCESS\",\"rst\":{\"signatureList\":[{\"cod\":101,\"cc\":1,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JACKIE-A_GROWTH\"},{\"cod\":102,\"cc\":1,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JACKIE-B_GROWTH\"},{\"cod\":103,\"cc\":1,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"JACKIE-C_GROWTH\"},{\"cod\":104,\"cc\":1,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"JACKIE-D_GROWTH\"},{\"cod\":201,\"cc\":2,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"FIORA-A_GROWTH\"},{\"cod\":202,\"cc\":2,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"FIORA-B_GROWTH\"},{\"cod\":203,\"cc\":2,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"FIORA-C_GROWTH\"},{\"cod\":204,\"cc\":2,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"FIORA-D_GROWTH\"},{\"cod\":301,\"cc\":3,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ZAHIR-A_GROWTH\"},{\"cod\":302,\"cc\":3,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ZAHIR-B_GROWTH\"},{\"cod\":303,\"cc\":3,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ZAHIR-C_GROWTH\"},{\"cod\":304,\"cc\":3,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ZAHIR-D_GROWTH\"},{\"cod\":401,\"cc\":4,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"HYUNWOO-A_GROWTH\"},{\"cod\":402,\"cc\":4,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"HYUNWOO-B_GROWTH\"},{\"cod\":403,\"cc\":4,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"HYUNWOO-C_GROWTH\"},{\"cod\":404,\"cc\":4,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"HYUNWOO-D_GROWTH\"},{\"cod\":501,\"cc\":5,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"WILLIAM-A_GROWTH\"},{\"cod\":502,\"cc\":5,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"WILLIAM-B_GROWTH\"},{\"cod\":503,\"cc\":5,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"WILLIAM-C_GROWTH\"},{\"cod\":504,\"cc\":5,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"WILLIAM-D_GROWTH\"},{\"cod\":601,\"cc\":6,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ROSALIO-A_GROWTH\"},{\"cod\":602,\"cc\":6,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ROSALIO-B_GROWTH\"},{\"cod\":603,\"cc\":6,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ROSALIO-C_GROWTH\"},{\"cod\":604,\"cc\":6,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ROSALIO-D_GROWTH\"},{\"cod\":701,\"cc\":7,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JENNY-A_GROWTH\"},{\"cod\":702,\"cc\":7,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JENNY-B_GROWTH\"},{\"cod\":703,\"cc\":7,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"JENNY-C_GROWTH\"},{\"cod\":704,\"cc\":7,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"JENNY-D_GROWTH\"},{\"cod\":801,\"cc\":8,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JP-A_GROWTH\"},{\"cod\":802,\"cc\":8,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JP-B_GROWTH\"},{\"cod\":803,\"cc\":8,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"JP-C_GROWTH\"},{\"cod\":804,\"cc\":8,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"JP-D_GROWTH\"},{\"cod\":901,\"cc\":9,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"XIUKAI-A_GROWTH\"},{\"cod\":902,\"cc\":9,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"XIUKAI-B_GROWTH\"},{\"cod\":903,\"cc\":9,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"XIUKAI-C_GROWTH\"},{\"cod\":904,\"cc\":9,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"XIUKAI-D_GROWTH\"},{\"cod\":1001,\"cc\":10,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"NADINE-A_GROWTH\"},{\"cod\":1002,\"cc\":10,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"NADINE-B_GROWTH\"},{\"cod\":1003,\"cc\":10,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"NADINE-C_GROWTH\"},{\"cod\":1004,\"cc\":10,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"NADINE-D_GROWTH\"},{\"cod\":1101,\"cc\":11,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"AYA-A_GROWTH\"},{\"cod\":1102,\"cc\":11,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"AYA-B_GROWTH\"},{\"cod\":1103,\"cc\":11,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"AYA-C_GROWTH\"},{\"cod\":1104,\"cc\":11,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"AYA-D_GROWTH\"},{\"cod\":1201,\"cc\":12,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"HYEJIN-A_GROWTH\"},{\"cod\":1202,\"cc\":12,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"HYEJIN-B_GROWTH\"},{\"cod\":1203,\"cc\":12,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"HYEJIN-C_GROWTH\"},{\"cod\":1204,\"cc\":12,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"HYEJIN-D_GROWTH\"},{\"cod\":1301,\"cc\":13,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ALEX-A_GROWTH\"},{\"cod\":1302,\"cc\":13,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ALEX-B_GROWTH\"},{\"cod\":1303,\"cc\":13,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ALEX-C_GROWTH\"},{\"cod\":1304,\"cc\":13,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ALEX-D_GROWTH\"},{\"cod\":1401,\"cc\":14,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CATHY-A_GROWTH\"},{\"cod\":1402,\"cc\":14,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CATHY-B_GROWTH\"},{\"cod\":1403,\"cc\":14,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"CATHY-C_GROWTH\"},{\"cod\":1404,\"cc\":14,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"CATHY-D_GROWTH\"},{\"cod\":1501,\"cc\":15,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"BARBARA-A_GROWTH\"},{\"cod\":1502,\"cc\":15,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"BARBARA-B_GROWTH\"},{\"cod\":1503,\"cc\":15,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"BARBARA-C_GROWTH\"},{\"cod\":1504,\"cc\":15,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"BARBARA-D_GROWTH\"},{\"cod\":1601,\"cc\":16,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ISOL-A_GROWTH\"},{\"cod\":1602,\"cc\":16,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ISOL-B_GROWTH\"},{\"cod\":1603,\"cc\":16,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ISOL-C_GROWTH\"},{\"cod\":1604,\"cc\":16,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ISOL-D_GROWTH\"},{\"cod\":1701,\"cc\":17,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"LEON-A_GROWTH\"},{\"cod\":1702,\"cc\":17,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"LEON-B_GROWTH\"},{\"cod\":1703,\"cc\":17,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"LEON-C_GROWTH\"},{\"cod\":1704,\"cc\":17,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"LEON-D_GROWTH\"},{\"cod\":1801,\"cc\":18,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"MAGNUS-A_GROWTH\"},{\"cod\":1802,\"cc\":18,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"MAGNUS-B_GROWTH\"},{\"cod\":1803,\"cc\":18,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"MAGNUS-C_GROWTH\"},{\"cod\":1804,\"cc\":18,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"MAGNUS-D_GROWTH\"},{\"cod\":1901,\"cc\":19,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"SILVIA-A_GROWTH\"},{\"cod\":1902,\"cc\":19,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"SILVIA-B_GROWTH\"},{\"cod\":1903,\"cc\":19,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"SILVIA-C_GROWTH\"},{\"cod\":1904,\"cc\":19,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"SILVIA-D_GROWTH\"},{\"cod\":2001,\"cc\":20,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"DAILIN-A_GROWTH\"},{\"cod\":2002,\"cc\":20,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"DAILIN-B_GROWTH\"},{\"cod\":2003,\"cc\":20,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"DAILIN-C_GROWTH\"},{\"cod\":2004,\"cc\":20,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"DAILIN-D_GROWTH\"},{\"cod\":2101,\"cc\":21,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CHIARA-A_GROWTH\"},{\"cod\":2102,\"cc\":21,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CHIARA-B_GROWTH\"},{\"cod\":2103,\"cc\":21,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"CHIARA-C_GROWTH\"},{\"cod\":2104,\"cc\":21,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"CHIARA-D_GROWTH\"},{\"cod\":2201,\"cc\":22,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"HART-A_GROWTH\"},{\"cod\":2202,\"cc\":22,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"HART-B_GROWTH\"},{\"cod\":2203,\"cc\":22,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"HART-C_GROWTH\"},{\"cod\":2204,\"cc\":22,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"HART-D_GROWTH\"},{\"cod\":2301,\"cc\":23,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"SHOICHI-A_GROWTH\"},{\"cod\":2302,\"cc\":23,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"SHOICHI-B_GROWTH\"},{\"cod\":2303,\"cc\":23,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"SHOICHI-C_GROWTH\"},{\"cod\":2304,\"cc\":23,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"SHOICHI-D_GROWTH\"},{\"cod\":2401,\"cc\":24,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ARDA-A_GROWTH\"},{\"cod\":2402,\"cc\":24,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ARDA-B_GROWTH\"},{\"cod\":2403,\"cc\":24,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ARDA-C_GROWTH\"},{\"cod\":2404,\"cc\":24,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ARDA-D_GROWTH\"},{\"cod\":2501,\"cc\":25,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CAMILO-A_GROWTH\"},{\"cod\":2502,\"cc\":25,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CAMILO-B_GROWTH\"},{\"cod\":2503,\"cc\":25,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"CAMILO-C_GROWTH\"},{\"cod\":2504,\"cc\":25,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"CAMILO-D_GROWTH\"},{\"cod\":2601,\"cc\":26,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"BERNICE-A_GROWTH\"},{\"cod\":2602,\"cc\":26,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"BERNICE-B_GROWTH\"},{\"cod\":2603,\"cc\":26,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"BERNICE-C_GROWTH\"},{\"cod\":2604,\"cc\":26,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"BERNICE-D_GROWTH\"},{\"cod\":2701,\"cc\":27,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"SISSELA-A_GROWTH\"},{\"cod\":2702,\"cc\":27,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"SISSELA-B_GROWTH\"},{\"cod\":2703,\"cc\":27,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"SISSELA-C_GROWTH\"},{\"cod\":2704,\"cc\":27,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"SISSELA-D_GROWTH\"},{\"cod\":2801,\"cc\":28,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ADELA-A_GROWTH\"},{\"cod\":2802,\"cc\":28,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ADELA-B_GROWTH\"},{\"cod\":2803,\"cc\":28,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ADELA-C_GROWTH\"},{\"cod\":2804,\"cc\":28,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ADELA-D_GROWTH\"},{\"cod\":2901,\"cc\":29,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ADRIANA-A_GROWTH\"},{\"cod\":2902,\"cc\":29,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ADRIANA-B_GROWTH\"},{\"cod\":2903,\"cc\":29,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ADRIANA-C_GROWTH\"},{\"cod\":2904,\"cc\":29,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ADRIANA-D_GROWTH\"},{\"cod\":3001,\"cc\":30,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"NATHAPON-A_GROWTH\"},{\"cod\":3002,\"cc\":30,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"NATHAPON-B_GROWTH\"},{\"cod\":3003,\"cc\":30,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"NATHAPON-C_GROWTH\"},{\"cod\":3004,\"cc\":30,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"NATHAPON-D_GROWTH\"},{\"cod\":3101,\"cc\":31,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"YUKI-A_GROWTH\"},{\"cod\":3102,\"cc\":31,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"YUKI-B_GROWTH\"},{\"cod\":3103,\"cc\":31,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"YUKI-C_GROWTH\"},{\"cod\":3104,\"cc\":31,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"YUKI-D_GROWTH\"},{\"cod\":3201,\"cc\":32,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"LENOX-A_GROWTH\"},{\"cod\":3202,\"cc\":32,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"LENOX-B_GROWTH\"},{\"cod\":3203,\"cc\":32,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"LENOX-C_GROWTH\"},{\"cod\":3204,\"cc\":32,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"LENOX-D_GROWTH\"},{\"cod\":3301,\"cc\":33,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"SUA-A_GROWTH\"},{\"cod\":3302,\"cc\":33,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"SUA-B_GROWTH\"},{\"cod\":3303,\"cc\":33,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"SUA-C_GROWTH\"},{\"cod\":3304,\"cc\":33,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"SUA-D_GROWTH\"},{\"cod\":3401,\"cc\":34,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"MAI-A_GROWTH\"},{\"cod\":3402,\"cc\":34,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"MAI-B_GROWTH\"},{\"cod\":3403,\"cc\":34,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"MAI-C_GROWTH\"},{\"cod\":3404,\"cc\":34,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"MAI-D_GROWTH\"},{\"cod\":3501,\"cc\":35,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JAN-A_GROWTH\"},{\"cod\":3502,\"cc\":35,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JAN-B_GROWTH\"},{\"cod\":3503,\"cc\":35,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"JAN-C_GROWTH\"},{\"cod\":3504,\"cc\":35,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"JAN-D_GROWTH\"},{\"cod\":3601,\"cc\":36,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"LUKE-A_GROWTH\"},{\"cod\":3602,\"cc\":36,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"LUKE-B_GROWTH\"},{\"cod\":3603,\"cc\":36,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"LUKE-C_GROWTH\"},{\"cod\":3604,\"cc\":36,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"LUKE-D_GROWTH\"},{\"cod\":3701,\"cc\":37,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ROZZI-A_GROWTH\"},{\"cod\":3702,\"cc\":37,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ROZZI-B_GROWTH\"},{\"cod\":3703,\"cc\":37,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ROZZI-C_GROWTH\"},{\"cod\":3704,\"cc\":37,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ROZZI-D_GROWTH\"},{\"cod\":3801,\"cc\":38,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"EMMA-A_GROWTH\"},{\"cod\":3802,\"cc\":38,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"EMMA-B_GROWTH\"},{\"cod\":3803,\"cc\":38,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"EMMA-C_GROWTH\"},{\"cod\":3804,\"cc\":38,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"EMMA-D_GROWTH\"},{\"cod\":3901,\"cc\":39,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ELEVEN-A_GROWTH\"},{\"cod\":3902,\"cc\":39,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ELEVEN-B_GROWTH\"},{\"cod\":3903,\"cc\":39,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ELEVEN-C_GROWTH\"},{\"cod\":3904,\"cc\":39,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ELEVEN-D_GROWTH\"},{\"cod\":4001,\"cc\":40,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"DANIEL-A_GROWTH\"},{\"cod\":4002,\"cc\":40,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"DANIEL-B_GROWTH\"},{\"cod\":4003,\"cc\":40,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"DANIEL-C_GROWTH\"},{\"cod\":4004,\"cc\":40,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"DANIEL-D_GROWTH\"},{\"cod\":4101,\"cc\":41,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"RIO-A_GROWTH\"},{\"cod\":4102,\"cc\":41,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"RIO-B_GROWTH\"},{\"cod\":4103,\"cc\":41,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"RIO-C_GROWTH\"},{\"cod\":4104,\"cc\":41,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"RIO-D_GROWTH\"},{\"cod\":4201,\"cc\":42,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"EVA-A_GROWTH\"},{\"cod\":4202,\"cc\":42,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"EVA-B_GROWTH\"},{\"cod\":4203,\"cc\":42,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"EVA-C_GROWTH\"},{\"cod\":4204,\"cc\":42,\"ats\":1,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"EVA-D_GROWTH\"},{\"cod\":4301,\"cc\":43,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"NICKY-A_GROWTH\"},{\"cod\":4302,\"cc\":43,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"NICKY-B_GROWTH\"},{\"cod\":4303,\"cc\":43,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"NICKY-C_GROWTH\"},{\"cod\":4304,\"cc\":43,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"NICKY-D_GROWTH\"},{\"cod\":4401,\"cc\":44,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ECHION-A_GROWTH\"},{\"cod\":4402,\"cc\":44,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ECHION-B_GROWTH\"},{\"cod\":4403,\"cc\":44,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ECHION-C_GROWTH\"},{\"cod\":4404,\"cc\":44,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ECHION-D_GROWTH\"},{\"cod\":4501,\"cc\":45,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"BIANCA-A_GROWTH\"},{\"cod\":4502,\"cc\":45,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"BIANCA-B_GROWTH\"},{\"cod\":4503,\"cc\":45,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"BIANCA-C_GROWTH\"},{\"cod\":4504,\"cc\":45,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"BIANCA-D_GROWTH\"},{\"cod\":4601,\"cc\":46,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CHLOE-A_GROWTH\"},{\"cod\":4602,\"cc\":46,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CHLOE-B_GROWTH\"},{\"cod\":4603,\"cc\":46,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"CHLOE-C_GROWTH\"},{\"cod\":4604,\"cc\":46,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"CHLOE-D_GROWTH\"},{\"cod\":4701,\"cc\":47,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JOHANN-A_GROWTH\"},{\"cod\":4702,\"cc\":47,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"JOHANN-B_GROWTH\"},{\"cod\":4703,\"cc\":47,\"ats\":0,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"JOHANN-C_GROWTH\"},{\"cod\":4704,\"cc\":47,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"JOHANN-D_GROWTH\"},{\"cod\":4801,\"cc\":48,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CELINE-A_GROWTH\"},{\"cod\":4802,\"cc\":48,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"CELINE-B_GROWTH\"},{\"cod\":4803,\"cc\":48,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"CELINE-C_GROWTH\"},{\"cod\":4804,\"cc\":48,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"CELINE-D_GROWTH\"},{\"cod\":4901,\"cc\":49,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"LAURA-A_GROWTH\"},{\"cod\":4902,\"cc\":49,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"LAURA-B_GROWTH\"},{\"cod\":4903,\"cc\":49,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"LAURA-C_GROWTH\"},{\"cod\":4904,\"cc\":49,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"LAURA-D_GROWTH\"},{\"cod\":5001,\"cc\":50,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"AIDEN-A_GROWTH\"},{\"cod\":5002,\"cc\":50,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"AIDEN-B_GROWTH\"},{\"cod\":5003,\"cc\":50,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"AIDEN-C_GROWTH\"},{\"cod\":5004,\"cc\":50,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"AIDEN-D_GROWTH\"},{\"cod\":5101,\"cc\":51,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"TIA-A_GROWTH\"},{\"cod\":5102,\"cc\":51,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"TIA-B_GROWTH\"},{\"cod\":5103,\"cc\":51,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"TIA-C_GROWTH\"},{\"cod\":5104,\"cc\":51,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"TIA-D_GROWTH\"},{\"cod\":5201,\"cc\":52,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ELENA-A_GROWTH\"},{\"cod\":5202,\"cc\":52,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"ELENA-B_GROWTH\"},{\"cod\":5203,\"cc\":52,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"ELENA-C_GROWTH\"},{\"cod\":5204,\"cc\":52,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"ELENA-D_GROWTH\"},{\"cod\":5301,\"cc\":53,\"ats\":1,\"att\":101,\"atol\":[{\"caot\":3001,\"val\":10.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"FELIX-A_GROWTH\"},{\"cod\":5302,\"cc\":53,\"ats\":1,\"att\":201,\"atol\":[{\"caot\":3011,\"val\":1.0}],\"rst\":[],\"ml\":5.0,\"gs\":\"FELIX-B_GROWTH\"},{\"cod\":5303,\"cc\":53,\"ats\":1,\"att\":301,\"atol\":[],\"rst\":[\"SIGNATURE_VOICE\"],\"ml\":4.0,\"gs\":\"FELIX-C_GROWTH\"},{\"cod\":5304,\"cc\":53,\"ats\":0,\"att\":401,\"atol\":[],\"rst\":[\"SIGNATURE_NOVEL\"],\"ml\":4.0,\"gs\":\"FELIX-D_GROWTH\"}],\"signatureOptionTableList\":[{\"cod\":0,\"stt\":0,\"lv\":0,\"sv\":0.0,\"ev\":0.0,\"hn\":false},{\"cod\":1000,\"stt\":101,\"lv\":0,\"sv\":0.0,\"ev\":10.0,\"hn\":true},{\"cod\":1001,\"stt\":101,\"lv\":1,\"sv\":10.0,\"ev\":30.0,\"hn\":true},{\"cod\":1002,\"stt\":101,\"lv\":2,\"sv\":30.0,\"ev\":80.0,\"hn\":true},{\"cod\":1003,\"stt\":101,\"lv\":3,\"sv\":80.0,\"ev\":180.0,\"hn\":true},{\"cod\":1004,\"stt\":101,\"lv\":4,\"sv\":180.0,\"ev\":380.0,\"hn\":true},{\"cod\":1005,\"stt\":101,\"lv\":5,\"sv\":380.0,\"ev\":9999.0,\"hn\":false},{\"cod\":2000,\"stt\":201,\"lv\":0,\"sv\":0.0,\"ev\":10.0,\"hn\":true},{\"cod\":2001,\"stt\":201,\"lv\":1,\"sv\":10.0,\"ev\":30.0,\"hn\":true},{\"cod\":2002,\"stt\":201,\"lv\":2,\"sv\":30.0,\"ev\":80.0,\"hn\":true},{\"cod\":2003,\"stt\":201,\"lv\":3,\"sv\":80.0,\"ev\":180.0,\"hn\":true},{\"cod\":2004,\"stt\":201,\"lv\":4,\"sv\":180.0,\"ev\":380.0,\"hn\":true},{\"cod\":2005,\"stt\":201,\"lv\":5,\"sv\":380.0,\"ev\":9999.0,\"hn\":false},{\"cod\":3000,\"stt\":301,\"lv\":0,\"sv\":0.0,\"ev\":10.0,\"hn\":true},{\"cod\":3001,\"stt\":301,\"lv\":1,\"sv\":10.0,\"ev\":30.0,\"hn\":true},{\"cod\":3002,\"stt\":301,\"lv\":2,\"sv\":30.0,\"ev\":80.0,\"hn\":true},{\"cod\":3003,\"stt\":301,\"lv\":3,\"sv\":80.0,\"ev\":180.0,\"hn\":true},{\"cod\":3004,\"stt\":301,\"lv\":4,\"sv\":180.0,\"ev\":380.0,\"hn\":true},{\"cod\":3005,\"stt\":301,\"lv\":5,\"sv\":380.0,\"ev\":9999.0,\"hn\":false},{\"cod\":4000,\"stt\":401,\"lv\":0,\"sv\":0.0,\"ev\":10.0,\"hn\":true},{\"cod\":4001,\"stt\":401,\"lv\":1,\"sv\":10.0,\"ev\":30.0,\"hn\":true},{\"cod\":4002,\"stt\":401,\"lv\":2,\"sv\":30.0,\"ev\":80.0,\"hn\":true},{\"cod\":4003,\"stt\":401,\"lv\":3,\"sv\":80.0,\"ev\":180.0,\"hn\":true},{\"cod\":4004,\"stt\":401,\"lv\":4,\"sv\":180.0,\"ev\":380.0,\"hn\":true},{\"cod\":4005,\"stt\":401,\"lv\":5,\"sv\":380.0,\"ev\":9999.0,\"hn\":false}]},\"eac\":0}";
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.ContentLength64 = resp.Length;
            //Log.Debug(Helpers.format_json(resp));
            await context.Response.SendResponseAsync(resp);
        }

    }
}
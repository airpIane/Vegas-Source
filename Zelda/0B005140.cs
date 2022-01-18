using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x0200003D RID: 61
public class 0B005140
{
	// Token: 0x06000100 RID: 256 RVA: 0x000C2E90 File Offset: 0x000C2E90
	public 0B005140()
	{
		for (;;)
		{
			IL_00:
			this.0313506C = new Dictionary<uint, 0B005140.38CC03B8>();
			uint num = 749416514U;
			for (;;)
			{
				IL_11:
				num = 384987777U * num;
				this.42D33E78 = typeof(0B005140).Module;
				for (;;)
				{
					IL_2E:
					Stack<0B005140.375D71A4> stack = new Stack<0B005140.375D71A4>();
					num = 85868476U - num;
					this.09B46D51 = stack;
					if (1409161881U > num)
					{
						goto IL_00;
					}
					for (;;)
					{
						IL_4C:
						num = 1399218847U >> (int)num;
						List<0B005140.124B6895> list = new List<0B005140.124B6895>();
						num >>= 3;
						this.578B1C04 = list;
						num = 857111912U - num;
						if ((1815166953U & num) == 0U)
						{
							goto IL_00;
						}
						for (;;)
						{
							IL_81:
							num |= 110326097U;
							this.4E1277A9 = new List<0B005140.11482F88>();
							num &= 475090366U;
							for (;;)
							{
								IL_9C:
								Stack<0B005140.11482F88> stack2 = new Stack<0B005140.11482F88>();
								num >>= 1;
								this.410C421C = stack2;
								num = (1138842221U & num);
								for (;;)
								{
									num = 1364221272U >> (int)num;
									Stack<int> stack3 = new Stack<int>();
									num = 1887902192U % num;
									this.5836773B = stack3;
									num /= 1269192788U;
									for (;;)
									{
										num = (993027451U ^ num);
										this.2FA72A62 = new List<IntPtr>();
										base..ctor();
										num *= 1138300369U;
										IntPtr hinstance = Marshal.GetHINSTANCE(this.42D33E78);
										num &= 1475498910U;
										IntPtr intPtr = hinstance;
										num = 377830660U % num;
										long num2 = intPtr.ToInt64();
										num = 2112253356U * num;
										this.6C727377 = num2;
										do
										{
											num = 1563245112U % num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary = this.0313506C;
											uint key = num + 4221417616U;
											num &= 2074705036U;
											IntPtr 03FF71C = ldftn(7D8B090C);
											num = (1439577175U ^ num);
											0B005140.38CC03B8 value = new 0B005140.38CC03B8(this, 03FF71C);
											num *= 1309366230U;
											dictionary[key] = value;
											num = (1617780374U | num);
											Dictionary<uint, 0B005140.38CC03B8> dictionary2 = this.0313506C;
											uint key2 = num ^ 1937604543U;
											IntPtr 03FF71C2 = ldftn(7B7F0C90);
											num <<= 12;
											0B005140.38CC03B8 value2 = new 0B005140.38CC03B8(this, 03FF71C2);
											num ^= 1691099068U;
											dictionary2[key2] = value2;
											Dictionary<uint, 0B005140.38CC03B8> dictionary3 = this.0313506C;
											num = 1803882748U * num;
											uint key3 = num - 1539800334U;
											num += 509809487U;
											dictionary3[key3] = new 0B005140.38CC03B8(this.070C691A);
											num = 193528389U >> (int)num;
											if (658010725 << (int)num == 0)
											{
												goto IL_11;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary4 = this.0313506C;
											num %= 997157871U;
											uint key4 = num - 4294967293U;
											num /= 945438418U;
											IntPtr 03FF71C3 = ldftn(5A914153);
											num = (390287038U ^ num);
											dictionary4[key4] = new 0B005140.38CC03B8(this, 03FF71C3);
											num = (376903323U ^ num);
											Dictionary<uint, 0B005140.38CC03B8> dictionary5 = this.0313506C;
											uint key5 = num ^ 20207649U;
											num <<= 26;
											0B005140.38CC03B8 value3 = new 0B005140.38CC03B8(this.58E41DB7);
											num |= 2081625593U;
											dictionary5[key5] = value3;
											Dictionary<uint, 0B005140.38CC03B8> dictionary6 = this.0313506C;
											uint key6 = num - 4229109236U;
											num %= 2075859856U;
											0B005140.38CC03B8 value4 = new 0B005140.38CC03B8(this.50D41666);
											num /= 393290704U;
											dictionary6[key6] = value4;
											if (num + 1570271795U == 0U)
											{
												goto IL_00;
											}
											num = 1559966525U - num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary7 = this.0313506C;
											uint key7 = num + 2735000777U;
											num = 1684802698U / num;
											IntPtr 03FF71C4 = ldftn(6BCA29D4);
											num = 387257488U << (int)num;
											dictionary7[key7] = new 0B005140.38CC03B8(this, 03FF71C4);
											Dictionary<uint, 0B005140.38CC03B8> dictionary8 = this.0313506C;
											uint key8 = num + 3520452327U;
											num = (1317478304U & num);
											0B005140.38CC03B8 value5 = new 0B005140.38CC03B8(this.0B5D0864);
											num = 384989501U / num;
											dictionary8[key8] = value5;
											num += 328148020U;
											if (num << 20 == 0U)
											{
												goto IL_2E;
											}
											num = 1354398437U * num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary9 = this.0313506C;
											num = (1798074874U & num);
											uint key9 = num + 4294172320U;
											num <<= 3;
											dictionary9[key9] = new 0B005140.38CC03B8(this.73B7760D);
											num -= 1683061295U;
											if (1766812940U == num)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary10 = this.0313506C;
											uint key10 = num ^ 2618265880U;
											num = 1429814279U - num;
											IntPtr 03FF71C5 = ldftn(4BA3699C);
											num = 1402013523U * num;
											dictionary10[key10] = new 0B005140.38CC03B8(this, 03FF71C5);
											num = (1713714318U & num);
											if (num % 1271489739U == 0U)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary11 = this.0313506C;
											num = 2118073216U << (int)num;
											uint key11 = num - 4177325558U;
											num = 1337744502U / num;
											0B005140.38CC03B8 value6 = new 0B005140.38CC03B8(this.31BE63C9);
											num %= 792929896U;
											dictionary11[key11] = value6;
											if (num + 9985970U == 0U)
											{
												goto IL_11;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary12 = this.0313506C;
											num += 1133718799U;
											uint key12 = num ^ 1133718788U;
											num *= 270402005U;
											IntPtr 03FF71C6 = ldftn(5AD53B14);
											num = 1674187489U % num;
											dictionary12[key12] = new 0B005140.38CC03B8(this, 03FF71C6);
											Dictionary<uint, 0B005140.38CC03B8> dictionary13 = this.0313506C;
											num = (2049800037U | num);
											uint key13 = num - 2067625827U;
											num = 1433016362U >> (int)num;
											dictionary13[key13] = new 0B005140.38CC03B8(this.75395636);
											num = 1334341014U << (int)num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary14 = this.0313506C;
											num = 1167543936U * num;
											uint key14 = num + 268435469U;
											num = 1745442431U / num;
											IntPtr 03FF71C7 = ldftn(63B53B22);
											num ^= 1177762691U;
											0B005140.38CC03B8 value7 = new 0B005140.38CC03B8(this, 03FF71C7);
											num = 1789408511U % num;
											dictionary14[key14] = value7;
											num -= 2052931935U;
											Dictionary<uint, 0B005140.38CC03B8> dictionary15 = this.0313506C;
											num |= 1554073334U;
											uint key15 = num - 4273471217U;
											num = 1416582772U / num;
											IntPtr 03FF71C8 = ldftn(62AB7105);
											num >>= 24;
											dictionary15[key15] = new 0B005140.38CC03B8(this, 03FF71C8);
											Dictionary<uint, 0B005140.38CC03B8> dictionary16 = this.0313506C;
											num /= 368591341U;
											uint key16 = num + 15U;
											IntPtr 03FF71C9 = ldftn(721F15E5);
											num &= 1044019549U;
											0B005140.38CC03B8 value8 = new 0B005140.38CC03B8(this, 03FF71C9);
											num = 2098357538U + num;
											dictionary16[key16] = value8;
											num >>= 19;
											if (num == 332275944U)
											{
												goto IL_11;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary17 = this.0313506C;
											num = 2005873170U + num;
											uint key17 = num ^ 2005877156U;
											IntPtr 03FF71C10 = ldftn(430D3460);
											num = (1043604778U & num);
											0B005140.38CC03B8 value9 = new 0B005140.38CC03B8(this, 03FF71C10);
											num = 1170356709U * num;
											dictionary17[key17] = value9;
											num = 1235696860U + num;
											num = (698236258U & num);
											Dictionary<uint, 0B005140.38CC03B8> dictionary18 = this.0313506C;
											num = 1040478430U / num;
											uint key18 = num ^ 16U;
											num = 633692550U >> (int)num;
											0B005140.38CC03B8 value10 = new 0B005140.38CC03B8(this.31665807);
											num <<= 17;
											dictionary18[key18] = value10;
											num *= 580481590U;
											if (576743096U >= num)
											{
												goto IL_00;
											}
											num = 996951678U * num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary19 = this.0313506C;
											num += 287115332U;
											uint key19 = num ^ 1318389846U;
											num &= 1704861852U;
											num &= 162554823U;
											dictionary19[key19] = new 0B005140.38CC03B8(this.12C527F0);
											num = (272251802U & num);
											Dictionary<uint, 0B005140.38CC03B8> dictionary20 = this.0313506C;
											uint key20 = num + 4293918739U;
											IntPtr 03FF71C11 = ldftn(7F7E38F7);
											num /= 159792898U;
											dictionary20[key20] = new 0B005140.38CC03B8(this, 03FF71C11);
											num -= 2016440281U;
											if (num % 1334856247U == 0U)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary21 = this.0313506C;
											uint key21 = num - 2278526995U;
											num /= 427456003U;
											num = (52459268U ^ num);
											dictionary21[key21] = new 0B005140.38CC03B8(this.777A0C42);
											num = (1536499067U | num);
											Dictionary<uint, 0B005140.38CC03B8> dictionary22 = this.0313506C;
											num *= 1878729313U;
											uint key22 = num - 759997318U;
											num |= 400382707U;
											dictionary22[key22] = new 0B005140.38CC03B8(this.505C30CE);
											Dictionary<uint, 0B005140.38CC03B8> dictionary23 = this.0313506C;
											num = 1703504406U + num;
											uint key23 = num ^ 2775016967U;
											num = 1669610837U + num;
											IntPtr 03FF71C12 = ldftn(4FAD3F96);
											num *= 2000425735U;
											dictionary23[key23] = new 0B005140.38CC03B8(this, 03FF71C12);
											num %= 1526530326U;
											this.0313506C[num ^ 377292963U] = new 0B005140.38CC03B8(this.14136211);
											num = (1994462739U | num);
											if (num == 732918248U)
											{
												goto IL_9C;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary24 = this.0313506C;
											uint key24 = num ^ 1996299951U;
											IntPtr 03FF71C13 = ldftn(2A960EA9);
											num = 373948692U << (int)num;
											dictionary24[key24] = new 0B005140.38CC03B8(this, 03FF71C13);
											Dictionary<uint, 0B005140.38CC03B8> dictionary25 = this.0313506C;
											num <<= 25;
											uint key25 = num - 4294967271U;
											num = 1667499456U - num;
											num = 1718901756U - num;
											IntPtr 03FF71C14 = ldftn(752C72A8);
											num >>= 8;
											dictionary25[key25] = new 0B005140.38CC03B8(this, 03FF71C14);
											num = (499123244U | num);
											if (1070030641U + num == 0U)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary26 = this.0313506C;
											num = 1379744784U + num;
											uint key26 = num ^ 1879068820U;
											IntPtr 03FF71C15 = ldftn(17987A23);
											num %= 1298538688U;
											0B005140.38CC03B8 value11 = new 0B005140.38CC03B8(this, 03FF71C15);
											num = 457143036U << (int)num;
											dictionary26[key26] = value11;
											num = 528508054U - num;
											num ^= 93455310U;
											Dictionary<uint, 0B005140.38CC03B8> dictionary27 = this.0313506C;
											num = 1280586890U + num;
											uint key27 = num ^ 2477235193U;
											num -= 1117272789U;
											num <<= 28;
											IntPtr 03FF71C16 = ldftn(63A566F8);
											num = (598960112U & num);
											0B005140.38CC03B8 value12 = new 0B005140.38CC03B8(this, 03FF71C16);
											num %= 2087859719U;
											dictionary27[key27] = value12;
											Dictionary<uint, 0B005140.38CC03B8> dictionary28 = this.0313506C;
											uint key28 = num + 28U;
											num = 1070075317U >> (int)num;
											num &= 1326583850U;
											IntPtr 03FF71C17 = ldftn(512E6F9A);
											num -= 639444127U;
											0B005140.38CC03B8 value13 = new 0B005140.38CC03B8(this, 03FF71C17);
											num <<= 23;
											dictionary28[key28] = value13;
											num = 1708595538U << (int)num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary29 = this.0313506C;
											num = (1783582981U ^ num);
											uint key29 = num - 261638202U;
											0B005140.38CC03B8 value14 = new 0B005140.38CC03B8(this.20D0612C);
											num = 1910056223U % num;
											dictionary29[key29] = value14;
											Dictionary<uint, 0B005140.38CC03B8> dictionary30 = this.0313506C;
											uint key30 = num + 4216378720U;
											num += 1156792273U;
											dictionary30[key30] = new 0B005140.38CC03B8(this.718E0370);
											num = (941646473U & num);
											Dictionary<uint, 0B005140.38CC03B8> dictionary31 = this.0313506C;
											uint key31 = num + 4158627222U;
											num = 699748682U / num;
											IntPtr 03FF71C18 = ldftn(0C911BA6);
											num <<= 7;
											dictionary31[key31] = new 0B005140.38CC03B8(this, 03FF71C18);
											Dictionary<uint, 0B005140.38CC03B8> dictionary32 = this.0313506C;
											num %= 331052922U;
											uint key32 = num ^ 672U;
											num %= 916156592U;
											num = 1042316218U - num;
											IntPtr 03FF71C19 = ldftn(10DD4D96);
											num |= 1985491696U;
											dictionary32[key32] = new 0B005140.38CC03B8(this, 03FF71C19);
											Dictionary<uint, 0B005140.38CC03B8> dictionary33 = this.0313506C;
											num <<= 15;
											uint key33 = num - 1039990751U;
											num = 793455282U << (int)num;
											0B005140.38CC03B8 value15 = new 0B005140.38CC03B8(this.3F133A57);
											num = 1252944799U - num;
											dictionary33[key33] = value15;
											num = 1125153598U % num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary34 = this.0313506C;
											num = 1877032284U / num;
											uint key34 = num + 25U;
											num = 751268764U + num;
											dictionary34[key34] = new 0B005140.38CC03B8(this.177C0751);
											if (num <= 147016966U)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary35 = this.0313506C;
											uint key35 = num + 3543698558U;
											num = 890969175U - num;
											dictionary35[key35] = new 0B005140.38CC03B8(this.70C52FBD);
											num /= 1407781748U;
											Dictionary<uint, 0B005140.38CC03B8> dictionary36 = this.0313506C;
											uint key36 = num ^ 36U;
											num = 974456366U >> (int)num;
											num = 746142426U * num;
											IntPtr 03FF71C20 = ldftn(0CF05115);
											num = (545587395U ^ num);
											dictionary36[key36] = new 0B005140.38CC03B8(this, 03FF71C20);
											num /= 1062157458U;
											if (1240891228U == num)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary37 = this.0313506C;
											num = (1480610669U ^ num);
											uint key37 = num - 1480610632U;
											num /= 1289573297U;
											dictionary37[key37] = new 0B005140.38CC03B8(this.608029DD);
											Dictionary<uint, 0B005140.38CC03B8> dictionary38 = this.0313506C;
											num = 1992305918U + num;
											uint key38 = num + 2302661415U;
											IntPtr 03FF71C21 = ldftn(3C6D67F6);
											num /= 57349372U;
											dictionary38[key38] = new 0B005140.38CC03B8(this, 03FF71C21);
											num = 1790650379U / num;
											if (788158457U == num)
											{
												goto IL_2E;
											}
											num = 559505482U / num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary39 = this.0313506C;
											num = (2090890160U ^ num);
											uint key39 = num + 2204077165U;
											num = 975858866U % num;
											IntPtr 03FF71C22 = ldftn(702F266B);
											num <<= 7;
											dictionary39[key39] = new 0B005140.38CC03B8(this, 03FF71C22);
											num = 739982307U + num;
											num = 44585489U << (int)num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary40 = this.0313506C;
											num %= 732437052U;
											uint key40 = num + 3938283424U;
											num += 308435723U;
											num <<= 11;
											IntPtr 03FF71C23 = ldftn(4CCE0252);
											num = 1470708907U % num;
											0B005140.38CC03B8 value16 = new 0B005140.38CC03B8(this, 03FF71C23);
											num -= 197885375U;
											dictionary40[key40] = value16;
											num += 170018525U;
											Dictionary<uint, 0B005140.38CC03B8> dictionary41 = this.0313506C;
											num -= 355235648U;
											uint key41 = num + 233152928U;
											num = (341250141U & num);
											dictionary41[key41] = new 0B005140.38CC03B8(this.426939D3);
											if (599144534U <= num)
											{
												goto IL_2E;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary42 = this.0313506C;
											num /= 1450080630U;
											uint key42 = num + 42U;
											num %= 531058093U;
											num = 1568348806U >> (int)num;
											IntPtr 03FF71C24 = ldftn(26982A6E);
											num %= 1295516826U;
											dictionary42[key42] = new 0B005140.38CC03B8(this, 03FF71C24);
											if (1573019756U == num)
											{
												goto IL_2E;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary43 = this.0313506C;
											uint key43 = num + 4022135359U;
											num = 2145791149U * num;
											num = 1836677176U % num;
											dictionary43[key43] = new 0B005140.38CC03B8(this.37CC26B6);
											num *= 934178669U;
											if (1294534564U - num == 0U)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary44 = this.0313506C;
											uint key44 = num ^ 3894910752U;
											num *= 1750497652U;
											dictionary44[key44] = new 0B005140.38CC03B8(this.5023492D);
											if (num / 808929246U == 0U)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary45 = this.0313506C;
											num ^= 1182401202U;
											uint key45 = num - 2085797781U;
											num = 1548896757U - num;
											IntPtr 03FF71C25 = ldftn(2FF10145);
											num = (2063733011U | num);
											0B005140.38CC03B8 value17 = new 0B005140.38CC03B8(this, 03FF71C25);
											num /= 1223910079U;
											dictionary45[key45] = value17;
											if (num == 1591807310U)
											{
												goto IL_11;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary46 = this.0313506C;
											num -= 680077648U;
											uint key46 = num ^ 3614889629U;
											num = (2075073180U ^ num);
											num >>= 3;
											IntPtr 03FF71C26 = ldftn(6C310717);
											num = 798103987U << (int)num;
											dictionary46[key46] = new 0B005140.38CC03B8(this, 03FF71C26);
											if (num == 118044437U)
											{
												goto IL_11;
											}
											num = (1574910856U & num);
											Dictionary<uint, 0B005140.38CC03B8> dictionary47 = this.0313506C;
											num = 1928670691U % num;
											uint key47 = num ^ 582089676U;
											IntPtr 03FF71C27 = ldftn(69C70694);
											num *= 1903914077U;
											0B005140.38CC03B8 value18 = new 0B005140.38CC03B8(this, 03FF71C27);
											num = 73812491U - num;
											dictionary47[key47] = value18;
											num *= 1489906202U;
											if (num == 1048453430U)
											{
												goto IL_11;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary48 = this.0313506C;
											uint key48 = num ^ 2021834552U;
											num = (1919298284U ^ num);
											num /= 374825544U;
											dictionary48[key48] = new 0B005140.38CC03B8(this.4F776CFF);
											num = (251683601U ^ num);
											Dictionary<uint, 0B005140.38CC03B8> dictionary49 = this.0313506C;
											num = (2064515191U & num);
											uint key49 = num ^ 184549408U;
											num = 925585126U << (int)num;
											0B005140.38CC03B8 value19 = new 0B005140.38CC03B8(this.3E50525D);
											num <<= 3;
											dictionary49[key49] = value19;
											num = (2045052406U | num);
											Dictionary<uint, 0B005140.38CC03B8> dictionary50 = this.0313506C;
											num = 1473070851U % num;
											uint key50 = num + 2821896495U;
											num = (1627201305U | num);
											num = 1667856097U % num;
											IntPtr 03FF71C28 = ldftn(4E483802);
											num = 977805110U % num;
											dictionary50[key50] = new 0B005140.38CC03B8(this, 03FF71C28);
											num /= 900730164U;
											if (num == 219218100U)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary51 = this.0313506C;
											num -= 991259376U;
											uint key51 = num ^ 3303707938U;
											num ^= 363811459U;
											0B005140.38CC03B8 value20 = new 0B005140.38CC03B8(this.45935BA6);
											num = 877664038U % num;
											dictionary51[key51] = value20;
											if (1945335637 << (int)num == 0)
											{
												goto IL_00;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary52 = this.0313506C;
											uint key52 = num + 3417303310U;
											num = 877035075U / num;
											IntPtr 03FF71C29 = ldftn(75390910);
											num = (341716148U & num);
											dictionary52[key52] = new 0B005140.38CC03B8(this, 03FF71C29);
											num >>= 0;
											Dictionary<uint, 0B005140.38CC03B8> dictionary53 = this.0313506C;
											uint key53 = num ^ 53U;
											num &= 82861789U;
											IntPtr 03FF71C30 = ldftn(2F517C82);
											num ^= 515472076U;
											0B005140.38CC03B8 value21 = new 0B005140.38CC03B8(this, 03FF71C30);
											num |= 1149200554U;
											dictionary53[key53] = value21;
											num >>= 8;
											num = 858592938U + num;
											Dictionary<uint, 0B005140.38CC03B8> dictionary54 = this.0313506C;
											uint key54 = num ^ 864818706U;
											num = 1355678026U / num;
											dictionary54[key54] = new 0B005140.38CC03B8(this.253C6BB5);
											if (num >= 37487173U)
											{
												goto IL_11;
											}
											Dictionary<uint, 0B005140.38CC03B8> dictionary55 = this.0313506C;
											uint key55 = num - 4294967242U;
											num /= 1428883302U;
											IntPtr 03FF71C31 = ldftn(5DA526D1);
											num ^= 206656311U;
											0B005140.38CC03B8 value22 = new 0B005140.38CC03B8(this, 03FF71C31);
											num *= 1844782403U;
											dictionary55[key55] = value22;
											num = 1299589100U / num;
										}
										while ((247795182U & num) == 0U);
										num /= 1401623403U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary56 = this.0313506C;
										uint key56 = num ^ 56U;
										0B005140.38CC03B8 value23 = new 0B005140.38CC03B8(this.25BB5201);
										num %= 300486495U;
										dictionary56[key56] = value23;
										Dictionary<uint, 0B005140.38CC03B8> dictionary57 = this.0313506C;
										num = 1094474752U >> (int)num;
										uint key57 = num ^ 1094474809U;
										IntPtr 03FF71C32 = ldftn(51C6440E);
										num = 106187139U % num;
										0B005140.38CC03B8 value24 = new 0B005140.38CC03B8(this, 03FF71C32);
										num = 1016530286U / num;
										dictionary57[key57] = value24;
										Dictionary<uint, 0B005140.38CC03B8> dictionary58 = this.0313506C;
										uint key58 = num - 4294967247U;
										0B005140.38CC03B8 value25 = new 0B005140.38CC03B8(this.7A4223E5);
										num = 2024689060U - num;
										dictionary58[key58] = value25;
										if (211515961U > num)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary59 = this.0313506C;
										uint key59 = num + 2270278304U;
										num <<= 27;
										num = 138359863U % num;
										0B005140.38CC03B8 value26 = new 0B005140.38CC03B8(this.6D3963E2);
										num = (1944256801U ^ num);
										dictionary59[key59] = value26;
										num %= 1466064182U;
										if (495021488U + num == 0U)
										{
											goto IL_4C;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary60 = this.0313506C;
										num = (1582446728U | num);
										uint key60 = num + 2172911700U;
										num |= 1911292817U;
										num <<= 6;
										IntPtr 03FF71C33 = ldftn(5C0664E0);
										num ^= 882654798U;
										dictionary60[key60] = new 0B005140.38CC03B8(this, 03FF71C33);
										num = 1478907419U + num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary61 = this.0313506C;
										uint key61 = num + 3698715156U;
										num = 701846884U % num;
										dictionary61[key61] = new 0B005140.38CC03B8(this.40090BB7);
										num ^= 1234511750U;
										if (634782476U > num)
										{
											goto IL_2E;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary62 = this.0313506C;
										uint key62 = num + 2955011969U;
										num ^= 2027381999U;
										IntPtr 03FF71C34 = ldftn(25A07462);
										num = (122757423U ^ num);
										dictionary62[key62] = new 0B005140.38CC03B8(this, 03FF71C34);
										num += 2141082027U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary63 = this.0313506C;
										uint key63 = num - 2952179433U;
										num = (1611353660U | num);
										IntPtr 03FF71C35 = ldftn(493F68A3);
										num += 1227244045U;
										dictionary63[key63] = new 0B005140.38CC03B8(this, 03FF71C35);
										num = 1731882262U % num;
										num = (720573675U ^ num);
										Dictionary<uint, 0B005140.38CC03B8> dictionary64 = this.0313506C;
										num &= 983239113U;
										uint key64 = num - 8587456U;
										num = 1289581073U % num;
										IntPtr 03FF71C36 = ldftn(5D146CD8);
										num = (441067161U ^ num);
										0B005140.38CC03B8 value27 = new 0B005140.38CC03B8(this, 03FF71C36);
										num %= 1193432577U;
										dictionary64[key64] = value27;
										if ((num ^ 145501262U) == 0U)
										{
											goto IL_81;
										}
										num /= 582051305U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary65 = this.0313506C;
										uint key65 = num ^ 65U;
										num += 284511672U;
										IntPtr 03FF71C37 = ldftn(2C947ABF);
										num -= 874521106U;
										0B005140.38CC03B8 value28 = new 0B005140.38CC03B8(this, 03FF71C37);
										num = 266238866U * num;
										dictionary65[key65] = value28;
										num |= 1319309021U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary66 = this.0313506C;
										uint key66 = num ^ 4294946495U;
										num = (1829381002U ^ num);
										IntPtr 03FF71C38 = ldftn(5FE76993);
										num -= 52001322U;
										dictionary66[key66] = new 0B005140.38CC03B8(this, 03FF71C38);
										Dictionary<uint, 0B005140.38CC03B8> dictionary67 = this.0313506C;
										uint key67 = num + 1881402614U;
										num >>= 2;
										0B005140.38CC03B8 value29 = new 0B005140.38CC03B8(this.54B95DF1);
										num = (1157762283U & num);
										dictionary67[key67] = value29;
										num = 1016478458U - num;
										if (num <= 770598597U)
										{
											goto IL_11;
										}
										num /= 648434417U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary68 = this.0313506C;
										uint key68 = num ^ 69U;
										num = 718937642U << (int)num;
										dictionary68[key68] = new 0B005140.38CC03B8(this.5DB25352);
										num = 146951922U >> (int)num;
										if (num == 416902799U)
										{
											goto IL_00;
										}
										num = 1050423445U << (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary69 = this.0313506C;
										uint key69 = num + 1022799941U;
										num = 686693287U - num;
										num = 1928293702U - num;
										IntPtr 03FF71C39 = ldftn(08C843B8);
										num = 560159955U >> (int)num;
										0B005140.38CC03B8 value30 = new 0B005140.38CC03B8(this, 03FF71C39);
										num = (1849846496U ^ num);
										dictionary69[key69] = value30;
										if (num <= 539630100U)
										{
											goto IL_2E;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary70 = this.0313506C;
										uint key70 = num - 1849846426U;
										num /= 2128636409U;
										IntPtr 03FF71C40 = ldftn(555A0DB3);
										num &= 1829320843U;
										0B005140.38CC03B8 value31 = new 0B005140.38CC03B8(this, 03FF71C40);
										num = 718692278U >> (int)num;
										dictionary70[key70] = value31;
										num = 1779965584U / num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary71 = this.0313506C;
										num = (117338055U ^ num);
										uint key71 = num + 4177629314U;
										num ^= 1349005827U;
										0B005140.38CC03B8 value32 = new 0B005140.38CC03B8(this.5B98082D);
										num *= 773880838U;
										dictionary71[key71] = value32;
										if (num >= 1650658867U)
										{
											goto IL_00;
										}
										num %= 1675718869U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary72 = this.0313506C;
										num -= 1488654205U;
										uint key72 = num - 3505851103U;
										IntPtr 03FF71C41 = ldftn(5F8E3204);
										num = 1909355473U * num;
										0B005140.38CC03B8 value33 = new 0B005140.38CC03B8(this, 03FF71C41);
										num = (530999939U ^ num);
										dictionary72[key72] = value33;
										num %= 1674974131U;
										if (216160854U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary73 = this.0313506C;
										uint key73 = num - 335990181U;
										num &= 1624784184U;
										0B005140.38CC03B8 value34 = new 0B005140.38CC03B8(this.0BB14632);
										num %= 458494063U;
										dictionary73[key73] = value34;
										if (542648650U % num == 0U)
										{
											goto IL_2E;
										}
										num /= 2110866569U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary74 = this.0313506C;
										num <<= 29;
										uint key74 = num + 74U;
										num = (2031769482U ^ num);
										dictionary74[key74] = new 0B005140.38CC03B8(this.68151E18);
										num = (1174285540U ^ num);
										if (942739571U == num)
										{
											goto IL_11;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary75 = this.0313506C;
										uint key75 = num - 1021606691U;
										num = 1937976202U - num;
										num = 1608611383U >> (int)num;
										IntPtr 03FF71C42 = ldftn(617B47EC);
										num /= 851922913U;
										dictionary75[key75] = new 0B005140.38CC03B8(this, 03FF71C42);
										num |= 1962289484U;
										num += 589972701U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary76 = this.0313506C;
										uint key76 = num - 2552262109U;
										num = 2014734469U / num;
										IntPtr 03FF71C43 = ldftn(556B5BE8);
										num -= 300958076U;
										0B005140.38CC03B8 value35 = new 0B005140.38CC03B8(this, 03FF71C43);
										num += 433592651U;
										dictionary76[key76] = value35;
										num %= 1987932328U;
										if (num >> 13 == 0U)
										{
											goto IL_9C;
										}
										num = 590237466U << (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary77 = this.0313506C;
										num = 1423408827U - num;
										uint key77 = num ^ 759856886U;
										num <<= 18;
										dictionary77[key77] = new 0B005140.38CC03B8(this.31665807);
										num = 1581386765U - num;
										if ((num ^ 1470589335U) == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary78 = this.0313506C;
										uint key78 = num + 2628383809U;
										num -= 248869588U;
										IntPtr 03FF71C44 = ldftn(54B95DF1);
										num %= 438983744U;
										dictionary78[key78] = new 0B005140.38CC03B8(this, 03FF71C44);
										num = (1230863680U | num);
										if (num / 1306354932U == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary79 = this.0313506C;
										num %= 487275417U;
										dictionary79[num ^ 357008904U] = new 0B005140.38CC03B8(this.5C0664E0);
										if (num <= 276709181U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary80 = this.0313506C;
										num -= 607875791U;
										uint key79 = num ^ 4044100392U;
										num = 1724608512U - num;
										dictionary80[key79] = new 0B005140.38CC03B8(this.2C947ABF);
										if (num < 626671291U)
										{
											goto IL_11;
										}
										num += 1921668607U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary81 = this.0313506C;
										num &= 948318246U;
										uint key80 = num + 3623866443U;
										num = 1556371278U / num;
										IntPtr 03FF71C45 = ldftn(608029DD);
										num ^= 987641856U;
										0B005140.38CC03B8 value36 = new 0B005140.38CC03B8(this, 03FF71C45);
										num |= 2051045581U;
										dictionary81[key80] = value36;
										num ^= 250808857U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary82 = this.0313506C;
										num = 653749816U % num;
										uint key81 = num - 653749734U;
										num ^= 2135033370U;
										num = 2074366202U << (int)num;
										0B005140.38CC03B8 value37 = new 0B005140.38CC03B8(this.31BE63C9);
										num = 1486032914U - num;
										dictionary82[key81] = value37;
										num /= 172890029U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary83 = this.0313506C;
										num <<= 12;
										uint key82 = num - 40877U;
										num |= 380895922U;
										num &= 1111383717U;
										dictionary83[key82] = new 0B005140.38CC03B8(this.493F68A3);
										Dictionary<uint, 0B005140.38CC03B8> dictionary84 = this.0313506C;
										uint key83 = num + 4258004404U;
										num >>= 29;
										dictionary84[key83] = new 0B005140.38CC03B8(this.493F68A3);
										num <<= 23;
										num <<= 25;
										Dictionary<uint, 0B005140.38CC03B8> dictionary85 = this.0313506C;
										uint key84 = num ^ 85U;
										num = (121991272U ^ num);
										IntPtr 03FF71C46 = ldftn(63A566F8);
										num = 1759005056U << (int)num;
										0B005140.38CC03B8 value38 = new 0B005140.38CC03B8(this, 03FF71C46);
										num |= 749036014U;
										dictionary85[key84] = value38;
										num = 2007200077U * num;
										if (2083395337U > num)
										{
											goto IL_00;
										}
										num = (1749962169U | num);
										Dictionary<uint, 0B005140.38CC03B8> dictionary86 = this.0313506C;
										uint key85 = num ^ 4175384553U;
										num = (225450974U ^ num);
										num /= 278598309U;
										dictionary86[key85] = new 0B005140.38CC03B8(this.3E50525D);
										num *= 1446380396U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary87 = this.0313506C;
										num ^= 1193099090U;
										uint key86 = num - 4058583139U;
										num ^= 534603858U;
										num = (214787040U | num);
										dictionary87[key86] = new 0B005140.38CC03B8(this.777A0C42);
										if (848496831U == num)
										{
											goto IL_11;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary88 = this.0313506C;
										num += 688981673U;
										uint key87 = num ^ 403604169U;
										num = (1348215244U ^ num);
										IntPtr 03FF71C47 = ldftn(5D146CD8);
										num %= 1756632364U;
										0B005140.38CC03B8 value39 = new 0B005140.38CC03B8(this, 03FF71C47);
										num = 1528064676U >> (int)num;
										dictionary88[key87] = value39;
										num >>= 25;
										Dictionary<uint, 0B005140.38CC03B8> dictionary89 = this.0313506C;
										num = (1108501504U ^ num);
										uint key88 = num - 1108501415U;
										num = 1221414000U % num;
										0B005140.38CC03B8 value40 = new 0B005140.38CC03B8(this.4FAD3F96);
										num %= 1487208707U;
										dictionary89[key88] = value40;
										num = (1746496660U | num);
										Dictionary<uint, 0B005140.38CC03B8> dictionary90 = this.0313506C;
										num ^= 1089274872U;
										uint key89 = num - 777449138U;
										0B005140.38CC03B8 value41 = new 0B005140.38CC03B8(this.14136211);
										num -= 1202867157U;
										dictionary90[key89] = value41;
										if (num == 2052398341U)
										{
											goto IL_81;
										}
										num %= 1646398170U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary91 = this.0313506C;
										num ^= 1127511510U;
										uint key90 = num ^ 1632958478U;
										num += 368069355U;
										dictionary91[key90] = new 0B005140.38CC03B8(this.20D0612C);
										num /= 1761764662U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary92 = this.0313506C;
										uint key91 = num ^ 93U;
										num >>= 11;
										dictionary92[key91] = new 0B005140.38CC03B8(this.4FAD3F96);
										num = 678648676U + num;
										if (1882088354U <= num)
										{
											goto IL_11;
										}
										num <<= 10;
										Dictionary<uint, 0B005140.38CC03B8> dictionary93 = this.0313506C;
										uint key92 = num ^ 3446509661U;
										0B005140.38CC03B8 value42 = new 0B005140.38CC03B8(this.31BE63C9);
										num <<= 31;
										dictionary93[key92] = value42;
										if (1818382717U < num)
										{
											goto IL_11;
										}
										num <<= 21;
										Dictionary<uint, 0B005140.38CC03B8> dictionary94 = this.0313506C;
										uint key93 = num - 4294967202U;
										num >>= 20;
										num <<= 19;
										0B005140.38CC03B8 value43 = new 0B005140.38CC03B8(this.493F68A3);
										num = 2133921353U * num;
										dictionary94[key93] = value43;
										num = 364202538U >> (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary95 = this.0313506C;
										num = 1105734041U % num;
										uint key94 = num + 4281840964U;
										num += 2065850253U;
										num = (383321610U ^ num);
										0B005140.38CC03B8 value44 = new 0B005140.38CC03B8(this.69C70694);
										num = 868892758U % num;
										dictionary95[key94] = value44;
										num %= 1338381357U;
										if ((num ^ 1989243050U) == 0U)
										{
											goto IL_00;
										}
										num = 1962892618U - num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary96 = this.0313506C;
										num = 1730369457U / num;
										uint key95 = num ^ 97U;
										0B005140.38CC03B8 value45 = new 0B005140.38CC03B8(this.608029DD);
										num += 170551870U;
										dictionary96[key95] = value45;
										if (224878076U < num)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary97 = this.0313506C;
										uint key96 = num ^ 170551902U;
										IntPtr 03FF71C48 = ldftn(08C843B8);
										num = (120351258U ^ num);
										dictionary97[key96] = new 0B005140.38CC03B8(this, 03FF71C48);
										if (1257399565U * num == 0U)
										{
											goto IL_2E;
										}
										num %= 1396007277U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary98 = this.0313506C;
										num %= 1569729262U;
										uint key97 = num ^ 218497095U;
										num += 198930519U;
										num = 1682047900U % num;
										IntPtr 03FF71C49 = ldftn(5D146CD8);
										num *= 1485521908U;
										0B005140.38CC03B8 value46 = new 0B005140.38CC03B8(this, 03FF71C49);
										num = 1988824152U / num;
										dictionary98[key97] = value46;
										num /= 1756246535U;
										if (1181881092U == num)
										{
											goto IL_00;
										}
										this.0313506C[num + 99U] = new 0B005140.38CC03B8(this.6C310717);
										num = 254818791U >> (int)num;
										num ^= 226778887U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary99 = this.0313506C;
										num = 849507454U + num;
										uint key98 = num - 894884602U;
										num += 1057045863U;
										num = 1403726624U + num;
										IntPtr 03FF71C50 = ldftn(718E0370);
										num >>= 12;
										dictionary99[key98] = new 0B005140.38CC03B8(this, 03FF71C50);
										if ((1279472037U ^ num) == 0U)
										{
											goto IL_00;
										}
										num = 1623867273U - num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary100 = this.0313506C;
										num = 1736843110U / num;
										uint key99 = num ^ 100U;
										num >>= 9;
										dictionary100[key99] = new 0B005140.38CC03B8(this.253C6BB5);
										num = 1806117435U >> (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary101 = this.0313506C;
										uint key100 = num ^ 1806117469U;
										num = 1958105018U * num;
										num = 1223179747U >> (int)num;
										dictionary101[key100] = new 0B005140.38CC03B8(this.54B95DF1);
										num %= 1382943567U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary102 = this.0313506C;
										num &= 204352119U;
										uint key101 = num ^ 102U;
										num = 715797019U * num;
										IntPtr 03FF71C51 = ldftn(54B95DF1);
										num ^= 956392163U;
										dictionary102[key101] = new 0B005140.38CC03B8(this, 03FF71C51);
										num ^= 701202279U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary103 = this.0313506C;
										num = 2121162556U + num;
										uint key102 = num ^ 3100544691U;
										num = (1768780773U | num);
										IntPtr 03FF71C52 = ldftn(14136211);
										num = 2117476485U % num;
										dictionary103[key102] = new 0B005140.38CC03B8(this, 03FF71C52);
										Dictionary<uint, 0B005140.38CC03B8> dictionary104 = this.0313506C;
										uint key103 = num ^ 2117476588U;
										num %= 1241131934U;
										IntPtr 03FF71C53 = ldftn(5DB25352);
										num %= 1409968981U;
										dictionary104[key103] = new 0B005140.38CC03B8(this, 03FF71C53);
										num = (758139890U ^ num);
										num = 470160581U << (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary105 = this.0313506C;
										uint key104 = num - 2560622486U;
										num *= 932544408U;
										IntPtr 03FF71C54 = ldftn(5DB25352);
										num = 1775848479U * num;
										0B005140.38CC03B8 value47 = new 0B005140.38CC03B8(this, 03FF71C54);
										num = 1803625387U - num;
										dictionary105[key104] = value47;
										num /= 2014914587U;
										num &= 205522962U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary106 = this.0313506C;
										num += 103357815U;
										uint key105 = num ^ 103357724U;
										num = (614497211U & num);
										dictionary106[key105] = new 0B005140.38CC03B8(this.5AD53B14);
										Dictionary<uint, 0B005140.38CC03B8> dictionary107 = this.0313506C;
										num %= 1500018332U;
										uint key106 = num - 69212359U;
										num = 1008929931U + num;
										num = 1751923346U % num;
										IntPtr 03FF71C55 = ldftn(0BB14632);
										num |= 1264146418U;
										0B005140.38CC03B8 value48 = new 0B005140.38CC03B8(this, 03FF71C55);
										num = (539255164U | num);
										dictionary107[key106] = value48;
										if (num == 424088923U)
										{
											goto IL_11;
										}
										num = 1544967562U * num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary108 = this.0313506C;
										num = 857679708U % num;
										uint key107 = num ^ 13705757U;
										num = 1394358323U * num;
										IntPtr 03FF71C56 = ldftn(08C843B8);
										num = (169412960U ^ num);
										dictionary108[key107] = new 0B005140.38CC03B8(this, 03FF71C56);
										if (817328518U >= num)
										{
											goto IL_00;
										}
										num /= 597630647U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary109 = this.0313506C;
										uint key108 = num ^ 104U;
										num /= 1831303102U;
										IntPtr 03FF71C57 = ldftn(31BE63C9);
										num = 1655128226U >> (int)num;
										0B005140.38CC03B8 value49 = new 0B005140.38CC03B8(this, 03FF71C57);
										num = 1090539279U << (int)num;
										dictionary109[key108] = value49;
										if (816910422U <= num)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary110 = this.0313506C;
										num -= 74804697U;
										uint key109 = num ^ 4287352332U;
										IntPtr 03FF71C58 = ldftn(2C947ABF);
										num *= 248528243U;
										dictionary110[key109] = new 0B005140.38CC03B8(this, 03FF71C58);
										if (num - 737084592U == 0U)
										{
											goto IL_00;
										}
										num *= 2087525847U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary111 = this.0313506C;
										uint key110 = num - 1953088815U;
										num = 1638619139U / num;
										0B005140.38CC03B8 value50 = new 0B005140.38CC03B8(this.253C6BB5);
										num /= 1470698915U;
										dictionary111[key110] = value50;
										Dictionary<uint, 0B005140.38CC03B8> dictionary112 = this.0313506C;
										num -= 1283408819U;
										uint key111 = num + 1283408932U;
										num = 1114071170U / num;
										dictionary112[key111] = new 0B005140.38CC03B8(this.08C843B8);
										num = 1964734894U * num;
										if (num >= 1731619045U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary113 = this.0313506C;
										uint key112 = num - 4294967182U;
										IntPtr 03FF71C59 = ldftn(75390910);
										num = 1171391059U * num;
										dictionary113[key112] = new 0B005140.38CC03B8(this, 03FF71C59);
										if ((140196019U & num) != 0U)
										{
											goto IL_2E;
										}
										num = 1121716703U + num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary114 = this.0313506C;
										num >>= 9;
										uint key113 = num ^ 2190967U;
										num >>= 28;
										0B005140.38CC03B8 value51 = new 0B005140.38CC03B8(this.777A0C42);
										num >>= 25;
										dictionary114[key113] = value51;
										num = (763702457U ^ num);
										if ((num ^ 760682253U) == 0U)
										{
											goto IL_4C;
										}
										num = 191450783U >> (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary115 = this.0313506C;
										uint key114 = num - 4294967185U;
										num |= 2016679276U;
										IntPtr 03FF71C60 = ldftn(5D146CD8);
										num = 1097562380U - num;
										dictionary115[key114] = new 0B005140.38CC03B8(this, 03FF71C60);
										num %= 436018832U;
										if (174532365U * num == 0U)
										{
											goto IL_00;
										}
										num = (1663203547U & num);
										Dictionary<uint, 0B005140.38CC03B8> dictionary116 = this.0313506C;
										uint key115 = num - 50464790U;
										num &= 39653590U;
										dictionary116[key115] = new 0B005140.38CC03B8(this.3C6D67F6);
										num = (1142899797U ^ num);
										if ((799150265U ^ num) == 0U)
										{
											goto IL_00;
										}
										num ^= 729372217U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary117 = this.0313506C;
										num = 1589777091U >> (int)num;
										uint key116 = num ^ 97150U;
										num += 697532125U;
										IntPtr 03FF71C61 = ldftn(2C947ABF);
										num %= 260272336U;
										0B005140.38CC03B8 value52 = new 0B005140.38CC03B8(this, 03FF71C61);
										num = 792867994U * num;
										dictionary117[key116] = value52;
										num = 1374231919U - num;
										if ((1888749585U ^ num) == 0U)
										{
											goto IL_11;
										}
										num = 1676949004U / num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary118 = this.0313506C;
										num = 2103397104U >> (int)num;
										uint key117 = num ^ 525849291U;
										num = 971574922U << (int)num;
										IntPtr 03FF71C62 = ldftn(54B95DF1);
										num += 2034375088U;
										dictionary118[key117] = new 0B005140.38CC03B8(this, 03FF71C62);
										if (num > 920586118U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary119 = this.0313506C;
										uint key118 = num ^ 423762376U;
										num <<= 6;
										IntPtr 03FF71C63 = ldftn(3F133A57);
										num = 331107840U - num;
										0B005140.38CC03B8 value53 = new 0B005140.38CC03B8(this, 03FF71C63);
										num = 162077689U + num;
										dictionary119[key118] = value53;
										if (num < 2032670672U)
										{
											goto IL_11;
										}
										num >>= 1;
										Dictionary<uint, 0B005140.38CC03B8> dictionary120 = this.0313506C;
										num = (838275627U & num);
										uint key119 = num ^ 543625809U;
										num ^= 830100558U;
										IntPtr 03FF71C64 = ldftn(31BE63C9);
										num %= 1672169353U;
										0B005140.38CC03B8 value54 = new 0B005140.38CC03B8(this, 03FF71C64);
										num %= 726417545U;
										dictionary120[key119] = value54;
										num = 1939109780U - num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary121 = this.0313506C;
										uint key120 = num - 1651978420U;
										num = 875185152U - num;
										num ^= 1536831746U;
										IntPtr 03FF71C65 = ldftn(617B47EC);
										num >>= 22;
										dictionary121[key120] = new 0B005140.38CC03B8(this, 03FF71C65);
										num += 980565124U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary122 = this.0313506C;
										num -= 472725697U;
										uint key121 = num ^ 507839888U;
										IntPtr 03FF71C66 = ldftn(4E483802);
										num %= 1073636150U;
										0B005140.38CC03B8 value55 = new 0B005140.38CC03B8(this, 03FF71C66);
										num >>= 4;
										dictionary122[key121] = value55;
										num = (1840383706U ^ num);
										Dictionary<uint, 0B005140.38CC03B8> dictionary123 = this.0313506C;
										num += 1696235491U;
										uint key122 = num ^ 3513832987U;
										num = 600667250U >> (int)num;
										0B005140.38CC03B8 value56 = new 0B005140.38CC03B8(this.3C6D67F6);
										num = 1943674223U + num;
										dictionary123[key122] = value56;
										if (2072062343U - num == 0U)
										{
											goto IL_4C;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary124 = this.0313506C;
										uint key123 = num ^ 1948366890U;
										num = 1588535609U * num;
										dictionary124[key123] = new 0B005140.38CC03B8(this.3F133A57);
										if (2147434962U < num)
										{
											goto IL_81;
										}
										num ^= 1125076190U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary125 = this.0313506C;
										num = 563365098U % num;
										uint key124 = num - 563364972U;
										num = 711792911U + num;
										dictionary125[key124] = new 0B005140.38CC03B8(this.6BCA29D4);
										if (num <= 475924161U)
										{
											goto IL_81;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary126 = this.0313506C;
										num = 917118010U * num;
										uint key125 = num ^ 1274054165U;
										IntPtr 03FF71C67 = ldftn(752C72A8);
										num += 1643665326U;
										dictionary126[key125] = new 0B005140.38CC03B8(this, 03FF71C67);
										num = 1975539508U % num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary127 = this.0313506C;
										num *= 1835237114U;
										uint key126 = num ^ 2245836872U;
										num = 1578114014U % num;
										dictionary127[key126] = new 0B005140.38CC03B8(this.3F133A57);
										num = 161885929U * num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary128 = this.0313506C;
										num = 673149798U * num;
										uint key127 = num ^ 2153723157U;
										num >>= 12;
										0B005140.38CC03B8 value57 = new 0B005140.38CC03B8(this.10DD4D96);
										num = 55730437U + num;
										dictionary128[key127] = value57;
										num = 140585030U << (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary129 = this.0313506C;
										uint key128 = num - 1174404990U;
										num = 387468263U - num;
										IntPtr 03FF71C68 = ldftn(5DB25352);
										num |= 693725795U;
										dictionary129[key128] = new 0B005140.38CC03B8(this, 03FF71C68);
										num |= 59911056U;
										num = (594754827U ^ num);
										Dictionary<uint, 0B005140.38CC03B8> dictionary130 = this.0313506C;
										num ^= 851250865U;
										uint key129 = num ^ 3927267534U;
										num = 1063139639U - num;
										num += 2114482436U;
										0B005140.38CC03B8 value58 = new 0B005140.38CC03B8(this.493F68A3);
										num = (1058233171U ^ num);
										dictionary130[key129] = value58;
										num -= 136330693U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary131 = this.0313506C;
										uint key130 = num ^ 3827420284U;
										num += 1925215683U;
										IntPtr 03FF71C69 = ldftn(14136211);
										num = 234507969U - num;
										0B005140.38CC03B8 value59 = new 0B005140.38CC03B8(this, 03FF71C69);
										num %= 615189618U;
										dictionary131[key130] = value59;
										num = (172050842U | num);
										if (num % 650725563U == 0U)
										{
											goto IL_11;
										}
										num ^= 1451180850U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary132 = this.0313506C;
										num /= 1173584355U;
										uint key131 = num - 4294967164U;
										num = (1727925272U ^ num);
										IntPtr 03FF71C70 = ldftn(505C30CE);
										num = 1181224931U << (int)num;
										dictionary132[key131] = new 0B005140.38CC03B8(this, 03FF71C70);
										num = 2109156270U % num;
										num -= 1839278710U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary133 = this.0313506C;
										num = 16149719U / num;
										uint key132 = num + 134U;
										num = 1401911227U - num;
										num /= 2113874418U;
										IntPtr 03FF71C71 = ldftn(5D146CD8);
										num = (436743856U ^ num);
										dictionary133[key132] = new 0B005140.38CC03B8(this, 03FF71C71);
										if ((num ^ 1593604482U) == 0U)
										{
											goto IL_2E;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary134 = this.0313506C;
										num = (2054227285U | num);
										uint key133 = num - 2054762350U;
										num ^= 413021652U;
										IntPtr 03FF71C72 = ldftn(253C6BB5);
										num = 1107904266U % num;
										0B005140.38CC03B8 value60 = new 0B005140.38CC03B8(this, 03FF71C72);
										num = 1143565143U + num;
										dictionary134[key133] = value60;
										num = 445867993U * num;
										num = 1677000966U * num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary135 = this.0313506C;
										num |= 1089553784U;
										uint key134 = num ^ 3237993974U;
										num = 1620994156U - num;
										num = (1560685636U & num);
										0B005140.38CC03B8 value61 = new 0B005140.38CC03B8(this.58E41DB7);
										num = (779503468U ^ num);
										dictionary135[key134] = value61;
										Dictionary<uint, 0B005140.38CC03B8> dictionary136 = this.0313506C;
										uint key135 = num + 3431969121U;
										num >>= 22;
										0B005140.38CC03B8 value62 = new 0B005140.38CC03B8(this.14136211);
										num = (38495348U | num);
										dictionary136[key135] = value62;
										num %= 1858550589U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary137 = this.0313506C;
										uint key136 = num - 38495347U;
										num = 1238124858U % num;
										num = 391151602U >> (int)num;
										IntPtr 03FF71C73 = ldftn(4FAD3F96);
										num = (778003995U | num);
										dictionary137[key136] = new 0B005140.38CC03B8(this, 03FF71C73);
										num ^= 1207053930U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary138 = this.0313506C;
										num *= 1728532782U;
										uint key137 = num - 3745712507U;
										0B005140.38CC03B8 value63 = new 0B005140.38CC03B8(this.31BE63C9);
										num = (1594833939U & num);
										dictionary138[key137] = value63;
										num |= 1752515911U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary139 = this.0313506C;
										uint key138 = num ^ 2138525131U;
										IntPtr 03FF71C74 = ldftn(4FAD3F96);
										num = (2068609845U ^ num);
										0B005140.38CC03B8 value64 = new 0B005140.38CC03B8(this, 03FF71C74);
										num |= 1883643163U;
										dictionary139[key138] = value64;
										num = 1863783519U >> (int)num;
										if (num == 1497583352U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary140 = this.0313506C;
										uint key139 = num - 4294967168U;
										num = (958552198U ^ num);
										dictionary140[key139] = new 0B005140.38CC03B8(this.31BE63C9);
										if (7673272U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary141 = this.0313506C;
										uint key140 = num ^ 958552069U;
										num = 1226055182U + num;
										num = 1455452449U % num;
										0B005140.38CC03B8 value65 = new 0B005140.38CC03B8(this.5023492D);
										num = (448807209U ^ num);
										dictionary141[key140] = value65;
										if ((num ^ 1138704980U) == 0U)
										{
											goto IL_00;
										}
										num *= 469303397U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary142 = this.0313506C;
										num >>= 31;
										uint key141 = num ^ 142U;
										num = 1133084649U + num;
										num = 85032447U * num;
										0B005140.38CC03B8 value66 = new 0B005140.38CC03B8(this.14136211);
										num -= 1933844535U;
										dictionary142[key141] = value66;
										num *= 1439110928U;
										num |= 797511328U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary143 = this.0313506C;
										num >>= 0;
										uint key142 = num - 797691488U;
										num |= 72552268U;
										0B005140.38CC03B8 value67 = new 0B005140.38CC03B8(this.63A566F8);
										num *= 1899784723U;
										dictionary143[key142] = value67;
										num += 167920337U;
										if ((274013630U & num) == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary144 = this.0313506C;
										num += 837574243U;
										uint key143 = num ^ 3362613369U;
										num = 1364403590U << (int)num;
										num = 2068787182U + num;
										dictionary144[key143] = new 0B005140.38CC03B8(this.3C6D67F6);
										num ^= 145840958U;
										num *= 1288648175U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary145 = this.0313506C;
										num += 379604334U;
										uint key144 = num - 2114670860U;
										num = 2129068495U >> (int)num;
										IntPtr 03FF71C75 = ldftn(08C843B8);
										num <<= 1;
										0B005140.38CC03B8 value68 = new 0B005140.38CC03B8(this, 03FF71C75);
										num = 1527668500U * num;
										dictionary145[key144] = value68;
										num = 257449280U >> (int)num;
										num = 1300329794U * num;
										this.0313506C[num ^ 2268350569U] = new 0B005140.38CC03B8(this.505C30CE);
										this.0313506C[num ^ 2268350574U] = new 0B005140.38CC03B8(this.505C30CE);
										num -= 1802205163U;
										if (1548516842 << (int)num == 0)
										{
											goto IL_00;
										}
										num = 145899897U >> (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary146 = this.0313506C;
										num = (1829446269U | num);
										uint key145 = num ^ 1829450728U;
										num = 222243450U >> (int)num;
										IntPtr 03FF71C76 = ldftn(68151E18);
										num = (2046233475U | num);
										0B005140.38CC03B8 value69 = new 0B005140.38CC03B8(this, 03FF71C76);
										num &= 1931816843U;
										dictionary146[key145] = value69;
										num -= 709428374U;
										if (912155541U * num == 0U)
										{
											goto IL_11;
										}
										num = 1221225152U >> (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary147 = this.0313506C;
										uint key146 = num + 4294818371U;
										num = 1651860509U >> (int)num;
										num += 459426202U;
										dictionary147[key146] = new 0B005140.38CC03B8(this.31BE63C9);
										num = (560869035U ^ num);
										num = 1467054420U << (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary148 = this.0313506C;
										num = (351235187U & num);
										uint key147 = num + 4017404023U;
										IntPtr 03FF71C77 = ldftn(20D0612C);
										num += 2106940184U;
										0B005140.38CC03B8 value70 = new 0B005140.38CC03B8(this, 03FF71C77);
										num = (1827632346U & num);
										dictionary148[key147] = value70;
										if (num == 1157958665U)
										{
											goto IL_4C;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary149 = this.0313506C;
										num = 1323724377U + num;
										uint key148 = num ^ 1527156457U;
										num = 1536629903U << (int)num;
										0B005140.38CC03B8 value71 = new 0B005140.38CC03B8(this.2C947ABF);
										num *= 241115278U;
										dictionary149[key148] = value71;
										num *= 161437030U;
										num %= 2017479435U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary150 = this.0313506C;
										num = 975507034U / num;
										uint key149 = num + 150U;
										IntPtr 03FF71C78 = ldftn(63A566F8);
										num |= 1558476912U;
										0B005140.38CC03B8 value72 = new 0B005140.38CC03B8(this, 03FF71C78);
										num = 41297547U % num;
										dictionary150[key149] = value72;
										num = 1971015457U + num;
										if (num == 1188509703U)
										{
											goto IL_00;
										}
										num -= 1485515089U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary151 = this.0313506C;
										num = 975272879U >> (int)num;
										dictionary151[num ^ 157U] = new 0B005140.38CC03B8(this.5F8E3204);
										num <<= 26;
										if ((num ^ 1841650927U) == 0U)
										{
											goto IL_11;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary152 = this.0313506C;
										num -= 924416154U;
										dictionary152[num ^ 3840313341U] = new 0B005140.38CC03B8(this.20D0612C);
										Dictionary<uint, 0B005140.38CC03B8> dictionary153 = this.0313506C;
										uint key150 = num ^ 3840313338U;
										num = (676142632U ^ num);
										0B005140.38CC03B8 value73 = new 0B005140.38CC03B8(this.3C6D67F6);
										num -= 1718104117U;
										dictionary153[key150] = value73;
										Dictionary<uint, 0B005140.38CC03B8> dictionary154 = this.0313506C;
										num = 5382371U * num;
										uint key151 = num - 3303755918U;
										num = 1095638061U << (int)num;
										num %= 269883097U;
										IntPtr 03FF71C79 = ldftn(7B7F0C90);
										num >>= 6;
										dictionary154[key151] = new 0B005140.38CC03B8(this, 03FF71C79);
										num = (1188113593U & num);
										if (798303650U - num == 0U)
										{
											goto IL_00;
										}
										num = 326435888U << (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary155 = this.0313506C;
										uint key152 = num + 3968531566U;
										num = 1503427549U >> (int)num;
										num += 186674620U;
										IntPtr 03FF71C80 = ldftn(556B5BE8);
										num |= 80218806U;
										0B005140.38CC03B8 value74 = new 0B005140.38CC03B8(this, 03FF71C80);
										num = 1137078704U << (int)num;
										dictionary155[key152] = value74;
										if ((num & 1381774650U) != 0U)
										{
											break;
										}
										num = 1189503785U << (int)num;
										this.0313506C[num ^ 1189503926U] = new 0B005140.38CC03B8(this.505C30CE);
										num &= 1981241085U;
										if (num + 1729639469U == 0U)
										{
											goto IL_11;
										}
										num <<= 31;
										Dictionary<uint, 0B005140.38CC03B8> dictionary156 = this.0313506C;
										num = 1914578267U << (int)num;
										uint key153 = num ^ 1914578427U;
										num /= 1625976472U;
										IntPtr 03FF71C81 = ldftn(4CCE0252);
										num %= 1329414871U;
										dictionary156[key153] = new 0B005140.38CC03B8(this, 03FF71C81);
										num >>= 16;
										if (356584830U * num != 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary157 = this.0313506C;
										uint key154 = num - 4294967135U;
										num |= 1950052287U;
										num = (1119625301U | num);
										IntPtr 03FF71C82 = ldftn(752C72A8);
										num &= 310445300U;
										dictionary157[key154] = new 0B005140.38CC03B8(this, 03FF71C82);
										if (num == 1875192010U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary158 = this.0313506C;
										uint key155 = num + 3984522158U;
										IntPtr 03FF71C83 = ldftn(5D146CD8);
										num = 406391750U * num;
										0B005140.38CC03B8 value75 = new 0B005140.38CC03B8(this, 03FF71C83);
										num += 465050589U;
										dictionary158[key155] = value75;
										if (445674759U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary159 = this.0313506C;
										num = 685917345U << (int)num;
										uint key156 = num - 2485124957U;
										0B005140.38CC03B8 value76 = new 0B005140.38CC03B8(this.4E483802);
										num = 999294239U - num;
										dictionary159[key156] = value76;
										num = 1335583887U + num;
										if (869926057U - num == 0U)
										{
											goto IL_00;
										}
										num = 93078409U >> (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary160 = this.0313506C;
										uint key157 = num ^ 5781U;
										num = (670633336U | num);
										num ^= 2054291878U;
										dictionary160[key157] = new 0B005140.38CC03B8(this.54B95DF1);
										if (num < 1036417852U)
										{
											goto IL_00;
										}
										num -= 897672017U;
										this.0313506C[num + 3623240983U] = new 0B005140.38CC03B8(this.4E483802);
										num = (135618971U ^ num);
										if (99358531U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary161 = this.0313506C;
										uint key158 = num ^ 538761907U;
										num = 1599629154U % num;
										dictionary161[key158] = new 0B005140.38CC03B8(this.5DB25352);
										num = (1530596241U ^ num);
										num %= 1913016016U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary162 = this.0313506C;
										uint key159 = num - 1143322626U;
										num <<= 5;
										IntPtr 03FF71C84 = ldftn(608029DD);
										num *= 863961989U;
										dictionary162[key159] = new 0B005140.38CC03B8(this, 03FF71C84);
										num = 441089846U / num;
										if (num >= 1259021651U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary163 = this.0313506C;
										uint key160 = num - 4294967128U;
										num *= 660349142U;
										IntPtr 03FF71C85 = ldftn(62AB7105);
										num = (798438834U | num);
										0B005140.38CC03B8 value77 = new 0B005140.38CC03B8(this, 03FF71C85);
										num ^= 715394639U;
										dictionary163[key160] = value77;
										num = 1026839271U + num;
										if (429345024U / num != 0U)
										{
											goto IL_11;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary164 = this.0313506C;
										uint key161 = num ^ 1114082893U;
										IntPtr 03FF71C86 = ldftn(63A566F8);
										num = (1968579303U & num);
										0B005140.38CC03B8 value78 = new 0B005140.38CC03B8(this, 03FF71C86);
										num = 839803366U % num;
										dictionary164[key161] = value78;
										num = 2056092710U / num;
										num %= 2090629320U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary165 = this.0313506C;
										uint key162 = num - 4294967128U;
										num = 550066387U % num;
										num /= 1800732700U;
										0B005140.38CC03B8 value79 = new 0B005140.38CC03B8(this.3F133A57);
										num ^= 626328214U;
										dictionary165[key162] = value79;
										num = (552471404U ^ num);
										if (867379237U < num)
										{
											goto IL_11;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary166 = this.0313506C;
										uint key163 = num + 4198823601U;
										num &= 1648956155U;
										IntPtr 03FF71C87 = ldftn(54B95DF1);
										num = 503644216U % num;
										0B005140.38CC03B8 value80 = new 0B005140.38CC03B8(this, 03FF71C87);
										num = 921638497U * num;
										dictionary166[key163] = value80;
										num = 533412074U / num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary167 = this.0313506C;
										uint key164 = num + 172U;
										num >>= 9;
										num = 102856611U + num;
										dictionary167[key164] = new 0B005140.38CC03B8(this.63A566F8);
										num = 94661830U - num;
										if (num < 202132789U)
										{
											goto IL_4C;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary168 = this.0313506C;
										uint key165 = num ^ 4286772622U;
										num = 2069460072U * num;
										0B005140.38CC03B8 value81 = new 0B005140.38CC03B8(this.7B7F0C90);
										num /= 1999576148U;
										dictionary168[key165] = value81;
										if (2129868132U - num == 0U)
										{
											goto IL_2E;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary169 = this.0313506C;
										uint key166 = num ^ 174U;
										num |= 1512767558U;
										num = 935930396U + num;
										IntPtr 03FF71C88 = ldftn(7B7F0C90);
										num ^= 1509442001U;
										dictionary169[key166] = new 0B005140.38CC03B8(this, 03FF71C88);
										num <<= 21;
										Dictionary<uint, 0B005140.38CC03B8> dictionary170 = this.0313506C;
										uint key167 = num - 1986002769U;
										num ^= 851053736U;
										num = 2142324106U - num;
										IntPtr 03FF71C89 = ldftn(5AD53B14);
										num ^= 761217548U;
										dictionary170[key167] = new 0B005140.38CC03B8(this, 03FF71C89);
										num >>= 3;
										num <<= 12;
										Dictionary<uint, 0B005140.38CC03B8> dictionary171 = this.0313506C;
										num = 1790838202U + num;
										uint key168 = num ^ 2075383050U;
										num &= 389694583U;
										IntPtr 03FF71C90 = ldftn(75395636);
										num = (117591895U | num);
										0B005140.38CC03B8 value82 = new 0B005140.38CC03B8(this, 03FF71C90);
										num = 1932096762U * num;
										dictionary171[key168] = value82;
										num = 831879283U >> (int)num;
										if (2115965111U / num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary172 = this.0313506C;
										num += 733033461U;
										uint key169 = num - 733033482U;
										IntPtr 03FF71C91 = ldftn(54B95DF1);
										num = 2080768800U - num;
										dictionary172[key169] = new 0B005140.38CC03B8(this, 03FF71C91);
										this.0313506C[num + 2947232333U] = new 0B005140.38CC03B8(this.54B95DF1);
										Dictionary<uint, 0B005140.38CC03B8> dictionary173 = this.0313506C;
										num &= 1183014016U;
										uint key170 = num ^ 1073761459U;
										0B005140.38CC03B8 value83 = new 0B005140.38CC03B8(this.5AD53B14);
										num &= 1738356566U;
										dictionary173[key170] = value83;
										num += 955601528U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary174 = this.0313506C;
										num ^= 1147870006U;
										uint key171 = num - 1017007258U;
										num += 1454311497U;
										num &= 818431855U;
										dictionary174[key171] = new 0B005140.38CC03B8(this.08C843B8);
										this.0313506C[num ^ 273171890U] = new 0B005140.38CC03B8(this.177C0751);
										if (1091928052U <= num)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary175 = this.0313506C;
										num &= 1041173521U;
										uint key172 = num - 268960587U;
										num %= 94907035U;
										num = 1383100348U - num;
										0B005140.38CC03B8 value84 = new 0B005140.38CC03B8(this.4F776CFF);
										num |= 371924547U;
										dictionary175[key172] = value84;
										num |= 711808271U;
										if (1402344669U % num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary176 = this.0313506C;
										num += 916276925U;
										uint key173 = num - 3063752197U;
										IntPtr 03FF71C92 = ldftn(5AD53B14);
										num >>= 18;
										dictionary176[key173] = new 0B005140.38CC03B8(this, 03FF71C92);
										num |= 1894657309U;
										num = 670983322U % num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary177 = this.0313506C;
										uint key174 = num - 670983138U;
										num = (1379297704U & num);
										IntPtr 03FF71C93 = ldftn(7B7F0C90);
										num = (952242411U | num);
										0B005140.38CC03B8 value85 = new 0B005140.38CC03B8(this, 03FF71C93);
										num %= 1101881670U;
										dictionary177[key174] = value85;
										num <<= 17;
										num += 1212053093U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary178 = this.0313506C;
										uint key175 = num ^ 705984220U;
										IntPtr 03FF71C94 = ldftn(4FAD3F96);
										num = 1072323034U * num;
										dictionary178[key175] = new 0B005140.38CC03B8(this, 03FF71C94);
										num &= 2032228766U;
										num = 1827870022U % num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary179 = this.0313506C;
										num = (799677490U | num);
										dictionary179[num + 3489678340U] = new 0B005140.38CC03B8(this.7B7F0C90);
										num = (1493308301U | num);
										Dictionary<uint, 0B005140.38CC03B8> dictionary180 = this.0313506C;
										num &= 204766496U;
										dictionary180[num ^ 204750235U] = new 0B005140.38CC03B8(this.5F8E3204);
										num = (2051364428U ^ num);
										if (num < 855056493U)
										{
											goto IL_11;
										}
										num ^= 248522384U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary181 = this.0313506C;
										num = 1726291369U >> (int)num;
										uint key176 = num ^ 186U;
										IntPtr 03FF71C95 = ldftn(7B7F0C90);
										num *= 1933511459U;
										dictionary181[key176] = new 0B005140.38CC03B8(this, 03FF71C95);
										if (970203074U > num)
										{
											goto IL_00;
										}
										num = 993934926U % num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary182 = this.0313506C;
										uint key177 = num ^ 993935091U;
										num = (1498230305U | num);
										IntPtr 03FF71C96 = ldftn(31BE63C9);
										num >>= 13;
										dictionary182[key177] = new 0B005140.38CC03B8(this, 03FF71C96);
										num = (500725041U ^ num);
										if (num >= 617355918U)
										{
											goto IL_11;
										}
										num += 1541232245U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary183 = this.0313506C;
										num <<= 25;
										uint key178 = num ^ 2046820542U;
										IntPtr 03FF71C97 = ldftn(608029DD);
										num = 1643733623U % num;
										0B005140.38CC03B8 value86 = new 0B005140.38CC03B8(this, 03FF71C97);
										num = 1604613732U / num;
										dictionary183[key178] = value86;
										Dictionary<uint, 0B005140.38CC03B8> dictionary184 = this.0313506C;
										uint key179 = num - 4294967105U;
										num = 139088233U - num;
										IntPtr 03FF71C98 = ldftn(25A07462);
										num >>= 8;
										0B005140.38CC03B8 value87 = new 0B005140.38CC03B8(this, 03FF71C98);
										num |= 2001887471U;
										dictionary184[key179] = value87;
										if (num <= 786134406U)
										{
											goto IL_00;
										}
										num = 1456875534U * num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary185 = this.0313506C;
										uint key180 = num + 1026313934U;
										num *= 1408388035U;
										0B005140.38CC03B8 value88 = new 0B005140.38CC03B8(this.31665807);
										num -= 421266278U;
										dictionary185[key180] = value88;
										num -= 1475748308U;
										num = 2089823348U - num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary186 = this.0313506C;
										uint key181 = num ^ 3564888217U;
										num *= 406205001U;
										dictionary186[key181] = new 0B005140.38CC03B8(this.177C0751);
										Dictionary<uint, 0B005140.38CC03B8> dictionary187 = this.0313506C;
										num = 1337290691U + num;
										uint key182 = num - 2875824153U;
										IntPtr 03FF71C99 = ldftn(54B95DF1);
										num = (1242832129U | num);
										0B005140.38CC03B8 value89 = new 0B005140.38CC03B8(this, 03FF71C99);
										num *= 644050094U;
										dictionary187[key182] = value89;
										if (2105678348U == num)
										{
											goto IL_00;
										}
										num -= 1479278961U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary188 = this.0313506C;
										num = 1600266475U - num;
										uint key183 = num ^ 467891009U;
										IntPtr 03FF71C100 = ldftn(63A566F8);
										num += 193483716U;
										dictionary188[key183] = new 0B005140.38CC03B8(this, 03FF71C100);
										num &= 83765396U;
										num = 1558207847U << (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary189 = this.0313506C;
										uint key184 = num + 838478420U;
										num = 1726027676U << (int)num;
										0B005140.38CC03B8 value90 = new 0B005140.38CC03B8(this.54B95DF1);
										num = (115477241U & num);
										dictionary189[key184] = value90;
										if (944400008 << (int)num == 0)
										{
											goto IL_2E;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary190 = this.0313506C;
										num %= 519331483U;
										uint key185 = num ^ 109052101U;
										num &= 28718975U;
										dictionary190[key185] = new 0B005140.38CC03B8(this.31665807);
										if (num >= 1182866795U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary191 = this.0313506C;
										uint key186 = num + 4286578886U;
										num += 1924756611U;
										num >>= 5;
										0B005140.38CC03B8 value91 = new 0B005140.38CC03B8(this.5AD53B14);
										num = (1616270270U & num);
										dictionary191[key186] = value91;
										if (num == 183455083U)
										{
											goto IL_11;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary192 = this.0313506C;
										num = 1967736335U << (int)num;
										uint key187 = num ^ 1419010103U;
										num |= 1805741850U;
										num <<= 24;
										IntPtr 03FF71C101 = ldftn(31BE63C9);
										num = 963723063U >> (int)num;
										0B005140.38CC03B8 value92 = new 0B005140.38CC03B8(this, 03FF71C101);
										num |= 1024460506U;
										dictionary192[key187] = value92;
										if (num % 1004347194U == 0U)
										{
											goto IL_11;
										}
										num ^= 50466478U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary193 = this.0313506C;
										num = (1566604108U | num);
										uint key188 = num ^ 2138274709U;
										num = (431295943U ^ num);
										num = 1391490004U + num;
										IntPtr 03FF71C102 = ldftn(54B95DF1);
										num = (824394687U ^ num);
										0B005140.38CC03B8 value93 = new 0B005140.38CC03B8(this, 03FF71C102);
										num = 604130535U * num;
										dictionary193[key188] = value93;
										Dictionary<uint, 0B005140.38CC03B8> dictionary194 = this.0313506C;
										uint key189 = num ^ 1696089950U;
										num = (2026836790U ^ num);
										num = 204558296U << (int)num;
										IntPtr 03FF71C103 = ldftn(10DD4D96);
										num = (185869867U | num);
										0B005140.38CC03B8 value94 = new 0B005140.38CC03B8(this, 03FF71C103);
										num ^= 163319267U;
										dictionary194[key189] = value94;
										num = 1216367228U + num;
										if (877291957U * num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary195 = this.0313506C;
										num %= 1376724378U;
										uint key190 = num ^ 154916848U;
										num = 1632765392U % num;
										IntPtr 03FF71C104 = ldftn(5AD53B14);
										num >>= 12;
										0B005140.38CC03B8 value95 = new 0B005140.38CC03B8(this, 03FF71C104);
										num %= 1567579535U;
										dictionary195[key190] = value95;
										if (2124025569U == num)
										{
											goto IL_00;
										}
										num = 1047265936U * num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary196 = this.0313506C;
										uint key191 = num + 2401744571U;
										num = 593253103U % num;
										IntPtr 03FF71C105 = ldftn(14136211);
										num |= 1147866588U;
										0B005140.38CC03B8 value96 = new 0B005140.38CC03B8(this, 03FF71C105);
										num %= 1245459845U;
										dictionary196[key191] = value96;
										num = (516969066U & num);
										if ((1343893941U ^ num) == 0U)
										{
											goto IL_4C;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary197 = this.0313506C;
										num ^= 339033972U;
										uint key192 = num - 141900882U;
										num ^= 1436183774U;
										IntPtr 03FF71C106 = ldftn(62AB7105);
										num %= 754263141U;
										0B005140.38CC03B8 value97 = new 0B005140.38CC03B8(this, 03FF71C106);
										num >>= 0;
										dictionary197[key192] = value97;
										Dictionary<uint, 0B005140.38CC03B8> dictionary198 = this.0313506C;
										num = 1047724318U / num;
										uint key193 = num + 190U;
										num = 1700098868U - num;
										IntPtr 03FF71C107 = ldftn(69C70694);
										num = (1457417698U & num);
										0B005140.38CC03B8 value98 = new 0B005140.38CC03B8(this, 03FF71C107);
										num *= 1223520256U;
										dictionary198[key193] = value98;
										num = 1194548480U - num;
										num >>= 8;
										Dictionary<uint, 0B005140.38CC03B8> dictionary199 = this.0313506C;
										num >>= 15;
										uint key194 = num ^ 42U;
										num -= 1828729123U;
										0B005140.38CC03B8 value99 = new 0B005140.38CC03B8(this.08C843B8);
										num += 1204436477U;
										dictionary199[key194] = value99;
										Dictionary<uint, 0B005140.38CC03B8> dictionary200 = this.0313506C;
										num |= 1643932650U;
										uint key195 = num ^ 4227755825U;
										num = (664959319U | num);
										0B005140.38CC03B8 value100 = new 0B005140.38CC03B8(this.63A566F8);
										num = (1219831706U | num);
										dictionary200[key195] = value100;
										num = 995835110U * num;
										num /= 79830289U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary201 = this.0313506C;
										num = 1044936326U >> (int)num;
										uint key196 = num + 4290885722U;
										num /= 1254894371U;
										0B005140.38CC03B8 value101 = new 0B005140.38CC03B8(this.2C947ABF);
										num = 1752062056U * num;
										dictionary201[key196] = value101;
										Dictionary<uint, 0B005140.38CC03B8> dictionary202 = this.0313506C;
										uint key197 = num - 4294967087U;
										num = 1148005737U - num;
										num |= 409884700U;
										IntPtr 03FF71C108 = ldftn(555A0DB3);
										num |= 873364198U;
										0B005140.38CC03B8 value102 = new 0B005140.38CC03B8(this, 03FF71C108);
										num = 844067139U + num;
										dictionary202[key197] = value102;
										num >>= 19;
										if (1868124348U * num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary203 = this.0313506C;
										num ^= 241577907U;
										uint key198 = num ^ 241580726U;
										0B005140.38CC03B8 value103 = new 0B005140.38CC03B8(this.31BE63C9);
										num >>= 14;
										dictionary203[key198] = value103;
										Dictionary<uint, 0B005140.38CC03B8> dictionary204 = this.0313506C;
										uint key199 = num ^ 14667U;
										num *= 170925661U;
										dictionary204[key199] = new 0B005140.38CC03B8(this.617B47EC);
										num %= 1993744956U;
										num -= 1822169595U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary205 = this.0313506C;
										uint key200 = num - 3756162861U;
										num |= 1316446319U;
										IntPtr 03FF71C109 = ldftn(608029DD);
										num *= 800525634U;
										0B005140.38CC03B8 value104 = new 0B005140.38CC03B8(this, 03FF71C109);
										num *= 1518537605U;
										dictionary205[key200] = value104;
										num >>= 19;
										if (num >= 554504560U)
										{
											goto IL_00;
										}
										num += 569011780U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary206 = this.0313506C;
										num = 1472292231U % num;
										uint key201 = num ^ 334268126U;
										num = 1487152278U / num;
										IntPtr 03FF71C110 = ldftn(4BA3699C);
										num -= 1920564360U;
										dictionary206[key201] = new 0B005140.38CC03B8(this, 03FF71C110);
										num = 2064720341U >> (int)num;
										if ((num & 1584809580U) == 0U)
										{
											goto IL_4C;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary207 = this.0313506C;
										uint key202 = num ^ 209U;
										IntPtr 03FF71C111 = ldftn(5DB25352);
										num = (1883842625U ^ num);
										0B005140.38CC03B8 value105 = new 0B005140.38CC03B8(this, 03FF71C111);
										num *= 1975128234U;
										dictionary207[key202] = value105;
										if (2115132897U >> (int)num == 0U)
										{
											goto IL_11;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary208 = this.0313506C;
										num = 1646220247U * num;
										uint key203 = num ^ 2495794931U;
										num = 1496211679U >> (int)num;
										0B005140.38CC03B8 value106 = new 0B005140.38CC03B8(this.505C30CE);
										num += 86512606U;
										dictionary208[key203] = value106;
										num = (1174604184U & num);
										if (num >= 1205617193U)
										{
											goto IL_00;
										}
										num %= 1840736027U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary209 = this.0313506C;
										uint key204 = num + 4261279568U;
										num &= 951415055U;
										dictionary209[key204] = new 0B005140.38CC03B8(this.5AD53B14);
										if ((630988156U ^ num) == 0U)
										{
											goto IL_00;
										}
										num /= 1358250025U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary210 = this.0313506C;
										uint key205 = num ^ 217U;
										num = 753224694U << (int)num;
										num >>= 7;
										dictionary210[key205] = new 0B005140.38CC03B8(this.5C0664E0);
										num = 201011059U >> (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary211 = this.0313506C;
										num &= 446128310U;
										uint key206 = num - 4294967100U;
										0B005140.38CC03B8 value107 = new 0B005140.38CC03B8(this.718E0370);
										num = (108207034U & num);
										dictionary211[key206] = value107;
										Dictionary<uint, 0B005140.38CC03B8> dictionary212 = this.0313506C;
										num %= 1046507032U;
										uint key207 = num ^ 201U;
										num = (359147388U ^ num);
										IntPtr 03FF71C112 = ldftn(75395636);
										num *= 1312181954U;
										0B005140.38CC03B8 value108 = new 0B005140.38CC03B8(this, 03FF71C112);
										num >>= 17;
										dictionary212[key207] = value108;
										num = 420947463U << (int)num;
										num -= 1043091518U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary213 = this.0313506C;
										uint key208 = num + 2786087194U;
										num += 714823620U;
										IntPtr 03FF71C113 = ldftn(617B47EC);
										num &= 1415329787U;
										dictionary213[key208] = new 0B005140.38CC03B8(this, 03FF71C113);
										num /= 995633477U;
										num &= 772424458U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary214 = this.0313506C;
										num *= 773291569U;
										uint key209 = num - 4294967075U;
										num -= 189611724U;
										dictionary214[key209] = new 0B005140.38CC03B8(this.62AB7105);
										num = 232937144U % num;
										if (815346872U + num == 0U)
										{
											goto IL_00;
										}
										num += 604318698U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary215 = this.0313506C;
										num |= 277479685U;
										uint key210 = num - 837780169U;
										num = 2101631621U << (int)num;
										IntPtr 03FF71C114 = ldftn(63A566F8);
										num *= 878461758U;
										0B005140.38CC03B8 value109 = new 0B005140.38CC03B8(this, 03FF71C114);
										num -= 1812857628U;
										dictionary215[key210] = value109;
										num += 1743978611U;
										if (num == 1269704377U)
										{
											goto IL_2E;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary216 = this.0313506C;
										num = 1380678601U - num;
										uint key211 = num ^ 1359537069U;
										num ^= 1843279287U;
										IntPtr 03FF71C115 = ldftn(4E483802);
										num ^= 1785931026U;
										dictionary216[key211] = new 0B005140.38CC03B8(this, 03FF71C115);
										num |= 801864214U;
										if (num == 461730608U)
										{
											goto IL_11;
										}
										num >>= 17;
										Dictionary<uint, 0B005140.38CC03B8> dictionary217 = this.0313506C;
										num <<= 4;
										uint key212 = num ^ 262032U;
										num = 474355213U / num;
										dictionary217[key212] = new 0B005140.38CC03B8(this.51C6440E);
										num = 217464418U / num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary218 = this.0313506C;
										uint key213 = num ^ 120243U;
										num >>= 4;
										dictionary218[key213] = new 0B005140.38CC03B8(this.17987A23);
										num += 1320488768U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary219 = this.0313506C;
										num <<= 19;
										uint key214 = num ^ 1688731874U;
										num = 264398076U * num;
										num ^= 830219899U;
										IntPtr 03FF71C116 = ldftn(31BE63C9);
										num = (674241261U | num);
										0B005140.38CC03B8 value110 = new 0B005140.38CC03B8(this, 03FF71C116);
										num |= 561720321U;
										dictionary219[key214] = value110;
										num = 1646215902U << (int)num;
										Dictionary<uint, 0B005140.38CC03B8> dictionary220 = this.0313506C;
										uint key215 = num - 4294967069U;
										num |= 878656117U;
										IntPtr 03FF71C117 = ldftn(31BE63C9);
										num <<= 28;
										0B005140.38CC03B8 value111 = new 0B005140.38CC03B8(this, 03FF71C117);
										num &= 708516279U;
										dictionary220[key215] = value111;
										if (num == 130689898U)
										{
											goto IL_4C;
										}
										Dictionary<uint, 0B005140.38CC03B8> dictionary221 = this.0313506C;
										num /= 2013362715U;
										uint key216 = num ^ 228U;
										num &= 1066555488U;
										num = 719280342U << (int)num;
										0B005140.38CC03B8 value112 = new 0B005140.38CC03B8(this.5AD53B14);
										num = 639396331U - num;
										dictionary221[key216] = value112;
										num /= 811236718U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary222 = this.0313506C;
										num %= 1701597835U;
										dictionary222[num + 224U] = new 0B005140.38CC03B8(this.54B95DF1);
										num = (302319066U ^ num);
										Dictionary<uint, 0B005140.38CC03B8> dictionary223 = this.0313506C;
										num ^= 1114640385U;
										uint key217 = num ^ 1349850424U;
										num *= 244005406U;
										dictionary223[key217] = new 0B005140.38CC03B8(this.556B5BE8);
										num -= 56766872U;
										if ((336593380U & num) == 0U)
										{
											goto IL_00;
										}
										num /= 2142796930U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary224 = this.0313506C;
										uint key218 = num ^ 230U;
										num &= 516556959U;
										dictionary224[key218] = new 0B005140.38CC03B8(this.512E6F9A);
										num ^= 125517273U;
										num -= 1358570972U;
										Dictionary<uint, 0B005140.38CC03B8> dictionary225 = this.0313506C;
										num <<= 30;
										uint key219 = num ^ 232U;
										0B005140.38CC03B8 value113 = new 0B005140.38CC03B8(this.2F517C82);
										num ^= 2043476U;
										dictionary225[key219] = value113;
										num /= 2120418008U;
										if (num <= 422054404U)
										{
											goto Block_117;
										}
									}
								}
							}
							Block_117:
							Dictionary<uint, 0B005140.38CC03B8> dictionary226 = this.0313506C;
							num &= 735923030U;
							uint key220 = num ^ 233U;
							num -= 577641980U;
							dictionary226[key220] = new 0B005140.38CC03B8(this.5DB25352);
							if (num / 1678453884U == 0U)
							{
								goto IL_2E;
							}
							this.0313506C[num + 577642214U] = new 0B005140.38CC03B8(this.505C30CE);
							num = (83896330U ^ num);
							if (num <= 901845474U)
							{
								goto IL_11;
							}
							num -= 2033084290U;
							Dictionary<uint, 0B005140.38CC03B8> dictionary227 = this.0313506C;
							uint key221 = num - 1600348577U;
							0B005140.38CC03B8 value114 = new 0B005140.38CC03B8(this.4E483802);
							num = 1779177780U * num;
							dictionary227[key221] = value114;
							Dictionary<uint, 0B005140.38CC03B8> dictionary228 = this.0313506C;
							uint key222 = num ^ 2875175068U;
							num %= 1410878761U;
							num = 122885896U + num;
							IntPtr 03FF71C118 = ldftn(608029DD);
							num = 1428717323U / num;
							dictionary228[key222] = new 0B005140.38CC03B8(this, 03FF71C118);
							Dictionary<uint, 0B005140.38CC03B8> dictionary229 = this.0313506C;
							uint key223 = num - 4294967067U;
							num = 1355763150U * num;
							0B005140.38CC03B8 value115 = new 0B005140.38CC03B8(this.6C310717);
							num = 1032330867U << (int)num;
							dictionary229[key223] = value115;
							num &= 1525566520U;
							Dictionary<uint, 0B005140.38CC03B8> dictionary230 = this.0313506C;
							num = (43020669U | num);
							uint key224 = num ^ 452096403U;
							num -= 1188257899U;
							num <<= 15;
							IntPtr 03FF71C119 = ldftn(493F68A3);
							num = 770594100U / num;
							dictionary230[key224] = new 0B005140.38CC03B8(this, 03FF71C119);
							num = 837822769U << (int)num;
							Dictionary<uint, 0B005140.38CC03B8> dictionary231 = this.0313506C;
							uint key225 = num - 837822530U;
							IntPtr 03FF71C120 = ldftn(4FAD3F96);
							num += 665609853U;
							dictionary231[key225] = new 0B005140.38CC03B8(this, 03FF71C120);
							num = 782262037U + num;
							Dictionary<uint, 0B005140.38CC03B8> dictionary232 = this.0313506C;
							uint key226 = num ^ 2285694515U;
							num %= 936577027U;
							IntPtr 03FF71C121 = ldftn(63A566F8);
							num -= 1523144010U;
							dictionary232[key226] = new 0B005140.38CC03B8(this, 03FF71C121);
							if (num % 969343871U == 0U)
							{
								goto IL_2E;
							}
							Dictionary<uint, 0B005140.38CC03B8> dictionary233 = this.0313506C;
							uint key227 = num ^ 3184363906U;
							IntPtr 03FF71C122 = ldftn(08C843B8);
							num = (531522516U & num);
							dictionary233[key227] = new 0B005140.38CC03B8(this, 03FF71C122);
							num <<= 14;
							Dictionary<uint, 0B005140.38CC03B8> dictionary234 = this.0313506C;
							num = 1196713855U / num;
							uint key228 = num + 25U;
							num >>= 17;
							num = 1834108046U >> (int)num;
							0B005140.38CC03B8 value116 = new 0B005140.38CC03B8(this.2F517C82);
							num += 728970909U;
							dictionary234[key228] = value116;
							num |= 1777015128U;
							Dictionary<uint, 0B005140.38CC03B8> dictionary235 = this.0313506C;
							num = (1906841606U & num);
							uint key229 = num ^ 1906841841U;
							IntPtr 03FF71C123 = ldftn(4E483802);
							num = 490553428U - num;
							dictionary235[key229] = new 0B005140.38CC03B8(this, 03FF71C123);
							if (num >> 16 == 0U)
							{
								goto IL_11;
							}
							num = (1950568465U & num);
							Dictionary<uint, 0B005140.38CC03B8> dictionary236 = this.0313506C;
							num = 1762220999U << (int)num;
							uint key230 = num ^ 1539768564U;
							num >>= 23;
							dictionary236[key230] = new 0B005140.38CC03B8(this.54B95DF1);
							if (num + 798364941U == 0U)
							{
								goto IL_11;
							}
							Dictionary<uint, 0B005140.38CC03B8> dictionary237 = this.0313506C;
							uint key231 = num - 4294967234U;
							num /= 628572516U;
							num = (1201541962U ^ num);
							IntPtr 03FF71C124 = ldftn(14136211);
							num = 237439775U / num;
							dictionary237[key231] = new 0B005140.38CC03B8(this, 03FF71C124);
							if (num * 1343634378U != 0U)
							{
								goto IL_11;
							}
							Dictionary<uint, 0B005140.38CC03B8> dictionary238 = this.0313506C;
							num -= 1895631970U;
							uint key232 = num - 2399335080U;
							num *= 1232235408U;
							IntPtr 03FF71C125 = ldftn(40090BB7);
							num /= 187236646U;
							dictionary238[key232] = new 0B005140.38CC03B8(this, 03FF71C125);
							num = (69213051U ^ num);
							Dictionary<uint, 0B005140.38CC03B8> dictionary239 = this.0313506C;
							uint key233 = num ^ 69213065U;
							num = 1147551330U >> (int)num;
							num = 1848200119U % num;
							IntPtr 03FF71C126 = ldftn(0BB14632);
							num = (1113262097U & num);
							0B005140.38CC03B8 value117 = new 0B005140.38CC03B8(this, 03FF71C126);
							num = 768431488U + num;
							dictionary239[key233] = value117;
							num += 109259385U;
							num = 1614025809U * num;
							Dictionary<uint, 0B005140.38CC03B8> dictionary240 = this.0313506C;
							uint key234 = num - 906752209U;
							num |= 1212826221U;
							IntPtr 03FF71C127 = ldftn(718E0370);
							num ^= 1806203140U;
							0B005140.38CC03B8 value118 = new 0B005140.38CC03B8(this, 03FF71C127);
							num /= 609432156U;
							dictionary240[key234] = value118;
							num = 1325542030U + num;
							Dictionary<uint, 0B005140.38CC03B8> dictionary241 = this.0313506C;
							num = (1261177184U & num);
							uint key235 = num ^ 1258293497U;
							num >>= 20;
							IntPtr 03FF71C128 = ldftn(25A07462);
							num ^= 9313851U;
							dictionary241[key235] = new 0B005140.38CC03B8(this, 03FF71C128);
							num = 52564066U % num;
							Dictionary<uint, 0B005140.38CC03B8> dictionary242 = this.0313506C;
							uint key236 = num ^ 5999441U;
							num ^= 869864729U;
							IntPtr 03FF71C129 = ldftn(51C6440E);
							num = 1169424823U % num;
							0B005140.38CC03B8 value119 = new 0B005140.38CC03B8(this, 03FF71C129);
							num <<= 5;
							dictionary242[key236] = value119;
							if (1047865415U + num == 0U)
							{
								goto IL_11;
							}
							num <<= 5;
							Dictionary<uint, 0B005140.38CC03B8> dictionary243 = this.0313506C;
							uint key237 = num + 980675835U;
							num &= 821366283U;
							num = 1803559198U % num;
							0B005140.38CC03B8 value120 = new 0B005140.38CC03B8(this.2C947ABF);
							num = 25385172U - num;
							dictionary243[key237] = value120;
							if (num << 20 == 0U)
							{
								goto IL_2E;
							}
							num = 1836086840U % num;
							Dictionary<uint, 0B005140.38CC03B8> dictionary244 = this.0313506C;
							uint key238 = num ^ 17479222U;
							IntPtr 03FF71C130 = ldftn(6BCA29D4);
							num = (1107429104U | num);
							dictionary244[key238] = new 0B005140.38CC03B8(this, 03FF71C130);
							Dictionary<uint, 0B005140.38CC03B8> dictionary245 = this.0313506C;
							num &= 15291912U;
							uint key239 = num ^ 530165U;
							num >>= 25;
							num = (320634720U ^ num);
							IntPtr 03FF71C131 = ldftn(4CCE0252);
							num = 344606006U / num;
							0B005140.38CC03B8 value121 = new 0B005140.38CC03B8(this, 03FF71C131);
							num *= 1785070212U;
							dictionary245[key239] = value121;
							if ((519398563U ^ num) == 0U)
							{
								goto IL_2E;
							}
							Dictionary<uint, 0B005140.38CC03B8> dictionary246 = this.0313506C;
							num &= 1351026730U;
							uint key240 = num ^ 1074135294U;
							num ^= 1242633740U;
							IntPtr 03FF71C132 = ldftn(5DA526D1);
							num <<= 31;
							0B005140.38CC03B8 value122 = new 0B005140.38CC03B8(this, 03FF71C132);
							num = (395005448U ^ num);
							dictionary246[key240] = value122;
							if (num >= 703857200U)
							{
								goto IL_11;
							}
							num -= 849176359U;
							Dictionary<uint, 0B005140.38CC03B8> dictionary247 = this.0313506C;
							num -= 1313963545U;
							uint key241 = num ^ 2526832695U;
							num ^= 1214398023U;
							num = 596641778U + num;
							dictionary247[key241] = new 0B005140.38CC03B8(this.777A0C42);
							if (405359859U * num != 0U)
							{
								return;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000101 RID: 257 RVA: 0x000C719C File Offset: 0x000C719C
	private void 2D04165D(0B005140.124B6895 23717D58)
	{
		uint num;
		do
		{
			Stack<0B005140.375D71A4> stack = this.09B46D51;
			num = 2095472191U;
			0B005140.375D71A4 item = 23717D58.58C2988C();
			num = 1994659593U % num;
			stack.Push(item);
		}
		while (1607094629U >= num);
	}

	// Token: 0x06000102 RID: 258 RVA: 0x000C71D4 File Offset: 0x000C71D4
	private 0B005140.124B6895 0BD76085()
	{
		return this.09B46D51.Pop();
	}

	// Token: 0x06000103 RID: 259 RVA: 0x000C71F4 File Offset: 0x000C71F4
	private 0B005140.124B6895 261921B8()
	{
		uint num = 1331966767U;
		num <<= 11;
		Stack<0B005140.375D71A4> stack = this.09B46D51;
		num = 713695627U + num;
		return stack.Peek();
	}

	// Token: 0x06000104 RID: 260 RVA: 0x000C7224 File Offset: 0x000C7224
	private byte 44376D54()
	{
		long num = this.6C727377;
		uint num2 = 107556473U;
		long num3 = (long)this.107A346B;
		num2 = (585905164U | num2);
		long value = num + num3;
		num2 *= 1294348381U;
		IntPtr ptr = new IntPtr(value);
		num2 += 698101855U;
		byte result = Marshal.ReadByte(ptr);
		num2 = 1233076360U + num2;
		num2 = 1260334606U / num2;
		int num4 = this.107A346B;
		int num5 = (int)(num2 ^ 1U);
		num2 |= 362945680U;
		this.107A346B = num4 + num5;
		return result;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x000C7294 File Offset: 0x000C7294
	private short 0E1F2D8D()
	{
		uint num = 117449045U;
		num ^= 1504255078U;
		long num2 = this.6C727377;
		num ^= 807281449U;
		num = 1586914998U >> (int)num;
		long num3 = (long)this.107A346B;
		num <<= 18;
		long value = num2 + num3;
		num = (47664354U ^ num);
		IntPtr ptr = new IntPtr(value);
		num &= 1160993632U;
		short result = Marshal.ReadInt16(ptr);
		num += 162536221U;
		int num4 = this.107A346B;
		num = 2026260839U * num;
		int num5 = num4 + (int)(num ^ 2570693705U);
		num = 203427844U / num;
		this.107A346B = num5;
		return result;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x000C7324 File Offset: 0x000C7324
	private int 074259D8()
	{
		uint num = 1250456956U;
		long num2 = this.6C727377;
		long num3 = (long)this.107A346B;
		num = 1938322585U / num;
		int result = Marshal.ReadInt32(new IntPtr(num2 + num3));
		num = 1991145995U + num;
		num ^= 561715238U;
		int num4 = this.107A346B;
		num += 715727612U;
		this.107A346B = num4 + (int)(num ^ 2189329698U);
		return result;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x000C7384 File Offset: 0x000C7384
	private long 6BE55D80()
	{
		long num = this.6C727377;
		long num2 = (long)this.107A346B;
		uint num3 = 904086283U;
		IntPtr ptr = new IntPtr(num + num2);
		num3 = 883779413U - num3;
		long result = Marshal.ReadInt64(ptr);
		num3 = 260838449U - num3;
		int num4 = this.107A346B;
		int num5 = (int)(num3 - 281145311U);
		num3 >>= 27;
		this.107A346B = num4 + num5;
		return result;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x000C73DC File Offset: 0x000C73DC
	private float 01DC17F4()
	{
		byte[] bytes = BitConverter.GetBytes(this.074259D8());
		uint num = 1453474302U;
		int startIndex = (int)(num - 1453474302U);
		num = 1361271678U / num;
		return BitConverter.ToSingle(bytes, startIndex);
	}

	// Token: 0x06000109 RID: 265 RVA: 0x000C7410 File Offset: 0x000C7410
	private double 40176C9C()
	{
		uint num = 1100617529U;
		long value = this.6BE55D80();
		num = 1248724144U + num;
		byte[] bytes = BitConverter.GetBytes(value);
		num &= 939197723U;
		int startIndex = (int)(num - 67633417U);
		num -= 187892358U;
		return BitConverter.ToDouble(bytes, startIndex);
	}

	// Token: 0x0600010A RID: 266 RVA: 0x000C7454 File Offset: 0x000C7454
	private void 0BB14632()
	{
		uint num = 1127030260U;
		for (;;)
		{
			IL_06:
			num = 820654999U * num;
			byte b = this.44376D54();
			num %= 1115891436U;
			byte b2 = b;
			num ^= 218044318U;
			for (;;)
			{
				num <<= 23;
				int num2 = this.074259D8();
				num -= 387922835U;
				int num3 = num2;
				int num4 = this.074259D8();
				num = (1909208606U & num);
				int num5 = num4;
				int num6 = this.074259D8();
				num <<= 10;
				int num7 = num6;
				num &= 436020283U;
				if (num < 688194045U)
				{
					num = 762995084U + num;
					int num8 = this.074259D8();
					num <<= 11;
					int num9 = num8;
					if (num >> 15 != 0U)
					{
						0B005140.11482F88 11482F = null;
						num = 1686385446U + num;
						0B005140.11482F88 11482F2 = 11482F;
						num = (243294303U ^ num);
						int num10 = (int)(num ^ 3054564217U);
						0B005140.11482F88 11482F4;
						for (;;)
						{
							int num11 = num10;
							num = (983923115U | num);
							if (num11 >= this.4E1277A9.Count)
							{
								goto Block_6;
							}
							0B005140.11482F88 11482F3 = this.4E1277A9[num10];
							num = 460801033U;
							11482F4 = 11482F3;
							0B005140.11482F88 11482F5 = 11482F4;
							num = (2068343935U | num);
							int num12 = 11482F5.4BB56715();
							num *= 1678518286U;
							int num13 = num3;
							num = 666061133U - num;
							if (num12 == num13)
							{
								num &= 1548367499U;
								if (152588923U / num != 0U)
								{
									goto IL_06;
								}
								int num14 = 11482F4.072C4A6E();
								num &= 2125887636U;
								int num15 = num5;
								num = 775366415U % num;
								num ^= 3856966996U;
								if (num14 == num15)
								{
									goto Block_5;
								}
							}
							num10 += (int)(num ^ 3419636314U);
							num += 3929895198U;
						}
						IL_171:
						if ((num ^ 700581613U) == 0U)
						{
							continue;
						}
						bool flag = 11482F2 != null;
						num >>= 30;
						if (!flag)
						{
							num = 1421088509U - num;
							bool flag2 = num + 2873878788U != 0U;
							num <<= 16;
							bool flag3 = flag2;
							num *= 1541550505U;
							int 554A53A = num3;
							num >>= 16;
							11482F2 = new 0B005140.11482F88(554A53A, num5);
							num -= 1058079478U;
							int num16 = (int)(num - 3236914534U);
							num = 423511720U - num;
							int num17 = num16;
							if (459701114U < num)
							{
								for (;;)
								{
									int num18 = num17;
									num = 1485439181U << (int)num;
									if (num18 >= this.4E1277A9.Count)
									{
										goto Block_11;
									}
									num = 1830371152U;
									num = 1824394087U + num;
									List<0B005140.11482F88> list = this.4E1277A9;
									num = 271210721U * num;
									0B005140.11482F88 52533AA = list[num17];
									num = 2120235103U * num;
									int num19 = 11482F2.6787274E(52533AA);
									num = 170202627U + num;
									uint num20 = num ^ 1947048908U;
									num = 1380478912U + num;
									if (num19 < num20)
									{
										goto Block_10;
									}
									num *= 852383941U;
									int num21 = num17;
									int num22 = (int)(num + 690552133U);
									num = 1304108279U - num;
									num17 = num21 + num22;
									num += 3781871367U;
								}
								IL_2B0:
								num /= 900821625U;
								bool flag4 = flag3;
								num += 1U;
								if (!flag4)
								{
									num -= 478563233U;
									num += 1149645856U;
									this.4E1277A9.Add(11482F2);
									num ^= 671082625U;
									goto IL_2EB;
								}
								goto IL_2EB;
								Block_11:
								num ^= 1646789428U;
								goto IL_2B0;
								Block_10:
								num = 1708207022U * num;
								this.4E1277A9.Insert(num17, 11482F2);
								num = 1632313653U / num;
								flag3 = (num + 1U != 0U);
								goto IL_2B0;
							}
							continue;
						}
						IL_2EB:
						num *= 1375931963U;
						0B005140.11482F88 11482F6 = 11482F2;
						num <<= 0;
						byte 00B6022F = b2;
						int <<EMPTY_NAME>> = num7;
						num -= 249309673U;
						int 0E3A4AC = num9;
						num = 1185874776U % num;
						11482F6.7FB3588B(00B6022F, <<EMPTY_NAME>>, 0E3A4AC);
						if (num * 999509053U != 0U)
						{
							return;
						}
						continue;
						Block_6:
						num ^= 3692164099U;
						goto IL_171;
						Block_5:
						0B005140.11482F88 11482F7 = 11482F4;
						num -= 1764717155U;
						11482F2 = 11482F7;
						goto IL_171;
					}
				}
			}
		}
	}

	// Token: 0x0600010B RID: 267 RVA: 0x000C7784 File Offset: 0x000C7784
	private TypeCode 7E6151EB(0B005140.124B6895 02C0585D, 0B005140.124B6895 08757E11)
	{
		TypeCode typeCode;
		uint num;
		TypeCode typeCode3;
		for (;;)
		{
			IL_00:
			typeCode = 02C0585D.08177016();
			num = 1205090519U;
			if (num * 1929976302U != 0U)
			{
				goto IL_19;
			}
			IL_36:
			TypeCode typeCode2 = typeCode;
			num &= 173751950U;
			uint num2 = num ^ 134217729U;
			num = 143735968U % num;
			num += 1743700832U;
			if (typeCode2 == num2)
			{
				goto IL_A4;
			}
			num <<= 17;
			for (;;)
			{
				bool flag = typeCode3 != TypeCode.Empty;
				num <<= 1;
				num ^= 1753219072U;
				if (!flag)
				{
					goto IL_A4;
				}
				num = 335420808U >> (int)num;
				uint num3 = (uint)typeCode3;
				num = 894846997U - num;
				if (num3 == (num ^ 559426188U))
				{
					goto Block_2;
				}
				uint num4 = (uint)typeCode;
				num = (1550334173U ^ num);
				if (num4 == num + 2194664890U)
				{
					break;
				}
				num = 347569731U * num;
				if (1016740009U != num)
				{
					uint num5 = (uint)typeCode3;
					num = (424805190U | num);
					if (num5 != (num ^ 3688508412U))
					{
						goto IL_14E;
					}
					if (num == 431578933U)
					{
						goto IL_00;
					}
					if (typeCode != (TypeCode)(num ^ 3688508415U))
					{
						goto Block_9;
					}
					num <<= 26;
					if (1999204065U != num)
					{
						return typeCode3;
					}
				}
			}
			num = 337578673U >> (int)num;
			if (num <= 677403163U)
			{
				goto Block_4;
			}
			continue;
			IL_14E:
			uint num6 = (uint)typeCode;
			num += 1386299856U;
			if (num6 == num - 779840954U)
			{
				num *= 1151994956U;
				if (999647622U + num != 0U)
				{
					TypeCode typeCode4 = typeCode3;
					num = 19283339U % num;
					uint num7 = num ^ 19283330U;
					num = 2009168113U >> (int)num;
					if (typeCode4 != num7)
					{
						num = 609315596U + num;
						if (num > 741373004U)
						{
							continue;
						}
						TypeCode typeCode5 = typeCode3;
						uint num8 = num ^ 610296624U;
						num &= 1489575929U;
						num += 4291753206U;
						if (typeCode5 != num8)
						{
							goto Block_15;
						}
					}
					num /= 1848194555U;
					if (1957693741U - num != 0U)
					{
						return typeCode;
					}
					continue;
				}
			}
			else
			{
				uint num9 = (uint)typeCode3;
				num <<= 8;
				if (num9 == (num ^ 2070791692U))
				{
					goto Block_17;
				}
				if (2056407931U >= num)
				{
					goto IL_19;
				}
				TypeCode typeCode6 = typeCode;
				num &= 1103567360U;
				uint num10 = num ^ 1095041550U;
				num = (928603706U ^ num);
				if (typeCode6 == num10)
				{
					goto IL_296;
				}
				TypeCode typeCode7 = typeCode3;
				uint num11 = num - 1981570092U;
				num /= 878729267U;
				if (typeCode7 == num11)
				{
					goto Block_22;
				}
				num /= 1930849847U;
				TypeCode typeCode8 = typeCode;
				num >>= 24;
				uint num12 = num ^ 13U;
				num /= 1033179233U;
				if (typeCode8 == num12)
				{
					goto IL_2D8;
				}
				if (typeCode3 == (int)num + TypeCode.Single)
				{
					goto Block_24;
				}
				if (typeCode == (int)num + TypeCode.Int64)
				{
					goto IL_31D;
				}
				if (76107604U > num)
				{
					goto Block_26;
				}
				continue;
			}
			IL_30:
			if (typeCode != TypeCode.Empty)
			{
				goto IL_36;
			}
			goto IL_A4;
			IL_19:
			TypeCode typeCode9 = 08757E11.08177016();
			num <<= 20;
			typeCode3 = typeCode9;
			num *= 1839793336U;
			goto IL_30;
		}
		Block_2:
		num ^= 1238903437U;
		IL_A4:
		return (TypeCode)(num ^ 1753219072U);
		Block_4:
		if (typeCode3 != (TypeCode)(num ^ 5142U))
		{
			return (TypeCode)(num ^ 5151U);
		}
		return typeCode;
		Block_9:
		return (int)num + (TypeCode)606458890;
		Block_15:
		return (TypeCode)(num ^ 981039U);
		Block_17:
		num = (1578850832U ^ num);
		uint num13 = (uint)typeCode;
		num *= 1588205363U;
		if (num13 != num + 1589213401U)
		{
			num = (1448765611U ^ num);
			TypeCode typeCode10 = typeCode;
			num = (1356808261U | num);
			uint num14 = num - 4158648276U;
			num += 2842072913U;
			if (typeCode10 != num14)
			{
				num -= 1714829144U;
				return (TypeCode)(num ^ 990924760U);
			}
		}
		return typeCode;
		Block_22:
		num += 1981570104U;
		IL_296:
		return (TypeCode)(num ^ 1981570100U);
		Block_24:
		num ^= 0U;
		IL_2D8:
		num <<= 30;
		return (TypeCode)(num ^ 13U);
		Block_26:
		uint num15 = (uint)typeCode3;
		num *= 547060734U;
		if (num15 != (num ^ 11U))
		{
			return (int)num + TypeCode.Int32;
		}
		num += 0U;
		IL_31D:
		num -= 1719761480U;
		return (int)num + (TypeCode)1719761491;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x000C7AC8 File Offset: 0x000C7AC8
	private unsafe 0B005140.124B6895 097918FD(0B005140.124B6895 0180289E, 0B005140.124B6895 44730D13, bool 2FC51F2C, bool 22F5584E)
	{
		uint num;
		TypeCode typeCode2;
		int num9;
		int num11;
		long value;
		int num35;
		long num42;
		long num44;
		double num46;
		double num47;
		int num48;
		for (;;)
		{
			IL_00:
			num = 1839863111U;
			num %= 1086615826U;
			num = 1454076352U + num;
			TypeCode typeCode = this.7E6151EB(0180289E, 44730D13);
			num <<= 1;
			typeCode2 = typeCode;
			for (;;)
			{
				object obj = typeCode2;
				object obj2 = num + 4175287327U;
				num = (86130564U & num);
				object obj3 = obj - obj2;
				num /= 834043150U;
				switch (obj3)
				{
				case 0:
					goto IL_7D;
				case 1:
					num <<= 31;
					if (22F5584E)
					{
						num += 1554732978U;
						uint num2 = 0180289E.49390C3B();
						num = (41768745U | num);
						uint num3 = num2;
						num = 209519353U - num;
						if ((351625158U ^ num) == 0U)
						{
							goto IL_00;
						}
						uint num4 = 44730D13.49390C3B();
						num <<= 14;
						uint num5 = num4;
						num = (1947023868U ^ num);
						int num7;
						if (!2FC51F2C)
						{
							num = 1996389225U >> (int)num;
							int num6 = (int)num3;
							num /= 344015559U;
							num7 = num6 + (int)num5;
						}
						else
						{
							num = 1684622645U >> (int)num;
							if (num > 309424333U)
							{
								goto IL_00;
							}
							int num8 = (int)num3;
							num = (183699118U | num);
							num7 = checked(num8 + (int)num5);
							num += 4111268178U;
						}
						num += 1463303408U;
						num9 = num7;
						if (1310602569U != num)
						{
							goto Block_34;
						}
						goto IL_7D;
					}
					else
					{
						num = 391842229U * num;
						if (2092589517U < num)
						{
							goto IL_00;
						}
						num >>= 25;
						int num10 = 0180289E.DCFDB33F();
						num >>= 27;
						num11 = num10;
						num = 2086889797U - num;
						if (1365604072U <= num)
						{
							goto Block_36;
						}
					}
					break;
				case 2:
					num = (1053126477U | num);
					num -= 781591435U;
					if (22F5584E)
					{
						ulong num12 = 0180289E.6DD020CC();
						num = 160190729U / num;
						ulong num13 = num12;
						num = 1220895962U >> (int)num;
						ulong num14 = 44730D13.6DD020CC();
						if (num > 395201462U)
						{
							goto Block_11;
						}
						continue;
					}
					else
					{
						if (num < 1492610548U)
						{
							goto Block_13;
						}
						continue;
					}
					break;
				case 3:
					num = (776034591U & num);
					if (num * 955403224U != 0U)
					{
						goto IL_00;
					}
					if (22F5584E)
					{
						num = 722093241U + num;
						if (71261054U == num)
						{
							goto IL_00;
						}
						ulong num15 = 0180289E.6DD020CC();
						if (1588746778U == num)
						{
							continue;
						}
						ulong num16 = 44730D13.6DD020CC();
						if (num == 299181620U)
						{
							continue;
						}
						long num17;
						if (!2FC51F2C)
						{
							num = 2088309265U % num;
							if (2065521906U - num == 0U)
							{
								goto IL_00;
							}
							num17 = (long)(num15 + num16);
						}
						else
						{
							if (1439501136U <= num)
							{
								goto IL_78;
							}
							long num18 = (long)num15;
							long num19 = (long)num16;
							num <<= 28;
							num17 = checked(num18 + num19);
							num += 2523170975U;
						}
						num = 1532363171U - num;
						value = num17;
						if (652966045U == num)
						{
							goto IL_00;
						}
					}
					else
					{
						if (1265505407U == num)
						{
							continue;
						}
						num |= 904680173U;
						long num20 = 0180289E.EB2B8B0E();
						if (num == 112998240U)
						{
							goto IL_78;
						}
						long num21 = 44730D13.EB2B8B0E();
						num = 686385672U - num;
						long num22 = num21;
						if ((2086685813U ^ num) == 0U)
						{
							continue;
						}
						num = (1893287076U ^ num);
						long num24;
						if (!2FC51F2C)
						{
							num >>= 24;
							long num23 = num20;
							num *= 765531740U;
							num24 = num23 + num22;
						}
						else
						{
							num = 1243294382U >> (int)num;
							num24 = checked(num20 + num22);
							num ^= 734878392U;
						}
						num = 1687963690U % num;
						value = num24;
						num += 670033482U;
					}
					if (1671443148U < num)
					{
						goto IL_8E;
					}
					if (0180289E.08177016() == typeCode2)
					{
						goto IL_927;
					}
					num = (2122201974U | num);
					if ((916006825U ^ num) != 0U)
					{
						goto Block_56;
					}
					continue;
				case 4:
				{
					0B005140.124B6895 124B;
					if (!22F5584E)
					{
						num = 322186365U * num;
						124B = 0180289E;
					}
					else
					{
						num = 1624133212U >> (int)num;
						124B = 0180289E.3D08BB82();
						num ^= 1624133212U;
					}
					float num25 = 124B.84027CE6();
					num ^= 1025115101U;
					0B005140.124B6895 124B2;
					if (!22F5584E)
					{
						if (1292183922U + num == 0U)
						{
							goto IL_00;
						}
						124B2 = 44730D13;
					}
					else
					{
						124B2 = 44730D13.3D08BB82();
						num += 0U;
					}
					float num26 = 124B2.84027CE6();
					num |= 1047472831U;
					float num27 = num26;
					if (126577121U + num != 0U)
					{
						goto Block_21;
					}
					continue;
				}
				case 5:
					if (367467788U + num == 0U)
					{
						goto IL_78;
					}
					num = (2008309824U ^ num);
					if (!22F5584E)
					{
						goto Block_24;
					}
					if (1352950578U < num)
					{
						goto Block_25;
					}
					break;
				default:
					if (num / 1784305255U == 0U)
					{
						goto IL_78;
					}
					continue;
				}
				IL_AA:
				uint num28 = 44730D13.49390C3B();
				num = 1324366903U >> (int)num;
				if ((num & 120347404U) != 0U)
				{
					continue;
				}
				num /= 78252860U;
				uint num30;
				int num32;
				if (!2FC51F2C)
				{
					num = (91446439U | num);
					if (365037685U >> (int)num == 0U)
					{
						goto IL_00;
					}
					int num29 = (int)num30;
					int num31 = (int)num28;
					num >>= 18;
					num32 = num29 + num31;
				}
				else
				{
					if (num << 13 != 0U)
					{
						goto IL_00;
					}
					int num33 = (int)num30;
					int num34 = (int)num28;
					num -= 682571512U;
					num32 = checked(num33 + num34);
					num += 682571860U;
				}
				num35 = num32;
				if (1680045974U - num != 0U)
				{
					break;
				}
				continue;
				IL_8E:
				num %= 95647247U;
				num30 = 0180289E.49390C3B();
				num |= 1204105949U;
				goto IL_AA;
				IL_7D:
				num = (1811485671U | num);
				if (22F5584E)
				{
					goto IL_8E;
				}
				num = 150037508U + num;
				if (980313763U % num != 0U)
				{
					goto Block_6;
				}
			}
			IL_1FC:
			num = 1887394785U / num;
			if (num < 1168145476U)
			{
				goto Block_9;
			}
			continue;
			Block_6:
			num = 151919301U % num;
			int num36 = 0180289E.DCFDB33F();
			if (801401708U == num)
			{
				break;
			}
			num = 429678700U << (int)num;
			int num37 = 44730D13.DCFDB33F();
			num <<= 24;
			int num40;
			if (!2FC51F2C)
			{
				num ^= 750536841U;
				int num38 = num36;
				num -= 1143372660U;
				int num39 = num37;
				num ^= 468320854U;
				num40 = num38 + num39;
			}
			else
			{
				int num41 = num36;
				num = (1059722871U ^ num);
				num40 = checked(num41 + num37);
				num += 3025516748U;
			}
			num += 966468818U;
			num35 = num40;
			num ^= 2904225097U;
			goto IL_1FC;
			Block_13:
			num42 = 0180289E.EB2B8B0E();
			if (1906905450U <= num)
			{
				continue;
			}
			num = 1542871481U - num;
			long num43 = 44730D13.EB2B8B0E();
			num -= 1955799475U;
			num44 = num43;
			if (!2FC51F2C)
			{
				if (num + 1129413114U != 0U)
				{
					goto Block_16;
				}
				continue;
			}
			else
			{
				if (num * 1480470453U != 0U)
				{
					goto Block_17;
				}
				continue;
			}
			IL_478:
			0B005140.124B6895 124B3;
			double num45 = 124B3.BD97D382();
			num %= 94706031U;
			num46 = num45;
			num >>= 9;
			0B005140.124B6895 124B4;
			if (!22F5584E)
			{
				num = 1138054458U + num;
				124B4 = 44730D13;
			}
			else
			{
				124B4 = 44730D13.3D08BB82();
				num ^= 1138143038U;
			}
			num47 = 124B4.BD97D382();
			num = (1846353750U & num);
			if (num > 1787694359U)
			{
				break;
			}
			if (2FC51F2C)
			{
				goto IL_50C;
			}
			num |= 260445298U;
			if (775431266U + num != 0U)
			{
				goto Block_29;
			}
			continue;
			Block_25:
			124B3 = 0180289E.3D08BB82();
			num ^= 1890861120U;
			goto IL_478;
			Block_24:
			num = (117581859U & num);
			124B3 = 0180289E;
			goto IL_478;
			Block_36:
			num = 1042437431U % num;
			num48 = 44730D13.DCFDB33F();
			num = 1619084146U + num;
			num /= 1820003236U;
			if (!2FC51F2C)
			{
				if (num < 2036007199U)
				{
					goto Block_38;
				}
			}
			else if ((num ^ 1351619015U) != 0U)
			{
				goto Block_39;
			}
		}
		IL_78:
		num = (997293839U | num);
		throw new InvalidOperationException();
		Block_9:
		int 0D6B27B = num35;
		num -= 9907885U;
		return new 0B005140.07685083(0D6B27B);
		Block_11:
		num -= 1181114357U;
		long num49;
		if (!2FC51F2C)
		{
			num = (930767393U | num);
			ulong num13;
			ulong num14;
			num49 = (long)(num13 + num14);
		}
		else
		{
			num = 118234057U / num;
			ulong num13;
			ulong num14;
			num49 = (long)(checked(num13 + num14));
			num += 931096291U;
		}
		long <<EMPTY_NAME>> = num49;
		goto IL_34D;
		Block_16:
		long num50 = num42;
		num *= 312766431U;
		long num51 = num44;
		num = 572588466U - num;
		long num52 = num50 + num51;
		goto IL_341;
		Block_17:
		num52 = checked(num42 + num44);
		num += 766560818U;
		IL_341:
		<<EMPTY_NAME>> = num52;
		num ^= 865849491U;
		IL_34D:
		return new 0B005140.13AF7E46(<<EMPTY_NAME>>);
		Block_21:
		float 474F1D1D;
		if (!2FC51F2C)
		{
			float num25;
			float num27;
			474F1D1D = num25 + num27;
		}
		else
		{
			num = 1945841086U << (int)num;
			float num25;
			float num53 = num25;
			num |= 404318454U;
			float num27;
			float num54 = num27;
			num /= 1397428278U;
			474F1D1D = num53 + num54;
			num ^= 1065298943U;
		}
		return new 0B005140.721F5C60(474F1D1D);
		Block_29:
		double num55 = num46;
		num = 116021168U >> (int)num;
		double 702B = num55 + num47;
		goto IL_524;
		IL_50C:
		double num56 = num46;
		double num57 = num47;
		num %= 774318260U;
		702B = num56 + num57;
		num ^= 333240699U;
		IL_524:
		return new 0B005140.6B6D1F66(702B);
		Block_34:
		goto IL_6CC;
		Block_38:
		int num58 = num11;
		int num59 = num48;
		num += 649822175U;
		int num60 = num58 + num59;
		goto IL_6B6;
		Block_39:
		num60 = checked(num11 + num48);
		num += 649822175U;
		IL_6B6:
		num = (1600982197U | num);
		num9 = num60;
		num ^= 684147461U;
		IL_6CC:
		TypeCode typeCode3 = 0180289E.08177016();
		num = 1506285739U - num;
		0B005140.03371198 2;
		if (typeCode3 != typeCode2)
		{
			num = 1757812894U / num;
			num = (1791824721U | num);
			2 = (0B005140.03371198)44730D13;
		}
		else
		{
			num = 964120950U % num;
			2 = (0B005140.03371198)0180289E;
			num ^= 1809284125U;
		}
		0B005140.03371198 3 = 2;
		int value2 = num9;
		num = 1968578171U % num;
		IntPtr intPtr = new IntPtr(value2);
		num = 1633119236U << (int)num;
		IntPtr intPtr2 = intPtr;
		num <<= 20;
		void* ptr = intPtr2.ToPointer();
		num = (972710792U ^ num);
		object 019B20B = Pointer.Box(ptr, 3.0E8448DC());
		0B005140.03371198 4 = 3;
		num = (1698176209U | num);
		return new 0B005140.03371198(019B20B, 4.0E8448DC());
		Block_56:
		0B005140.03371198 5 = (0B005140.03371198)44730D13;
		goto IL_941;
		IL_927:
		num += 1086223853U;
		5 = (0B005140.03371198)0180289E;
		num += 156208261U;
		IL_941:
		0B005140.03371198 6 = 5;
		void* ptr2 = new IntPtr(value).ToPointer();
		num = 774730860U / num;
		0B005140.03371198 7 = 6;
		num = 147611137U - num;
		object 019B20B2 = Pointer.Box(ptr2, 7.0E8448DC());
		Type 255177ED = 6.0E8448DC();
		num = 1591943299U / num;
		return new 0B005140.03371198(019B20B2, 255177ED);
	}

	// Token: 0x0600010D RID: 269 RVA: 0x000C8470 File Offset: 0x000C8470
	private unsafe 0B005140.124B6895 21D71344(0B005140.124B6895 1212438F, 0B005140.124B6895 0E2E5EBB, bool 32C920AF, bool 273A3791)
	{
		uint num;
		TypeCode typeCode;
		long <<EMPTY_NAME>>;
		long num29;
		uint num40;
		uint num42;
		float num43;
		float num44;
		int value;
		0B005140.03371198 3;
		for (;;)
		{
			IL_00:
			num = 1465327683U;
			typeCode = this.7E6151EB(1212438F, 0E2E5EBB);
			num = (1399404277U & num);
			if ((num ^ 735665902U) != 0U)
			{
				uint num4;
				uint num5;
				int num7;
				int num9;
				for (;;)
				{
					TypeCode typeCode2 = typeCode;
					uint num2 = num ^ 1396777032U;
					num *= 1496989068U;
					switch (typeCode2 - num2)
					{
					case 0:
						goto IL_5F;
					case 1:
						num = 421807855U % num;
						if (273A3791)
						{
							if (num > 1553601804U)
							{
								goto IL_00;
							}
							uint num3 = 1212438F.49390C3B();
							num = (404323569U | num);
							num4 = num3;
							num <<= 5;
							if (num == 1576145877U)
							{
								goto IL_00;
							}
							num5 = 0E2E5EBB.49390C3B();
							if (1217857652U < num)
							{
								goto IL_00;
							}
							num <<= 9;
							if (!32C920AF)
							{
								goto Block_31;
							}
							num &= 19666041U;
							if (num != 1192370808U)
							{
								goto Block_32;
							}
						}
						else
						{
							num ^= 429983395U;
							if (num > 510938453U)
							{
								goto IL_00;
							}
							num |= 1386484791U;
							int num6 = 1212438F.DCFDB33F();
							num /= 947718442U;
							num7 = num6;
							if (num + 1300782296U == 0U)
							{
								goto IL_00;
							}
							int num8 = 0E2E5EBB.DCFDB33F();
							num = (1819158791U | num);
							num9 = num8;
							num ^= 458910174U;
							if (num <= 1679625909U)
							{
								goto IL_00;
							}
							if (32C920AF)
							{
								goto IL_6DA;
							}
							num = 526530426U - num;
							if (num != 620174662U)
							{
								goto Block_38;
							}
							goto IL_C7;
						}
						break;
					case 2:
						num -= 1576293187U;
						num = (236468149U & num);
						if (273A3791)
						{
							if (num / 320808030U != 0U)
							{
								goto IL_5F;
							}
							ulong num10 = 1212438F.6DD020CC();
							num = 1625428338U / num;
							ulong num11 = num10;
							num <<= 9;
							num = (214839133U | num);
							ulong num12 = 0E2E5EBB.6DD020CC();
							num *= 1132929999U;
							num *= 628177107U;
							long num15;
							if (!32C920AF)
							{
								long num13 = (long)num11;
								long num14 = (long)num12;
								num = 1884256237U - num;
								num15 = num13 - num14;
							}
							else
							{
								if ((num ^ 1748660626U) == 0U)
								{
									goto IL_AD;
								}
								long num16 = (long)num11;
								num = (685337600U & num);
								num15 = checked(num16 - (long)num12);
								num += 1543296228U;
							}
							num = (1879838170U ^ num);
							<<EMPTY_NAME>> = num15;
							if ((num ^ 1780174417U) == 0U)
							{
								continue;
							}
						}
						else
						{
							if (956903284U <= num)
							{
								goto IL_00;
							}
							num = 732188091U * num;
							long num17 = 1212438F.EB2B8B0E();
							num = 1373204253U + num;
							long num18 = 0E2E5EBB.EB2B8B0E();
							num -= 1037642502U;
							long num19 = num18;
							num = 1877751031U % num;
							long num22;
							if (!32C920AF)
							{
								long num20 = num17;
								long num21 = num19;
								num = 1716193034U >> (int)num;
								num22 = num20 - num21;
							}
							else
							{
								num22 = checked(num17 - num19);
								num += 2417216469U;
							}
							num >>= 23;
							<<EMPTY_NAME>> = num22;
							num += 739889470U;
						}
						num = (1873554506U & num);
						if (num < 1154550545U)
						{
							goto Block_13;
						}
						continue;
					case 3:
						num <<= 23;
						num ^= 962555698U;
						if (273A3791)
						{
							num = 1769083639U * num;
							num = 1921136967U % num;
							ulong num23 = 1212438F.6DD020CC();
							num %= 816202194U;
							ulong num24 = 0E2E5EBB.6DD020CC();
							num = 402740914U % num;
							long num27;
							if (!32C920AF)
							{
								long num25 = (long)num23;
								long num26 = (long)num24;
								num = 1196580341U / num;
								num27 = num25 - num26;
							}
							else
							{
								if (num > 864956183U)
								{
									goto IL_00;
								}
								long num28 = (long)num23;
								num >>= 5;
								num27 = checked(num28 - (long)num24);
								num ^= 3562754U;
							}
							num29 = num27;
						}
						else
						{
							num += 1288067458U;
							if (2092306796 << (int)num == 0)
							{
								continue;
							}
							num = (1895703755U | num);
							long num30 = 1212438F.EB2B8B0E();
							num -= 1858233944U;
							long num31 = num30;
							num += 574767666U;
							long num32 = 0E2E5EBB.EB2B8B0E();
							num = 446787923U - num;
							long num33 = num32;
							if (661873324U == num)
							{
								break;
							}
							num ^= 1707952430U;
							long num35;
							if (!32C920AF)
							{
								num = (567559408U & num);
								long num34 = num31;
								num -= 1132555349U;
								num35 = num34 - num33;
							}
							else
							{
								num = (376649373U | num);
								if (num == 344146756U)
								{
									continue;
								}
								long num36 = num31;
								num = 1259106127U >> (int)num;
								long num37 = num33;
								num ^= 1072847060U;
								num35 = checked(num36 - num37);
								num ^= 2175830829U;
							}
							num29 = num35;
							num += 1102916623U;
						}
						num ^= 1202213589U;
						if (570778254 << (int)num == 0)
						{
							goto Block_49;
						}
						break;
					case 4:
						if (273A3791)
						{
							goto IL_376;
						}
						num = 1171739371U >> (int)num;
						if ((1837712382U ^ num) != 0U)
						{
							goto Block_15;
						}
						break;
					case 5:
					{
						num &= 1738571370U;
						0B005140.124B6895 124B;
						if (!273A3791)
						{
							num <<= 26;
							if (327961759U > num)
							{
								goto IL_00;
							}
							124B = 1212438F;
						}
						else
						{
							num &= 1842446144U;
							124B = 1212438F.3D08BB82();
							num ^= 1140858880U;
						}
						num = 580404368U * num;
						double num38 = 124B.BD97D382();
						num = 1213024943U << (int)num;
						double num39 = num38;
						num = 1318013704U % num;
						if (!273A3791)
						{
							goto Block_24;
						}
						if (num + 1905684823U != 0U)
						{
							goto Block_25;
						}
						goto IL_5F;
					}
					}
					IL_5A:
					num /= 555229260U;
					if ((1566256773U ^ num) != 0U)
					{
						goto Block_51;
					}
					continue;
					IL_C7:
					num = (2131504532U | num);
					if (!32C920AF)
					{
						break;
					}
					num <<= 11;
					if ((1536253473U ^ num) != 0U)
					{
						goto Block_4;
					}
					goto IL_5A;
					IL_AD:
					num40 = 0E2E5EBB.49390C3B();
					if (1621762871U >> (int)num != 0U)
					{
						goto IL_C7;
					}
					goto IL_00;
					IL_5F:
					num |= 1363376258U;
					if (!273A3791)
					{
						goto IL_133;
					}
					num = (1528309171U & num);
					if (num * 342696741U != 0U)
					{
						num -= 1940534099U;
						uint num41 = 1212438F.49390C3B();
						num += 1436749430U;
						num42 = num41;
						num = 639770412U + num;
						goto IL_AD;
					}
					goto IL_00;
				}
				num = (330398352U & num);
				if (num - 1266114970U != 0U)
				{
					break;
				}
				continue;
				IL_376:
				num /= 623257622U;
				if (1181497637U >> (int)num == 0U)
				{
					continue;
				}
				num -= 504039693U;
				0B005140.124B6895 124B2 = 1212438F.3D08BB82();
				num ^= 3790646156U;
				IL_3AD:
				num = 1241740208U << (int)num;
				num43 = 124B2.84027CE6();
				num = 1944747432U + num;
				num ^= 1866166264U;
				0B005140.124B6895 124B3;
				if (!273A3791)
				{
					if (1098732796U >= num)
					{
						continue;
					}
					124B3 = 0E2E5EBB;
				}
				else
				{
					num = (1273311865U | num);
					num = (1615212780U & num);
					124B3 = 0E2E5EBB.3D08BB82();
					num += 1183637992U;
				}
				num = 464223590U >> (int)num;
				num44 = 124B3.84027CE6();
				num |= 563091446U;
				if (num <= 460658864U)
				{
					continue;
				}
				num *= 762072239U;
				if (32C920AF)
				{
					goto IL_482;
				}
				num = 174921365U << (int)num;
				if (965613344U >= num)
				{
					goto Block_21;
				}
				continue;
				Block_15:
				124B2 = 1212438F;
				goto IL_3AD;
				IL_639:
				int num45;
				value = num45;
				if ((1642756795U ^ num) != 0U)
				{
					goto IL_6FF;
				}
				continue;
				Block_32:
				int num46 = (int)num4;
				num = (1784573547U ^ num);
				num45 = checked(num46 - (int)num5);
				num += 4098707861U;
				goto IL_639;
				Block_31:
				num45 = (int)(num4 - num5);
				goto IL_639;
				IL_6FF:
				num = (47405288U & num);
				0B005140.03371198 2;
				if (1212438F.08177016() != typeCode)
				{
					num <<= 16;
					if (num > 1808008285U)
					{
						continue;
					}
					2 = (0B005140.03371198)0E2E5EBB;
				}
				else
				{
					2 = (0B005140.03371198)1212438F;
					num ^= 1116946432U;
				}
				3 = 2;
				num = 1506019035U << (int)num;
				if (1981376472U >= num)
				{
					goto Block_41;
				}
				continue;
				IL_6F3:
				int num47;
				value = num47;
				num ^= 4153554593U;
				goto IL_6FF;
				IL_6DA:
				int num48 = num7;
				num = 910851598U + num;
				num47 = checked(num48 - num9);
				num ^= 89344070U;
				goto IL_6F3;
				Block_38:
				num47 = num7 - num9;
				goto IL_6F3;
			}
		}
		int num49 = (int)(num42 - num40);
		goto IL_11C;
		Block_4:
		num49 = (int)(checked(num42 - num40));
		num += 420647568U;
		IL_11C:
		num = 1116684408U >> (int)num;
		int 0D6B27B = num49;
		goto IL_1CE;
		IL_133:
		num = 1948803463U * num;
		num = (1415205614U | num);
		int num50 = 1212438F.DCFDB33F();
		num = 1689911631U * num;
		int num51 = num50;
		num = 1066103905U << (int)num;
		num = 1207200045U % num;
		int num52 = 0E2E5EBB.DCFDB33F();
		int num53;
		if (!32C920AF)
		{
			num %= 1505314454U;
			num53 = num51 - num52;
		}
		else
		{
			int num54 = num51;
			num += 266677323U;
			int num55 = num52;
			num /= 1140793099U;
			num53 = checked(num54 - num55);
			num += 1207200044U;
		}
		num = 1527213392U * num;
		0D6B27B = num53;
		num += 2476489599U;
		IL_1CE:
		num = 2014599367U + num;
		return new 0B005140.07685083(0D6B27B);
		Block_13:
		return new 0B005140.13AF7E46(<<EMPTY_NAME>>);
		Block_21:
		float num56 = num43;
		num = 220929620U - num;
		float 474F1D1D = num56 - num44;
		goto IL_491;
		IL_482:
		474F1D1D = num43 - num44;
		num += 3530001155U;
		IL_491:
		num |= 1337264674U;
		return new 0B005140.721F5C60(474F1D1D);
		Block_24:
		0B005140.124B6895 124B4 = 0E2E5EBB;
		goto IL_54D;
		Block_25:
		num = 150145510U >> (int)num;
		124B4 = 0E2E5EBB.3D08BB82();
		num += 104988757U;
		IL_54D:
		num /= 346371193U;
		double num57 = 124B4.BD97D382();
		double 702B;
		if (!32C920AF)
		{
			num %= 1773758449U;
			double num39;
			702B = num39 - num57;
		}
		else
		{
			double num39;
			double num58 = num39;
			num %= 1814773223U;
			702B = num58 - num57;
			num ^= 0U;
		}
		return new 0B005140.6B6D1F66(702B);
		Block_41:
		void* ptr = new IntPtr(value).ToPointer();
		0B005140.03371198 4 = 3;
		num = 911760622U * num;
		Type type = 4.0E8448DC();
		num &= 701385329U;
		object 019B20B = Pointer.Box(ptr, type);
		num >>= 17;
		0B005140.03371198 5 = 3;
		num %= 1960192476U;
		return new 0B005140.03371198(019B20B, 5.0E8448DC());
		Block_49:
		TypeCode typeCode3 = 1212438F.08177016();
		num -= 404294524U;
		0B005140.03371198 6;
		if (typeCode3 != typeCode)
		{
			6 = (0B005140.03371198)0E2E5EBB;
		}
		else
		{
			num = 431043756U + num;
			num &= 736526191U;
			6 = (0B005140.03371198)1212438F;
			num += 642698068U;
		}
		num ^= 1759848886U;
		0B005140.03371198 7 = 6;
		long value2 = num29;
		num = 369827321U % num;
		object 019B20B2 = Pointer.Box(new IntPtr(value2).ToPointer(), 7.0E8448DC());
		num = 866006663U * num;
		return new 0B005140.03371198(019B20B2, 7.0E8448DC());
		Block_51:
		throw new InvalidOperationException();
	}

	// Token: 0x0600010E RID: 270 RVA: 0x000C8E6C File Offset: 0x000C8E6C
	private 0B005140.124B6895 447B6411(0B005140.124B6895 1C9465A2, 0B005140.124B6895 33A759BC, bool 540408C3, bool 0433778B)
	{
		uint num = 369563283U;
		int num20;
		long <<EMPTY_NAME>>;
		for (;;)
		{
			IL_07:
			TypeCode typeCode = this.7E6151EB(1C9465A2, 33A759BC);
			int num11;
			int num12;
			for (;;)
			{
				TypeCode typeCode2 = typeCode;
				num = (193142720U ^ num);
				uint num2 = num + 3799774902U;
				num |= 971518218U;
				switch (typeCode2 - num2)
				{
				case 0:
					break;
				case 1:
				case 3:
					goto IL_583;
				case 2:
					num -= 1858156942U;
					if (num % 292688176U == 0U)
					{
						continue;
					}
					if (0433778B)
					{
						if (num == 430525800U)
						{
							goto IL_07;
						}
						ulong num3 = 1C9465A2.6DD020CC();
						num /= 1652235330U;
						ulong num4 = num3;
						if (num <= 1654802393U)
						{
							goto Block_15;
						}
						continue;
					}
					else
					{
						num >>= 31;
						long num5 = 1C9465A2.EB2B8B0E();
						num = 486097578U / num;
						long num6 = num5;
						if ((num ^ 954341155U) == 0U)
						{
							goto IL_07;
						}
						long num7 = 33A759BC.EB2B8B0E();
						if ((793390199U ^ num) != 0U)
						{
							goto Block_21;
						}
						continue;
					}
					break;
				case 4:
					if (0433778B)
					{
						goto IL_377;
					}
					num = (441336606U ^ num);
					if (num < 801317433U)
					{
						goto Block_26;
					}
					continue;
				case 5:
				{
					num <<= 5;
					if (720527980U == num)
					{
						goto IL_07;
					}
					num = 1708600017U * num;
					0B005140.124B6895 124B;
					if (!0433778B)
					{
						124B = 1C9465A2;
					}
					else
					{
						num = 738546168U * num;
						124B = 1C9465A2.3D08BB82();
						num ^= 1833393248U;
					}
					num = (1331373397U & num);
					double num8 = 124B.BD97D382();
					num -= 556078381U;
					double num9 = num8;
					num &= 1727494948U;
					if ((num ^ 673270666U) == 0U)
					{
						continue;
					}
					if (!0433778B)
					{
						if (num - 1346452310U != 0U)
						{
							goto Block_34;
						}
						continue;
					}
					else
					{
						if (num != 2071855156U)
						{
							goto Block_35;
						}
						continue;
					}
					break;
				}
				default:
					if (num >= 97134928U)
					{
						goto Block_2;
					}
					break;
				}
				if (1188365003U % num != 0U)
				{
					num = 2086693479U * num;
					if (0433778B)
					{
						break;
					}
					num = 1391011936U + num;
					int num10 = 1C9465A2.DCFDB33F();
					num /= 1575686914U;
					num11 = num10;
					num12 = 33A759BC.DCFDB33F();
					num = (935146389U & num);
					if (540408C3)
					{
						goto IL_194;
					}
					if (1494907782U >> (int)num != 0U)
					{
						goto Block_9;
					}
				}
			}
			num >>= 14;
			num %= 2006913894U;
			uint num13 = 1C9465A2.49390C3B();
			num = (479223207U | num);
			if (696063842U / num == 0U)
			{
				continue;
			}
			IL_B7:
			num = (1414876921U ^ num);
			uint num14 = 33A759BC.49390C3B();
			num = 1413573046U % num;
			if ((num ^ 299438417U) == 0U)
			{
				continue;
			}
			int num16;
			if (!540408C3)
			{
				int num15 = (int)num13;
				num += 447574363U;
				num16 = num15 * (int)num14;
				goto IL_11D;
			}
			goto IL_FA;
			IL_33F:
			if (803306023U - num != 0U)
			{
				goto Block_24;
			}
			goto IL_B7;
			IL_194:
			int num19;
			if (614824463U / num != 0U)
			{
				int num17 = num11;
				num /= 276917873U;
				int num18 = num12;
				num &= 119880893U;
				num19 = checked(num17 * num18);
				num += 90920839U;
				goto IL_1C4;
			}
			goto IL_B7;
			IL_11D:
			num = 2122982035U * num;
			num20 = num16;
			if (1513387969U > num)
			{
				goto IL_1CF;
			}
			continue;
			IL_FA:
			int num21 = (int)num13;
			num = (159214637U & num);
			int num22 = (int)num14;
			num %= 574439588U;
			num16 = checked(num21 * num22);
			num ^= 794263963U;
			goto IL_11D;
			IL_583:
			if (943740114U <= num)
			{
				goto Block_37;
			}
			goto IL_FA;
			IL_1CF:
			if ((num & 1598952171U) != 0U)
			{
				break;
			}
			continue;
			IL_1C4:
			num20 = num19;
			num ^= 414391270U;
			goto IL_1CF;
			Block_9:
			int num23 = num11;
			int num24 = num12;
			num = (90920839U | num);
			num19 = num23 * num24;
			goto IL_1C4;
			Block_15:
			ulong num25 = 33A759BC.6DD020CC();
			num = (84294943U | num);
			long num28;
			if (!540408C3)
			{
				if (443966425U <= num)
				{
					continue;
				}
				ulong num4;
				long num26 = (long)num4;
				long num27 = (long)num25;
				num >>= 16;
				num28 = num26 * num27;
			}
			else
			{
				if ((1964077161U ^ num) == 0U)
				{
					continue;
				}
				ulong num4;
				num28 = (long)(checked(num4 * num25));
				num += 4210673639U;
			}
			num = 338647759U / num;
			<<EMPTY_NAME>> = num28;
			if (num <= 1656165228U)
			{
				goto IL_33F;
			}
			continue;
			Block_21:
			num = 1575053040U << (int)num;
			long num31;
			if (!540408C3)
			{
				long num6;
				long num29 = num6;
				long num7;
				long num30 = num7;
				num = (1327238880U & num);
				num31 = num29 * num30;
			}
			else
			{
				if (2111123542U == num)
				{
					continue;
				}
				long num6;
				long num32 = num6;
				long num7;
				long num33 = num7;
				num = 316606344U >> (int)num;
				num31 = checked(num32 * num33);
				num += 4063819896U;
			}
			<<EMPTY_NAME>> = num31;
			num += 4209771686U;
			goto IL_33F;
			IL_377:
			if (1590566018U > num)
			{
				goto Block_27;
			}
			continue;
			Block_2:
			num += 0U;
			goto IL_583;
		}
		int 0D6B27B = num20;
		num >>= 7;
		return new 0B005140.07685083(0D6B27B);
		Block_24:
		return new 0B005140.13AF7E46(<<EMPTY_NAME>>);
		Block_26:
		0B005140.124B6895 124B2 = 1C9465A2;
		goto IL_393;
		Block_27:
		124B2 = 1C9465A2.3D08BB82();
		num += 3921035498U;
		IL_393:
		float num34 = 124B2.84027CE6();
		num -= 639261584U;
		float num35 = num34;
		num = 239731637U - num;
		0B005140.124B6895 124B3;
		if (!0433778B)
		{
			124B3 = 33A759BC;
		}
		else
		{
			num = 1866217502U / num;
			124B3 = 33A759BC.3D08BB82();
			num ^= 214033672U;
		}
		num = (419704431U | num);
		float num36 = 124B3.84027CE6();
		num = 106639418U / num;
		num = 1334077595U + num;
		double num39;
		if (!540408C3)
		{
			num *= 1550724927U;
			double num37 = (double)num35;
			num >>= 26;
			double num38 = (double)num36;
			num = 2062886134U >> (int)num;
			num39 = num37 * num38;
		}
		else
		{
			num += 15022367U;
			num39 = (double)(num35 * num36);
			num ^= 1829974977U;
		}
		num = (1395939240U | num);
		return new 0B005140.6B6D1F66(num39);
		Block_34:
		0B005140.124B6895 124B4 = 33A759BC;
		goto IL_507;
		Block_35:
		124B4 = 33A759BC.3D08BB82();
		num ^= 0U;
		IL_507:
		num = (699432230U ^ num);
		double num40 = 124B4.BD97D382();
		num -= 1673402218U;
		double num41 = num40;
		num = 104671455U * num;
		double 702B;
		if (!540408C3)
		{
			num = 1964063564U % num;
			double num9;
			double num42 = num9;
			num = (192493380U ^ num);
			702B = num42 * num41;
		}
		else
		{
			num += 1365190648U;
			double num9;
			double num43 = num9;
			double num44 = num41;
			num = (115877147U ^ num);
			702B = num43 * num44;
			num ^= 679282607U;
		}
		num += 2102529872U;
		return new 0B005140.6B6D1F66(702B);
		Block_37:
		throw new InvalidOperationException();
	}

	// Token: 0x0600010F RID: 271 RVA: 0x000C9410 File Offset: 0x000C9410
	private 0B005140.124B6895 60953A65(0B005140.124B6895 14782104, 0B005140.124B6895 38D742A9, bool 54416985)
	{
		uint num = 174014135U;
		if (num > 190993663U)
		{
			goto IL_A3;
		}
		for (;;)
		{
			IL_13:
			num = 1494824054U << (int)num;
			TypeCode typeCode = this.7E6151EB(14782104, 38D742A9);
			num = 1517517563U << (int)num;
			TypeCode typeCode2 = typeCode;
			num <<= 21;
			if (num != 552744442U)
			{
				for (;;)
				{
					TypeCode typeCode3 = typeCode2;
					num >>= 9;
					uint num2 = num ^ 3125257U;
					num -= 232618900U;
					switch (typeCode3 - num2)
					{
					case 0:
						goto IL_A8;
					case 1:
					case 3:
						goto IL_3CC;
					case 2:
						goto IL_16F;
					case 4:
						goto IL_249;
					case 5:
						if (num % 729958784U != 0U)
						{
							goto Block_12;
						}
						continue;
					}
					break;
				}
				if (num > 1492526991U)
				{
					break;
				}
				continue;
				IL_A8:
				num = 279324136U >> (int)num;
				if (674325831U <= num)
				{
					continue;
				}
				num <<= 22;
				if (!54416985)
				{
					goto IL_117;
				}
				num = 1311196340U - num;
				if ((num ^ 1935620292U) != 0U)
				{
					goto Block_5;
				}
				continue;
				IL_249:
				num = 865168655U << (int)num;
				if (!54416985)
				{
					goto Block_9;
				}
				num = 1014907006U << (int)num;
				if (1020487019U % num != 0U)
				{
					goto Block_10;
				}
				goto IL_A8;
				IL_16F:
				num ^= 648635807U;
				if (!54416985)
				{
					goto IL_1E8;
				}
				if (990918316U < num)
				{
					goto Block_8;
				}
				continue;
				Block_12:
				num /= 1425546719U;
				if (!54416985)
				{
					goto Block_13;
				}
				if (num - 701318610U != 0U)
				{
					goto Block_15;
				}
			}
		}
		num += 0U;
		goto IL_A3;
		Block_5:
		num |= 261494539U;
		int num3 = (int)14782104.49390C3B();
		uint num4 = 38D742A9.49390C3B();
		int num5 = num3 / (int)num4;
		num = (1700935950U & num);
		int 0D6B27B = num5;
		goto IL_150;
		IL_117:
		int num6 = 14782104.DCFDB33F();
		num = (2012691590U | num);
		int num7 = 38D742A9.DCFDB33F();
		num = 1513422865U % num;
		int num8 = num6 / num7;
		num >>= 22;
		0D6B27B = num8;
		num += 622989222U;
		IL_150:
		num = (1280845578U ^ num);
		if ((num & 1908429840U) != 0U)
		{
			return new 0B005140.07685083(0D6B27B);
		}
		goto IL_A3;
		Block_8:
		num = (332943234U | num);
		long num9 = (long)14782104.6DD020CC();
		num *= 1635191196U;
		num ^= 215241908U;
		ulong num10 = 38D742A9.6DD020CC();
		num |= 249576048U;
		ulong num11 = num10;
		num %= 715339321U;
		long num12 = (long)num11;
		num ^= 767128512U;
		long num13 = num9 / num12;
		num *= 13639030U;
		long num14 = num13;
		goto IL_222;
		IL_1E8:
		num /= 2087284473U;
		long num15 = 14782104.EB2B8B0E();
		long num16 = 38D742A9.EB2B8B0E();
		long num17 = num16;
		num &= 267068039U;
		long num18 = num15 / num17;
		num = 2131915537U - num;
		num14 = num18;
		num += 882244298U;
		IL_222:
		num = 656764454U >> (int)num;
		long 54416986 = num14;
		num = 433618104U >> (int)num;
		return new 0B005140.13AF7E46(54416986);
		Block_9:
		num *= 485302375U;
		0B005140.124B6895 124B = 14782104;
		goto IL_2A6;
		Block_10:
		num = (2063618329U ^ num);
		124B = 14782104.3D08BB82();
		num ^= 997097831U;
		IL_2A6:
		float num19 = 124B.84027CE6();
		num &= 690910935U;
		0B005140.124B6895 124B2;
		if (!54416985)
		{
			124B2 = 38D742A9;
		}
		else
		{
			num = (2127307096U & num);
			124B2 = 38D742A9.3D08BB82();
			num += 4096U;
		}
		float num20 = 124B2.84027CE6();
		num ^= 341905410U;
		float num21 = num20;
		float num22 = num21;
		num = 1109686743U >> (int)num;
		return new 0B005140.721F5C60(num19 / num22);
		Block_13:
		0B005140.124B6895 124B3;
		if (1766340588U > num)
		{
			124B3 = 14782104;
			goto IL_359;
		}
		goto IL_A3;
		Block_15:
		num = (2080389602U ^ num);
		124B3 = 14782104.3D08BB82();
		num ^= 2080389602U;
		IL_359:
		num %= 491341159U;
		double num23 = 124B3.BD97D382();
		num = 1986486331U % num;
		0B005140.124B6895 124B4;
		if (!54416985)
		{
			124B4 = 38D742A9;
		}
		else
		{
			num = 956181242U >> (int)num;
			num = (970738116U | num);
			124B4 = 38D742A9.3D08BB82();
			num += 3254821380U;
		}
		double num24 = 124B4.BD97D382();
		num = (895576328U | num);
		double 702B = num23 / num24;
		num %= 1581726338U;
		return new 0B005140.6B6D1F66(702B);
		IL_A3:
		IL_3CC:
		if (num > 207161453U)
		{
			throw new InvalidOperationException();
		}
		goto IL_13;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000C97FC File Offset: 0x000C97FC
	private 0B005140.124B6895 5B4F582F(0B005140.124B6895 06052C4E, 0B005140.124B6895 54032365, bool 5F2F75B6)
	{
		uint num = 1021592364U;
		for (;;)
		{
			TypeCode typeCode = 06052C4E.08177016();
			num = 1501757597U >> (int)num;
			for (;;)
			{
				TypeCode typeCode2 = typeCode;
				uint num2 = num + 4294600665U;
				num = 145504705U - num;
				if (typeCode2 == num2)
				{
					goto IL_7F;
				}
				num = 872557721U << (int)num;
				if (num <= 1264658333U)
				{
					goto IL_7A;
				}
				uint num3 = (uint)typeCode;
				num = (527371491U & num);
				if (num3 != num + 3873308683U)
				{
					goto Block_3;
				}
				if (1543590189U + num == 0U)
				{
					break;
				}
				num %= 1139952131U;
				if (5F2F75B6)
				{
					goto Block_6;
				}
				num = 1191647835U << (int)num;
				if (num / 1961183222U == 0U)
				{
					goto Block_7;
				}
			}
		}
		Block_3:
		if ((1467957240U ^ num) == 0U)
		{
			goto IL_E0;
		}
		IL_7A:
		throw new InvalidOperationException();
		IL_7F:
		num += 1000227422U;
		if (5F2F75B6)
		{
			num = 102595448U / num;
			int num4 = (int)06052C4E.49390C3B();
			num /= 1797481953U;
			num = 1805743404U - num;
			uint num5 = 54032365.49390C3B();
			num >>= 14;
			int num6 = (int)num5;
			num <<= 6;
			int 0D6B27B = num4 % num6;
			num -= 1366363839U;
			return new 0B005140.07685083(0D6B27B);
		}
		IL_E0:
		num = 1421893916U >> (int)num;
		int num7 = 06052C4E.DCFDB33F();
		num &= 1979070001U;
		int num8 = 54032365.DCFDB33F();
		num = 1518102412U << (int)num;
		int num9 = num8;
		num = 25888310U + num;
		int 0D6B27B2 = num7 % num9;
		num -= 1211773960U;
		return new 0B005140.07685083(0D6B27B2);
		Block_6:
		num = 1534550679U + num;
		long num10 = (long)06052C4E.6DD020CC();
		num |= 1944995112U;
		num = 178797956U * num;
		ulong num11 = 54032365.6DD020CC();
		num %= 1405124572U;
		ulong num12 = num11;
		long 54032366 = num10 % (long)num12;
		num <<= 19;
		return new 0B005140.13AF7E46(54032366);
		Block_7:
		long num13 = 06052C4E.EB2B8B0E();
		long num14 = 54032365.EB2B8B0E();
		long num15 = num14;
		num = 599351289U % num;
		long 54032367 = num13 % num15;
		num = 1366256550U + num;
		return new 0B005140.13AF7E46(54032367);
	}

	// Token: 0x06000111 RID: 273 RVA: 0x000C99EC File Offset: 0x000C99EC
	private 0B005140.124B6895 42A22042(0B005140.124B6895 3D5E49D8, 0B005140.124B6895 2A8824D3)
	{
		uint num = 696868778U;
		if (1610443975U >> (int)num == 0U)
		{
			goto IL_4D;
		}
		IL_18:
		num <<= 18;
		num &= 1516795026U;
		TypeCode typeCode = this.7E6151EB(3D5E49D8, 2A8824D3);
		num = (1052342801U ^ num);
		TypeCode typeCode2 = typeCode;
		num >>= 7;
		if ((num ^ 1288592196U) == 0U)
		{
			goto IL_96;
		}
		IL_4D:
		object obj = typeCode2;
		object obj2 = num + 4281785621U;
		num = 309730227U + num;
		object obj3 = obj - obj2;
		num |= 35073957U;
		switch (obj3)
		{
		case 0:
			break;
		case 1:
		case 3:
			IL_1CA:
			num = 1315268317U * num;
			if ((590821562U ^ num) != 0U)
			{
				throw new InvalidOperationException();
			}
			goto IL_18;
		case 2:
			goto IL_E1;
		case 4:
		{
			int size = IntPtr.Size;
			num = 1293156785U << (int)num;
			uint num2 = num - 2315311228U;
			num = 695084462U << (int)num;
			float 474F1D1D;
			if (size != num2)
			{
				474F1D1D = 0f;
			}
			else
			{
				474F1D1D = float.NaN;
				num ^= 0U;
			}
			return new 0B005140.721F5C60(474F1D1D);
		}
		case 5:
		{
			uint size2 = (uint)IntPtr.Size;
			num *= 785534535U;
			double 702B;
			if (size2 != (num ^ 3572336981U))
			{
				num = 736049819U - num;
				if (2077108358U <= num)
				{
					goto IL_18;
				}
				702B = 0.0;
			}
			else
			{
				if (970084900U == num)
				{
					goto IL_18;
				}
				702B = double.NaN;
				num ^= 2182887451U;
			}
			return new 0B005140.6B6D1F66(702B);
		}
		default:
			if (886716912U != num)
			{
				num += 0U;
				goto IL_96;
			}
			break;
		}
		if (num < 1458375278U)
		{
			int num3 = 3D5E49D8.DCFDB33F();
			num = 1534753055U >> (int)num;
			int num4 = 2A8824D3.DCFDB33F();
			num = (1106125848U | num);
			int num5 = num4;
			num %= 393154735U;
			int 0D6B27B = num3 ^ num5;
			num &= 1641024380U;
			return new 0B005140.07685083(0D6B27B);
		}
		IL_E1:
		num %= 799503993U;
		long num6 = 3D5E49D8.EB2B8B0E();
		num = 804197946U >> (int)num;
		long num7 = 2A8824D3.EB2B8B0E();
		num = 480055158U % num;
		long num8 = num7;
		num = 1841042514U - num;
		long <<EMPTY_NAME>> = num6 ^ num8;
		num &= 1183402861U;
		return new 0B005140.13AF7E46(<<EMPTY_NAME>>);
		IL_96:
		goto IL_1CA;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x000C9BDC File Offset: 0x000C9BDC
	private 0B005140.124B6895 2FE94915(0B005140.124B6895 14CE4C79, 0B005140.124B6895 620E313F)
	{
		uint num = 2093639063U;
		for (;;)
		{
			IL_06:
			num = 7144181U >> (int)num;
			num += 881669286U;
			num = 1082287739U + num;
			TypeCode typeCode = this.7E6151EB(14CE4C79, 620E313F);
			num = (1969123265U & num);
			TypeCode typeCode2 = typeCode;
			for (;;)
			{
				TypeCode typeCode3 = typeCode2;
				uint num2 = num ^ 1963854600U;
				num = (651328307U | num);
				switch (typeCode3 - num2)
				{
				case 0:
					goto IL_70;
				case 1:
				case 3:
					goto IL_1C9;
				case 2:
					goto IL_BC;
				case 4:
					goto IL_F3;
				case 5:
				{
					num |= 1810834990U;
					if (num <= 2110541009U)
					{
						goto IL_06;
					}
					int size = IntPtr.Size;
					uint num3 = num + 2147516613U;
					num = (755712228U ^ num);
					if (size != num3)
					{
						goto Block_8;
					}
					num >>= 20;
					if (184294744U > num)
					{
						goto Block_9;
					}
					continue;
				}
				}
				goto Block_1;
			}
			IL_F3:
			num = 813044985U % num;
			if (1251298098U > num)
			{
				goto Block_4;
			}
		}
		Block_1:
		num += 0U;
		IL_6B:
		goto IL_1C9;
		IL_70:
		num = 1192362994U << (int)num;
		if (num != 1824799109U)
		{
			num = 1274683773U << (int)num;
			int num4 = 14CE4C79.DCFDB33F();
			int num5 = 620E313F.DCFDB33F();
			num = 298721703U / num;
			int num6 = num5;
			num = (359734764U | num);
			return new 0B005140.07685083(num4 | num6);
		}
		IL_BC:
		num %= 1769869498U;
		if (1717519514 << (int)num != 0)
		{
			long num7 = 14CE4C79.EB2B8B0E();
			long num8 = 620E313F.EB2B8B0E();
			long num9 = num8;
			num <<= 24;
			return new 0B005140.13AF7E46(num7 | num9);
		}
		goto IL_6B;
		Block_4:
		float 474F1D1D;
		if (IntPtr.Size != (int)(num - 813044981U))
		{
			if (num >= 1949965324U)
			{
				goto IL_6B;
			}
			474F1D1D = 0f;
		}
		else
		{
			num = 642151827U << (int)num;
			474F1D1D = float.NaN;
			num ^= 376837369U;
		}
		num /= 1361007716U;
		return new 0B005140.721F5C60(474F1D1D);
		Block_8:
		num += 2059608285U;
		double 702B = 0.0;
		goto IL_1BB;
		Block_9:
		702B = double.NaN;
		num += 3451345801U;
		IL_1BB:
		num = (295198128U & num);
		return new 0B005140.6B6D1F66(702B);
		IL_1C9:
		num %= 2127372889U;
		if (1414152378 << (int)num != 0)
		{
			throw new InvalidOperationException();
		}
		goto IL_BC;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x000C9DD4 File Offset: 0x000C9DD4
	private 0B005140.124B6895 201B029C(0B005140.124B6895 02D043E2, 0B005140.124B6895 45C87D74)
	{
		uint num = 1694130435U;
		if (num * 1946944493U == 0U)
		{
			goto IL_79;
		}
		IL_12:
		num |= 1458467339U;
		TypeCode typeCode = this.7E6151EB(02D043E2, 45C87D74);
		if (num * 299197739U != 0U)
		{
			for (;;)
			{
				uint num2 = (uint)typeCode;
				num /= 182193158U;
				uint num3 = num2 - (num ^ 3U);
				num -= 992627266U;
				switch (num3)
				{
				case 0:
					goto IL_7E;
				case 1:
				case 3:
					goto IL_197;
				case 2:
					goto IL_B3;
				case 4:
					goto IL_E8;
				case 5:
				{
					num = 1793228174U * num;
					if (967587647U >= num)
					{
						goto IL_79;
					}
					uint size = (uint)IntPtr.Size;
					num &= 1971849607U;
					if (size == (num ^ 1351092356U))
					{
						goto IL_178;
					}
					num -= 202985615U;
					if (num / 583756312U != 0U)
					{
						goto Block_7;
					}
					goto IL_E8;
				}
				}
				break;
				IL_E8:
				if (num >> 6 != 0U)
				{
					goto Block_3;
				}
			}
			if (699084607U - num != 0U)
			{
				num ^= 0U;
				goto IL_79;
			}
			goto IL_178;
			IL_7E:
			num = 584471156U * num;
			int num4 = 02D043E2.DCFDB33F();
			num &= 510482544U;
			num = 1318324069U / num;
			int num5 = 45C87D74.DCFDB33F();
			num = (2029913236U ^ num);
			int num6 = num5;
			return new 0B005140.07685083(num4 & num6);
			Block_3:
			float 474F1D1D;
			if (IntPtr.Size != (int)(num - 3302340036U))
			{
				474F1D1D = 0f;
			}
			else
			{
				num = (1564812778U & num);
				474F1D1D = float.NaN;
				num ^= 2156957696U;
			}
			return new 0B005140.721F5C60(474F1D1D);
			Block_7:
			double 702B = 0.0;
			goto IL_189;
			IL_178:
			702B = double.NaN;
			num += 4091981681U;
			IL_189:
			num = 1174042536U / num;
			return new 0B005140.6B6D1F66(702B);
		}
		IL_B3:
		num *= 1809270598U;
		long num7 = 02D043E2.EB2B8B0E();
		num >>= 30;
		num *= 930355155U;
		long num8 = 45C87D74.EB2B8B0E();
		num = 606021011U / num;
		return new 0B005140.13AF7E46(num7 & num8);
		IL_79:
		IL_197:
		if ((1447887587U ^ num) != 0U)
		{
			throw new InvalidOperationException();
		}
		goto IL_12;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x000C9F8C File Offset: 0x000C9F8C
	private int 76D30FAD(0B005140.124B6895 3847547A, 0B005140.124B6895 034C703F, bool 721D338F, int 76854272)
	{
		uint num;
		for (;;)
		{
			IL_00:
			num = 656884252U;
			int num2 = 76854272;
			for (;;)
			{
				IL_0B:
				num += 1446406402U;
				TypeCode typeCode = 3847547A.08177016();
				num = 1662676866U - num;
				for (;;)
				{
					IL_26:
					num ^= 10362062U;
					TypeCode typeCode2 = 034C703F.08177016();
					if (444665447U <= num)
					{
						do
						{
							TypeCode typeCode3 = typeCode;
							uint num3 = num ^ 3844266155U;
							num <<= 17;
							if (typeCode3 == num3)
							{
								goto IL_9C;
							}
							if ((num ^ 850075267U) == 0U)
							{
								goto IL_0B;
							}
							TypeCode typeCode4 = typeCode2;
							num *= 808155913U;
							uint num4 = num ^ 2549350401U;
							num = 1436901523U >> (int)num;
							if (typeCode4 == num4)
							{
								num += 1538170733U;
								goto IL_9C;
							}
							if (num << 20 != 0U)
							{
								if (typeCode != (TypeCode)(num - 1436901509U))
								{
									num *= 1186078996U;
									if ((num & 39669991U) == 0U)
									{
										goto IL_26;
									}
									if (typeCode2 == (TypeCode)(num ^ 1519681138U))
									{
										num ^= 254877423U;
									}
									else
									{
										if ((1486315853U ^ num) != 0U)
										{
											TypeCode typeCode5 = typeCode;
											uint num5 = num ^ 1519681137U;
											num &= 243690228U;
											if (typeCode5 != num5)
											{
												if (num % 1072509477U == 0U)
												{
													goto IL_0B;
												}
												uint num6 = (uint)typeCode2;
												num += 232136314U;
												if (num6 == num - 408586465U)
												{
													num += 4062830982U;
												}
												else
												{
													if (num != 508968721U)
													{
														TypeCode typeCode6 = typeCode;
														num += 831150170U;
														uint num7 = num + 3055230659U;
														num |= 1276331940U;
														if (typeCode6 != num7)
														{
															num = 39256242U + num;
															TypeCode typeCode7 = typeCode2;
															num = 1611091185U << (int)num;
															uint num8 = num - 1073741813U;
															num = 1067997521U << (int)num;
															if (typeCode7 != num8)
															{
																uint num9 = (uint)typeCode;
																num *= 2140693882U;
																if (num9 != (num ^ 4170155411U))
																{
																	TypeCode typeCode8 = typeCode2;
																	num = 696089179U * num;
																	uint num10 = num + 1495146059U;
																	num |= 678979681U;
																	num += 1597321483U;
																	if (typeCode8 != num10)
																	{
																		goto IL_4EA;
																	}
																	num ^= 4137721488U;
																}
																num = 2139954165U >> (int)num;
																int num12;
																if (!721D338F)
																{
																	int num11 = 3847547A.DCFDB33F();
																	num /= 1412987605U;
																	int value = 034C703F.DCFDB33F();
																	num = 1160467254U >> (int)num;
																	num12 = num11.CompareTo(value);
																}
																else
																{
																	num -= 2005806035U;
																	num -= 2014986130U;
																	uint num13 = 3847547A.49390C3B();
																	num = (1967524458U | num);
																	uint num14 = num13;
																	num = (2065130827U | num);
																	num = 2065236813U << (int)num;
																	uint value2 = 034C703F.49390C3B();
																	num = (1685811953U | num);
																	num12 = num14.CompareTo(value2);
																	num ^= 693117383U;
																}
																num2 = num12;
																num ^= 1258571836U;
																goto IL_4EA;
															}
															num += 240094875U;
														}
														num = 1734097274U * num;
														int num16;
														if (!721D338F)
														{
															num |= 705633587U;
															if (num <= 1021526079U)
															{
																goto IL_00;
															}
															num /= 1866035285U;
															long num15 = 3847547A.EB2B8B0E();
															num %= 1918790668U;
															if (num == 1814259282U)
															{
																goto IL_00;
															}
															num <<= 18;
															num -= 1859061978U;
															long value3 = 034C703F.EB2B8B0E();
															num = 723736394U + num;
															num16 = num15.CompareTo(value3);
														}
														else
														{
															if (num - 1452766825U == 0U)
															{
																goto IL_BB;
															}
															ulong num17 = 3847547A.6DD020CC();
															num = 1963085632U * num;
															ulong num18 = num17;
															num -= 1008676108U;
															ulong value4 = 034C703F.6DD020CC();
															num /= 1005728040U;
															num16 = num18.CompareTo(value4);
															num += 3159903854U;
														}
														num ^= 97594675U;
														num2 = num16;
														num += 1420146631U;
														goto IL_4EA;
													}
													goto IL_9C;
												}
											}
											num = 128736224U * num;
											num <<= 14;
											float num19 = 3847547A.84027CE6();
											num *= 1343757225U;
											float num20 = num19;
											num ^= 891841400U;
											int num21 = num20.CompareTo(034C703F.84027CE6());
											num -= 1449922383U;
											num2 = num21;
											num += 1649589985U;
											goto IL_4EA;
										}
										goto IL_00;
									}
								}
								num = 981404604U << (int)num;
								double num22 = 3847547A.BD97D382();
								num *= 41706696U;
								double num23 = num22;
								int num24 = num23.CompareTo(034C703F.BD97D382());
								num = (1713528877U & num);
								num2 = num24;
								num += 3358530314U;
								goto IL_4EA;
							}
							goto IL_0B;
							IL_BB:
							object obj = 034C703F.611AD8EF();
							num = (648950134U ^ num);
							object obj2 = obj;
							if (1681146971U < num)
							{
								continue;
							}
							object obj4;
							object obj3 = obj4;
							object obj5 = obj2;
							num = 2047427990U >> (int)num;
							if (obj3 == obj5)
							{
								goto Block_5;
							}
							if (num == 1718386242U)
							{
								goto IL_00;
							}
							bool flag = obj2 != null;
							num = 631185047U - num;
							if (!flag)
							{
								goto Block_7;
							}
							if (num >= 1613370555U)
							{
								goto IL_0B;
							}
							bool flag2 = obj4 != null;
							num = 2131521815U % num;
							if (!flag2)
							{
								goto Block_9;
							}
							goto IL_4EA;
							IL_9C:
							if ((num ^ 1447178698U) != 0U)
							{
								obj4 = 3847547A.611AD8EF();
								num *= 1172375355U;
								goto IL_BB;
							}
							goto IL_00;
							IL_4EA:
							num >>= 13;
							if (num2 >= (int)(num - 29048U))
							{
								goto IL_528;
							}
							num /= 1105950165U;
							num2 = (int)(num - 1U);
						}
						while (1793071275U <= num);
						IL_573:
						num = 1585013075U << (int)num;
						if (372723625U <= num)
						{
							return num2;
						}
						continue;
						IL_528:
						int num25 = num2;
						num = 750221620U % num;
						uint num26 = num ^ 27972U;
						num = 1297553292U / num;
						num += 4294920909U;
						if (num25 > num26)
						{
							int num27 = (int)(num + 1U);
							num *= 814443732U;
							num2 = num27;
							num += 0U;
						}
						goto IL_573;
					}
					goto IL_00;
				}
			}
		}
		Block_5:
		return (int)(num - 488U);
		Block_7:
		return (int)(num + 3663782738U);
		Block_9:
		num = 2091803605U / num;
		return (int)(num ^ 4294967287U);
	}

	// Token: 0x06000115 RID: 277 RVA: 0x000CA52C File Offset: 0x000CA52C
	private 0B005140.124B6895 4A8D17D4(0B005140.124B6895 602D02A5)
	{
		uint num;
		for (;;)
		{
			num = 1258124017U;
			TypeCode typeCode = 602D02A5.08177016();
			num += 655622367U;
			TypeCode typeCode2 = typeCode;
			num *= 1323241878U;
			if (287183409U != num)
			{
				goto IL_28;
			}
			IL_50:
			TypeCode typeCode3 = typeCode2;
			num ^= 845152974U;
			uint num2 = num ^ 2172011205U;
			num = 758843464U - num;
			if (typeCode3 != num2)
			{
				if (num <= 843058241U)
				{
					goto IL_28;
				}
			}
			else
			{
				num = 1673856842U << (int)num;
				if (num % 1603748093U != 0U)
				{
					goto Block_3;
				}
				continue;
			}
			IL_C1:
			num >>= 12;
			if (655184995U > num)
			{
				goto Block_4;
			}
			continue;
			IL_28:
			TypeCode typeCode4 = typeCode2;
			uint num3 = num ^ 1092266985U;
			num %= 761547032U;
			if (typeCode4 == num3)
			{
				break;
			}
			num <<= 11;
			if (num >= 1619480373U)
			{
				goto IL_50;
			}
			goto IL_C1;
		}
		num -= 1041506696U;
		return new 0B005140.07685083(~602D02A5.DCFDB33F());
		Block_3:
		long <<EMPTY_NAME>> = ~602D02A5.EB2B8B0E();
		num <<= 1;
		return new 0B005140.13AF7E46(<<EMPTY_NAME>>);
		Block_4:
		throw new InvalidOperationException();
	}

	// Token: 0x06000116 RID: 278 RVA: 0x000CA614 File Offset: 0x000CA614
	private 0B005140.124B6895 4BBA5C85(0B005140.124B6895 67B354DA)
	{
		uint num = 1923106964U;
		for (;;)
		{
			num |= 1104241193U;
			TypeCode typeCode = 67B354DA.08177016();
			num *= 835140823U;
			for (;;)
			{
				TypeCode typeCode2 = typeCode;
				uint num2 = num + 3847229262U;
				num -= 189467647U;
				switch (typeCode2 - num2)
				{
				case 0:
					num |= 1448034173U;
					if (1873309440U >= num)
					{
						goto Block_2;
					}
					continue;
				case 1:
				case 3:
					break;
				case 2:
					goto IL_88;
				case 4:
					goto IL_BF;
				case 5:
					goto IL_CC;
				default:
					num ^= 0U;
					break;
				}
				num = (1381781632U ^ num);
				if ((424042856U ^ num) != 0U)
				{
					goto Block_5;
				}
			}
			IL_88:
			if ((387976954U & num) != 0U)
			{
				goto Block_3;
			}
			continue;
			IL_CC:
			if (1417551604U * num != 0U)
			{
				goto Block_4;
			}
		}
		Block_2:
		num = (1585994753U ^ num);
		int num3 = 67B354DA.DCFDB33F();
		num ^= 877679492U;
		return new 0B005140.07685083(-num3);
		Block_3:
		num = (193794390U ^ num);
		long num4 = 67B354DA.EB2B8B0E();
		num = 1758669369U % num;
		long <<EMPTY_NAME>> = -num4;
		num = 152724960U >> (int)num;
		return new 0B005140.13AF7E46(<<EMPTY_NAME>>);
		IL_BF:
		return new 0B005140.721F5C60(-67B354DA.84027CE6());
		Block_4:
		double 702B = -67B354DA.BD97D382();
		num = 69932390U * num;
		return new 0B005140.6B6D1F66(702B);
		Block_5:
		throw new InvalidOperationException();
	}

	// Token: 0x06000117 RID: 279 RVA: 0x000CA728 File Offset: 0x000CA728
	private 0B005140.124B6895 65A21502(0B005140.124B6895 7361750D, 0B005140.124B6895 6AB32270, bool 571773B9)
	{
		uint num = 1152997757U;
		for (;;)
		{
			IL_07:
			num = 841680111U / num;
			TypeCode typeCode = 7361750D.08177016();
			if (num == 768035322U)
			{
				goto IL_71;
			}
			uint num2 = (uint)typeCode;
			num += 1796692321U;
			if (num2 != num + 2498274984U)
			{
				while (typeCode == (TypeCode)(num - 1796692310U))
				{
					if (num == 1305219774U)
					{
						goto IL_07;
					}
					if (571773B9)
					{
						goto Block_7;
					}
					if (num * 1957896717U != 0U)
					{
						goto Block_8;
					}
				}
				if ((1458729031U ^ num) != 0U)
				{
					break;
				}
			}
			else if (1561864531U < num)
			{
				if (571773B9)
				{
					goto IL_71;
				}
				num = 1116429005U >> (int)num;
				if (937584118U >= num)
				{
					goto Block_5;
				}
			}
		}
		throw new InvalidOperationException();
		IL_71:
		uint num3 = 7361750D.49390C3B();
		num = 1489127814U / num;
		int num4 = 6AB32270.DCFDB33F();
		num = (510156290U ^ num);
		int num5 = num4;
		int num6 = num5;
		num /= 2131122160U;
		int num7 = (int)(num ^ 31U);
		num = (471277661U & num);
		return new 0B005140.07685083(num3 >> (num6 & num7));
		Block_5:
		int num8 = 7361750D.DCFDB33F();
		int num9 = 6AB32270.DCFDB33F();
		int num10 = num9;
		num = 464215271U << (int)num;
		int num11 = (int)(num + 354993759U);
		num = 2132555349U / num;
		int 0D6B27B = num8 >> (num10 & num11);
		num |= 718820272U;
		return new 0B005140.07685083(0D6B27B);
		Block_7:
		num = 170479318U * num;
		ulong num12 = 7361750D.6DD020CC();
		num -= 1560771455U;
		num = (1560165787U & num);
		int num13 = 6AB32270.DCFDB33F();
		num %= 1545489587U;
		int num14 = num13;
		int num15 = num14;
		num -= 2126263662U;
		return new 0B005140.13AF7E46(num12 >> (num15 & (int)(num - 3246642150U)));
		Block_8:
		num *= 1874228879U;
		long num16 = 7361750D.EB2B8B0E();
		int num17 = 6AB32270.DCFDB33F();
		num &= 409544151U;
		int num18 = num17;
		int num19 = (int)(num + 4158578488U);
		num &= 1057896282U;
		return new 0B005140.13AF7E46(num16 >> (num18 & num19));
	}

	// Token: 0x06000118 RID: 280 RVA: 0x000CA8FC File Offset: 0x000CA8FC
	private 0B005140.124B6895 6F2C0E7F(0B005140.124B6895 438122D3, 0B005140.124B6895 19CA334E)
	{
		uint num = 1489716549U;
		TypeCode typeCode = 438122D3.08177016();
		num = 878733755U >> (int)num;
		for (;;)
		{
			TypeCode typeCode2 = typeCode;
			uint num2 = num ^ 27460420U;
			num /= 1201435921U;
			if (typeCode2 == num2)
			{
				break;
			}
			if (1578382772U > num)
			{
				uint num3 = (uint)typeCode;
				num += 1687292776U;
				if (num3 == num + 2607674531U)
				{
					goto IL_9A;
				}
				if ((num ^ 1197225186U) != 0U)
				{
					goto Block_4;
				}
			}
		}
		num ^= 1379688524U;
		int num4 = 438122D3.DCFDB33F();
		int num5 = 19CA334E.DCFDB33F();
		num = 202907539U * num;
		int num6 = num5;
		num = (1770076521U ^ num);
		int num7 = num6 & (int)(num ^ 1995785938U);
		num >>= 18;
		int 0D6B27B = num4 << num7;
		num *= 1721307588U;
		return new 0B005140.07685083(0D6B27B);
		IL_9A:
		long num8 = 438122D3.EB2B8B0E();
		num *= 15672680U;
		int num9 = 19CA334E.DCFDB33F();
		num = 1350380803U % num;
		int num10 = num9;
		int num11 = num10;
		num = (1185360270U | num);
		int num12 = num11 & (int)(num ^ 1459563952U);
		num >>= 18;
		return new 0B005140.13AF7E46(num8 << num12);
		Block_4:
		throw new InvalidOperationException();
	}

	// Token: 0x06000119 RID: 281 RVA: 0x000CA9F4 File Offset: 0x000CA9F4
	private unsafe 0B005140.124B6895 33005A42(object 73FB30F6, Type 48EE707B)
	{
		uint num;
		0B005140.124B6895 124B2;
		for (;;)
		{
			IL_00:
			0B005140.124B6895 124B = 73FB30F6 as 0B005140.124B6895;
			num = 1670868211U;
			124B2 = 124B;
			if (1410412195U * num == 0U)
			{
				goto IL_45;
			}
			IL_19:
			while (!48EE707B.IsEnum)
			{
				num >>= 1;
				TypeCode typeCode = Type.GetTypeCode(48EE707B);
				num = 1250381448U << (int)num;
				TypeCode typeCode2 = typeCode;
				uint num2 = (uint)typeCode2;
				num ^= 492121947U;
				switch (num2 - (num - 223686488U))
				{
				case 0U:
					num = 2042695334U % num;
					if (num >> 4 == 0U)
					{
						goto IL_00;
					}
					if (124B2 == null)
					{
						goto Block_9;
					}
					num = 938023215U / num;
					if (num != 1298687989U)
					{
						goto Block_10;
					}
					goto IL_00;
				case 1U:
					num = (55530088U & num);
					if (num * 168378387U != 0U)
					{
						goto Block_11;
					}
					break;
				case 2U:
				{
					num >>= 30;
					if ((num ^ 611810728U) == 0U)
					{
						continue;
					}
					bool flag = 124B2 != null;
					num ^= 495066241U;
					if (!flag)
					{
						if (1278411949 << (int)num != 0)
						{
							goto Block_15;
						}
						goto IL_00;
					}
					else
					{
						if (num != 1100039525U)
						{
							goto Block_16;
						}
						goto IL_00;
					}
					break;
				}
				case 3U:
				{
					num ^= 2109294422U;
					bool flag2 = 124B2 != null;
					num = 1533441291U % num;
					if (!flag2)
					{
						goto Block_17;
					}
					num ^= 1916618275U;
					if (num - 63970416U != 0U)
					{
						goto Block_18;
					}
					goto IL_45;
				}
				case 4U:
				{
					num = 1561926119U / num;
					bool flag3 = 124B2 != null;
					num <<= 21;
					if (flag3)
					{
						goto IL_340;
					}
					if (num + 1470703383U != 0U)
					{
						goto Block_20;
					}
					goto IL_00;
				}
				case 5U:
					num /= 263069117U;
					if (752698366U >> (int)num != 0U)
					{
						if (124B2 == null)
						{
							if (num != 1364477103U)
							{
								goto Block_23;
							}
							goto IL_00;
						}
						else
						{
							if (num != 1066747204U)
							{
								goto Block_24;
							}
							goto IL_5D;
						}
					}
					break;
				case 6U:
				{
					num = (459162886U | num);
					if (1149518071U / num == 0U)
					{
						goto IL_00;
					}
					bool flag4 = 124B2 != null;
					num *= 1670404837U;
					if (!flag4)
					{
						goto Block_26;
					}
					if (1518157871U <= num)
					{
						goto Block_27;
					}
					continue;
				}
				case 7U:
					goto IL_41D;
				case 8U:
					goto IL_45A;
				case 9U:
					if (1084362157U != num)
					{
						goto Block_30;
					}
					goto IL_00;
				case 10U:
					num = 389964857U % num;
					if (124B2 == null)
					{
						num = 457069641U << (int)num;
						if (528418559U != num)
						{
							goto Block_33;
						}
					}
					else
					{
						if (534660702U >= num)
						{
							goto Block_34;
						}
						goto IL_00;
					}
					break;
				case 11U:
				{
					bool flag5 = 124B2 != null;
					num = 578829380U % num;
					if (!flag5)
					{
						goto Block_35;
					}
					num = 1399523325U / num;
					if (num % 1728279536U != 0U)
					{
						goto Block_36;
					}
					goto IL_45;
				}
				case 12U:
				case 13U:
				case 14U:
					goto IL_5F5;
				case 15U:
					if (1185952271U != num)
					{
						goto Block_37;
					}
					goto IL_5D;
				default:
					num += 0U;
					goto IL_5F5;
				}
				IL_37:
				bool flag6 = 124B2 != null;
				num = 1016615570U * num;
				if (flag6)
				{
					goto IL_45;
				}
				goto IL_5D;
				IL_5F5:
				if (1926378794U + num == 0U)
				{
					goto IL_37;
				}
				num /= 1500337014U;
				Type typeFromHandle = typeof(IntPtr);
				num = 1239494647U - num;
				if (48EE707B == typeFromHandle)
				{
					if (num != 21893002U)
					{
						if (124B2 != null)
						{
							num = 611778707U + num;
							if (num - 1845458953U != 0U)
							{
								goto Block_43;
							}
							goto IL_00;
						}
						else
						{
							if (73FB30F6 == null)
							{
								goto Block_44;
							}
							if (num >> 8 != 0U)
							{
								goto Block_45;
							}
							goto IL_00;
						}
					}
				}
				else
				{
					num >>= 20;
					num -= 1773014812U;
					RuntimeTypeHandle handle = typeof(UIntPtr).TypeHandle;
					num = 1969489834U + num;
					Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
					num -= 133562585U;
					if (48EE707B == typeFromHandle2)
					{
						num = (105848936U ^ num);
						if ((1382900953U & num) == 0U)
						{
							goto IL_00;
						}
						if (124B2 != null)
						{
							goto Block_48;
						}
						num %= 1422682488U;
						if (73FB30F6 == null)
						{
							goto Block_49;
						}
						if (num % 163016120U != 0U)
						{
							goto Block_50;
						}
						goto IL_00;
					}
					else
					{
						if (183445571U == num)
						{
							goto IL_37;
						}
						num *= 1250299862U;
						bool isValueType = 48EE707B.IsValueType;
						num += 1122715503U;
						if (isValueType)
						{
							if (1375544452U + num == 0U)
							{
								goto IL_00;
							}
							if (124B2 != null)
							{
								num >>= 2;
								if (num >> 29 != 0U)
								{
									goto Block_55;
								}
								goto IL_37;
							}
							else
							{
								num = 1018961543U - num;
								if (num * 1666325523U != 0U)
								{
									bool flag7 = 73FB30F6 != null;
									num = 2055215119U + num;
									if (flag7)
									{
										goto Block_57;
									}
									num |= 768375573U;
									if (num % 233528763U != 0U)
									{
										goto Block_58;
									}
									goto IL_00;
								}
							}
						}
						else
						{
							num = (1817606949U & num);
							if (822286949U == num)
							{
								goto IL_00;
							}
							if (48EE707B.IsArray)
							{
								num /= 187180046U;
								if (179452074U - num == 0U)
								{
									goto IL_00;
								}
								if (124B2 == null)
								{
									goto Block_62;
								}
								num = 1869554838U << (int)num;
								if (1220439797U <= num)
								{
									goto Block_63;
								}
								goto IL_37;
							}
							else
							{
								num = 1634871218U % num;
								if (710171297U == num)
								{
									goto IL_00;
								}
								num %= 1010309872U;
								bool isPointer = 48EE707B.IsPointer;
								num += 1697664671U;
								if (!isPointer)
								{
									goto IL_979;
								}
								if ((1025527750U ^ num) != 0U)
								{
									if (124B2 != null)
									{
										goto Block_67;
									}
									num ^= 1607877048U;
									if (87035591 << (int)num != 0)
									{
										if (73FB30F6 == null)
										{
											goto Block_69;
										}
										num <<= 22;
										if ((1982539560U ^ num) != 0U)
										{
											goto Block_70;
										}
									}
								}
							}
						}
					}
				}
			}
			num /= 303000620U;
			if (544736893U > num)
			{
				goto IL_37;
			}
			continue;
			IL_5D:
			if (1478368858U - num == 0U)
			{
				goto IL_9D;
			}
			bool flag8 = 73FB30F6 != null;
			num *= 1124887359U;
			if (flag8)
			{
				if (num < 1177813941U)
				{
					goto IL_19;
				}
				bool flag9 = 73FB30F6 is Enum;
				num ^= 0U;
				if (!flag9)
				{
					num = (587229412U & num);
					goto IL_9D;
				}
			}
			IL_BE:
			if (num >= 368270446U)
			{
				break;
			}
			continue;
			IL_9D:
			num -= 1204033937U;
			object obj = Enum.ToObject(48EE707B, 73FB30F6);
			num = 468074558U / num;
			73FB30F6 = obj;
			num += 1278523302U;
			goto IL_BE;
			IL_45:
			0B005140.124B6895 124B3 = 124B2;
			num -= 1132617116U;
			73FB30F6 = 124B3.611AD8EF();
			num ^= 3314459620U;
			goto IL_5D;
		}
		Enum 21340C1D;
		if (73FB30F6 != null)
		{
			num <<= 20;
			21340C1D = (Enum)73FB30F6;
		}
		else
		{
			num <<= 7;
			num = (503581591U ^ num);
			21340C1D = (Enum)Activator.CreateInstance(48EE707B);
			num += 1979721577U;
		}
		return new 0B005140.543A386B(21340C1D);
		Block_9:
		object value = 73FB30F6;
		num %= 1070488947U;
		bool <<EMPTY_NAME>> = Convert.ToBoolean(value);
		goto IL_1E7;
		Block_10:
		0B005140.124B6895 124B4 = 124B2;
		num = 1908869151U << (int)num;
		<<EMPTY_NAME>> = 124B4.A29D7A45();
		num += 2177000563U;
		IL_1E7:
		return new 0B005140.759B7CAC(<<EMPTY_NAME>>);
		Block_11:
		bool flag10 = 124B2 != null;
		num = 1588998264U / num;
		char 4ACB4F;
		if (!flag10)
		{
			4ACB4F = Convert.ToChar(73FB30F6);
		}
		else
		{
			0B005140.124B6895 124B5 = 124B2;
			num = 264199640U << (int)num;
			4ACB4F = 124B5.C299D4B1();
			num ^= 4252459082U;
		}
		num %= 420568087U;
		return new 0B005140.7EB526D5(4ACB4F);
		Block_15:
		object value2 = 73FB30F6;
		num %= 849227164U;
		sbyte 2 = Convert.ToSByte(value2);
		goto IL_2AC;
		Block_16:
		0B005140.124B6895 124B6 = 124B2;
		num &= 132013204U;
		2 = 124B6.3759DB5E();
		num += 402653185U;
		IL_2AC:
		return new 0B005140.67617919(2);
		Block_17:
		num ^= 1702774323U;
		object value3 = 73FB30F6;
		num &= 974677258U;
		byte 22DC = Convert.ToByte(value3);
		goto IL_30D;
		Block_18:
		0B005140.124B6895 124B7 = 124B2;
		num -= 761345487U;
		22DC = 124B7.7CCA383B();
		num += 1042162607U;
		IL_30D:
		return new 0B005140.560C2D3B(22DC);
		Block_20:
		short 004C0E5C = Convert.ToInt16(73FB30F6);
		goto IL_356;
		IL_340:
		0B005140.124B6895 124B8 = 124B2;
		num = 627532093U - num;
		004C0E5C = 124B8.D846A716();
		num ^= 610754877U;
		IL_356:
		return new 0B005140.083F6CB0(004C0E5C);
		Block_23:
		object value4 = 73FB30F6;
		num <<= 14;
		ushort 321F1B = Convert.ToUInt16(value4);
		goto IL_3BB;
		Block_24:
		0B005140.124B6895 124B9 = 124B2;
		num <<= 5;
		321F1B = 124B9.E35975AC();
		num += 0U;
		IL_3BB:
		return new 0B005140.4F521487(321F1B);
		Block_26:
		object value5 = 73FB30F6;
		num = 77805899U - num;
		int 0D6B27B = Convert.ToInt32(value5);
		goto IL_40F;
		Block_27:
		0D6B27B = 124B2.DCFDB33F();
		num += 79113557U;
		IL_40F:
		num <<= 14;
		return new 0B005140.07685083(0D6B27B);
		IL_41D:
		bool flag11 = 124B2 != null;
		num = 701326451U - num;
		uint 50E;
		if (!flag11)
		{
			num = (823814554U ^ num);
			object value6 = 73FB30F6;
			num = 2032084829U % num;
			50E = Convert.ToUInt32(value6);
		}
		else
		{
			50E = 124B2.49390C3B();
			num ^= 35806017U;
		}
		return new 0B005140.074A0932(50E);
		IL_45A:
		num = 1087326428U - num;
		bool flag12 = 124B2 != null;
		num = 585445840U - num;
		long 3;
		if (!flag12)
		{
			num = 1736258912U << (int)num;
			3 = Convert.ToInt64(73FB30F6);
		}
		else
		{
			num = 603525759U * num;
			0B005140.124B6895 124B10 = 124B2;
			num = 2061373288U / num;
			3 = 124B10.EB2B8B0E();
			num += 2595225600U;
		}
		return new 0B005140.13AF7E46(3);
		Block_30:
		bool flag13 = 124B2 != null;
		num >>= 16;
		ulong 0F4F;
		if (!flag13)
		{
			object value7 = 73FB30F6;
			num >>= 2;
			0F4F = Convert.ToUInt64(value7);
		}
		else
		{
			0F4F = 124B2.6DD020CC();
			num ^= 3584U;
		}
		num = (984558790U | num);
		return new 0B005140.2BAF4849(0F4F);
		Block_33:
		object value8 = 73FB30F6;
		num -= 1018441972U;
		float 474F1D1D = Convert.ToSingle(value8);
		goto IL_548;
		Block_34:
		474F1D1D = 124B2.84027CE6();
		num ^= 178453458U;
		IL_548:
		num = 1706850977U / num;
		return new 0B005140.721F5C60(474F1D1D);
		Block_35:
		object value9 = 73FB30F6;
		num = 989266203U * num;
		double 702B = Convert.ToDouble(value9);
		goto IL_599;
		Block_36:
		702B = 124B2.BD97D382();
		num += 2574117872U;
		IL_599:
		return new 0B005140.6B6D1F66(702B);
		Block_37:
		bool flag14 = 124B2 != null;
		num <<= 18;
		string 4;
		if (!flag14)
		{
			4 = (string)73FB30F6;
		}
		else
		{
			num = (1137868736U | num);
			object obj2 = 124B2;
			num *= 786246970U;
			4 = obj2.ToString();
			num ^= 967946624U;
		}
		num = 1574533429U << (int)num;
		return new 0B005140.3C1E7579(4);
		Block_43:
		return new 0B005140.484E1899(124B2.861F6A75());
		Block_44:
		IntPtr 1D7237C = IntPtr.Zero;
		goto IL_684;
		Block_45:
		object obj3 = 73FB30F6;
		num -= 1815900404U;
		1D7237C = (IntPtr)obj3;
		num += 1815900404U;
		IL_684:
		return new 0B005140.484E1899(1D7237C);
		Block_48:
		num |= 1139935154U;
		0B005140.124B6895 124B11 = 124B2;
		num >>= 16;
		return new 0B005140.0F111823(124B11.1A796C90());
		Block_49:
		num = 952005172U + num;
		UIntPtr 65B = UIntPtr.Zero;
		goto IL_732;
		Block_50:
		object obj4 = 73FB30F6;
		num = 1605506262U / num;
		65B = (UIntPtr)obj4;
		num ^= 1051676287U;
		IL_732:
		return new 0B005140.0F111823(65B);
		Block_55:
		object 14D50CDD = 124B2.611AD8EF();
		num = 1714511760U * num;
		return new 0B005140.4FCC199C(14D50CDD);
		Block_57:
		num *= 353594084U;
		object 14D50CDD2 = 73FB30F6;
		goto IL_7F2;
		Block_58:
		num = 525227187U / num;
		14D50CDD2 = Activator.CreateInstance(48EE707B);
		num ^= 3577565556U;
		IL_7F2:
		num -= 967595684U;
		return new 0B005140.4FCC199C(14D50CDD2);
		Block_62:
		num = (2009612167U | num);
		Array 2FB142BA = (Array)73FB30F6;
		goto IL_887;
		Block_63:
		0B005140.124B6895 124B12 = 124B2;
		num &= 1869292410U;
		object obj5 = 124B12.611AD8EF();
		num = 596789294U / num;
		2FB142BA = (Array)obj5;
		num += 2009612167U;
		IL_887:
		num = 418916863U + num;
		return new 0B005140.149C28AA(2FB142BA);
		Block_67:
		num *= 1342325131U;
		object ptr = 124B2.611AD8EF();
		num = (313016258U | num);
		return new 0B005140.03371198(Pointer.Box(Pointer.Unbox(ptr), 48EE707B), 48EE707B);
		Block_69:
		num = 1869696752U + num;
		void* ptr2 = num - 2428069095U;
		num -= 450760169U;
		void* ptr3 = ptr2;
		goto IL_964;
		Block_70:
		object ptr4 = 73FB30F6;
		num &= 1910792821U;
		ptr3 = Pointer.Unbox(ptr4);
		num ^= 68900606U;
		IL_964:
		num <<= 6;
		return new 0B005140.03371198(Pointer.Box(ptr3, 48EE707B), 48EE707B);
		IL_979:
		num >>= 17;
		bool flag15 = 124B2 != null;
		num += 613634099U;
		object 4E;
		if (!flag15)
		{
			4E = 73FB30F6;
		}
		else
		{
			4E = 124B2.611AD8EF();
			num += 0U;
		}
		return new 0B005140.744E73A6(4E);
	}

	// Token: 0x0600011A RID: 282 RVA: 0x000CB3AC File Offset: 0x000CB3AC
	private string 11A061CA(int 56E84A16)
	{
		uint num = 29688825U;
		Dictionary<int, object> dictionary = 0B005140.35EB737B;
		num *= 413946173U;
		object obj = dictionary;
		num >>= 18;
		Monitor.Enter(obj);
		string result;
		try
		{
			object obj2;
			string text;
			for (;;)
			{
				Dictionary<int, object> dictionary2 = 0B005140.35EB737B;
				num = 1322322487U + num;
				num %= 459818325U;
				bool flag = dictionary2.TryGetValue(56E84A16, out obj2);
				num = (1963620901U & num);
				if (flag)
				{
					break;
				}
				if (num <= 1489992947U)
				{
					num = 1161570294U / num;
					Module module = this.42D33E78;
					num >>= 13;
					num >>= 19;
					text = module.ResolveString(56E84A16);
					num = 1816944686U * num;
					if (num <= 465574339U)
					{
						goto Block_5;
					}
				}
			}
			num /= 1472953726U;
			do
			{
				string text2 = (string)obj2;
				num = 987058886U + num;
				result = text2;
			}
			while ((1356794504U ^ num) == 0U);
			return result;
			Block_5:
			Dictionary<int, object> dictionary3 = 0B005140.35EB737B;
			num += 151935974U;
			num -= 35916675U;
			dictionary3.Add(56E84A16, text);
			num = 816715199U * num;
			result = text;
		}
		finally
		{
			do
			{
				num = 586302766U;
				Monitor.Exit(dictionary);
			}
			while (1247958543U == num);
		}
		return result;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x000CB4C8 File Offset: 0x000CB4C8
	private Type 556E394E(int 041B468A)
	{
		uint num = 45312553U;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = 0B005140.35EB737B;
			num = (231023740U | num);
			obj = dictionary;
			num -= 249637268U;
		}
		while (num >> 31 != 0U);
		Type result2;
		lock (obj)
		{
			object obj2;
			Type type;
			for (;;)
			{
				Dictionary<int, object> dictionary2 = 0B005140.35EB737B;
				num = (116015075U | num);
				num = 2097166308U * num;
				bool flag = dictionary2.TryGetValue(041B468A, out obj2);
				num *= 136726102U;
				if (flag)
				{
					if (356658349U / num == 0U)
					{
						break;
					}
				}
				else
				{
					if (1535531425U > num)
					{
						num = (427769007U & num);
						Module module = this.42D33E78;
						num -= 391341119U;
						type = module.ResolveType(041B468A);
						num = (2086154915U | num);
					}
					0B005140.35EB737B.Add(041B468A, type);
					if (num >= 464523384U)
					{
						goto Block_6;
					}
				}
			}
			object obj3 = obj2;
			num = (2004423914U | num);
			Type result = (Type)obj3;
			num = 2097283930U % num;
			return result;
			Block_6:
			result2 = type;
		}
		return result2;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000CB5BC File Offset: 0x000CB5BC
	private MethodBase 4FB70B10(int 6C3838F0)
	{
		uint num = 638074975U;
		Dictionary<int, object> dictionary2;
		do
		{
			Dictionary<int, object> dictionary = 0B005140.35EB737B;
			num %= 611851902U;
			dictionary2 = dictionary;
			num &= 1094207710U;
		}
		while (1273003612U <= num);
		Monitor.Enter(dictionary2);
		MethodBase result;
		try
		{
			num -= 1490842917U;
			if (num <= 522671343U)
			{
				goto IL_83;
			}
			object obj;
			MethodBase methodBase;
			for (;;)
			{
				IL_49:
				Dictionary<int, object> dictionary3 = 0B005140.35EB737B;
				num ^= 991429711U;
				num <<= 29;
				bool flag = dictionary3.TryGetValue(6C3838F0, out obj);
				num ^= 1530543403U;
				if (flag)
				{
					break;
				}
				Module module = this.42D33E78;
				num = (1366049204U ^ num);
				methodBase = module.ResolveMethod(6C3838F0);
				if (num != 993604399U)
				{
					goto Block_6;
				}
			}
			num = (290028628U | num);
			goto IL_83;
			Block_6:
			Dictionary<int, object> dictionary4 = 0B005140.35EB737B;
			num = 1534031341U << (int)num;
			dictionary4.Add(6C3838F0, methodBase);
			num /= 502276456U;
			return methodBase;
			IL_83:
			MethodBase methodBase2 = (MethodBase)obj;
			num = 1002918396U >> (int)num;
			result = methodBase2;
			if (2004248070U - num == 0U)
			{
				goto IL_49;
			}
		}
		finally
		{
			do
			{
				num = 2005490254U;
				if ((num ^ 1919898362U) == 0U)
				{
					break;
				}
				object obj2 = dictionary2;
				num = 2002855146U % num;
				Monitor.Exit(obj2);
			}
			while (num < 1432956299U);
		}
		return result;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x000CB710 File Offset: 0x000CB710
	private FieldInfo 4F380A52(int 4B6E5434)
	{
		uint num = 1627213031U;
		Dictionary<int, object> dictionary = 0B005140.35EB737B;
		num %= 599009596U;
		Dictionary<int, object> dictionary2 = dictionary;
		num = 583672826U >> (int)num;
		object obj = dictionary2;
		num <<= 19;
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			num -= 1749955865U;
			if (622689623U > num)
			{
				goto IL_79;
			}
			object obj2;
			for (;;)
			{
				IL_43:
				Dictionary<int, object> dictionary3 = 0B005140.35EB737B;
				num |= 673336411U;
				bool flag = dictionary3.TryGetValue(4B6E5434, out obj2);
				num <<= 23;
				if (flag)
				{
					break;
				}
				if ((1364396946U ^ num) == 0U)
				{
					goto IL_79;
				}
				Module module = this.42D33E78;
				num = (576014843U & num);
				FieldInfo fieldInfo = module.ResolveField(4B6E5434);
				num = 1554074746U % num;
				FieldInfo fieldInfo2 = fieldInfo;
				Dictionary<int, object> dictionary4 = 0B005140.35EB737B;
				num = 1152000198U % num;
				dictionary4.Add(4B6E5434, fieldInfo2);
				num /= 1605834833U;
				result = fieldInfo2;
				if ((960897324U ^ num) != 0U)
				{
					goto Block_5;
				}
			}
			num = (274020532U ^ num);
			if ((num & 2099790767U) != 0U)
			{
				goto IL_79;
			}
			Block_5:
			return result;
			IL_79:
			object obj3 = obj2;
			num = 1556184856U + num;
			FieldInfo fieldInfo3 = (FieldInfo)obj3;
			num = 1866667059U % num;
			result = fieldInfo3;
			if (num < 1244334290U)
			{
				goto IL_43;
			}
		}
		finally
		{
			Monitor.Exit(dictionary2);
		}
		return result;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x000CB830 File Offset: 0x000CB830
	private 0B005140.124B6895 43C112F1(MethodBase 3A8D0130)
	{
		uint num = 618814259U;
		Dictionary<int, 0B005140.124B6895> dictionary2;
		object[] array3;
		for (;;)
		{
			IL_06:
			num = (848312029U | num);
			ParameterInfo[] parameters = 3A8D0130.GetParameters();
			if (num >= 587930865U)
			{
				Dictionary<int, 0B005140.124B6895> dictionary = new Dictionary<int, 0B005140.124B6895>();
				num = 1348484969U / num;
				dictionary2 = dictionary;
				for (;;)
				{
					ParameterInfo[] array = parameters;
					num = (1577090358U ^ num);
					object[] array2 = new object[array.Length];
					num >>= 18;
					array3 = array2;
					int num2 = parameters.Length;
					num = 1794388850U % num;
					int num3 = num2 - (int)(num ^ 2547U);
					num = (1564114457U & num);
					int num4 = num3;
					if (1471501847U == num)
					{
						break;
					}
					for (;;)
					{
						num *= 443629198U;
						if (num4 < (int)(num ^ 822630624U))
						{
							goto Block_6;
						}
						0B005140.124B6895 124B = this.0BD76085();
						num = 1790380825U;
						0B005140.124B6895 124B2 = 124B;
						bool flag = 124B2.591DABE5();
						num = 858288280U >> (int)num;
						if (flag)
						{
							if ((692133492U ^ num) == 0U)
							{
								goto IL_06;
							}
							Dictionary<int, 0B005140.124B6895> dictionary3 = dictionary2;
							num = 586947709U / num;
							int key = num4;
							0B005140.124B6895 value = 124B2;
							num /= 1714751647U;
							dictionary3[key] = value;
							num ^= 25U;
						}
						num = 464476187U - num;
						if (num % 1032665150U == 0U)
						{
							break;
						}
						object[] array4 = array3;
						num *= 1682984468U;
						int num5 = num4;
						num = (1099652608U | num);
						object 73FB30F = 124B2;
						num = (1246068366U ^ num);
						ParameterInfo[] array5 = parameters;
						num = (1284135727U ^ num);
						int num6 = num4;
						num -= 980492831U;
						ParameterInfo parameterInfo = array5[num6];
						num += 178537437U;
						0B005140.124B6895 124B3 = this.33005A42(73FB30F, parameterInfo.ParameterType);
						num /= 1245077555U;
						array4[num5] = 124B3.611AD8EF();
						int num7 = num4;
						num = 827654346U % num;
						int num8 = (int)(num + 1U);
						num = (470505137U | num);
						num4 = num7 - num8;
						num ^= 470507169U;
					}
				}
			}
		}
		Block_6:
		num = 1269638171U - num;
		ConstructorInfo constructorInfo = (ConstructorInfo)3A8D0130;
		num = (536762813U & num);
		object[] parameters2 = array3;
		num = 346692702U >> (int)num;
		object obj = constructorInfo.Invoke(parameters2);
		num /= 1356074362U;
		Dictionary<int, 0B005140.124B6895> dictionary4 = dictionary2;
		num %= 871856952U;
		Dictionary<int, 0B005140.124B6895>.Enumerator enumerator = dictionary4.GetEnumerator();
		try
		{
			if (num != 285225152U)
			{
				goto IL_204;
			}
			IL_1C0:
			num = 2134010135U;
			KeyValuePair<int, 0B005140.124B6895> keyValuePair = enumerator.Current;
			num = 1591944810U / num;
			KeyValuePair<int, 0B005140.124B6895> keyValuePair2 = keyValuePair;
			num = 1215837213U * num;
			0B005140.124B6895 value2 = keyValuePair2.Value;
			num += 1503144351U;
			value2.53E5679E(array3[keyValuePair2.Key]);
			num ^= 1503144351U;
			IL_204:
			num <<= 18;
			if (enumerator.MoveNext() || num + 514408824U == 0U)
			{
				goto IL_1C0;
			}
		}
		finally
		{
			do
			{
				num = 2051487221U;
				if (161419807U == num)
				{
					break;
				}
				((IDisposable)enumerator).Dispose();
			}
			while ((num ^ 581965508U) == 0U);
		}
		num = 1225268659U;
		object 73FB30F2 = obj;
		num = (1784744444U & num);
		Type declaringType = 3A8D0130.DeclaringType;
		num = 2026703490U + num;
		return this.33005A42(73FB30F2, declaringType);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x000CBAC8 File Offset: 0x000CBAC8
	private bool 3FD502FB(MethodBase 0D2D22BA, object 69FB1F2C, ref object 36A90331, object[] 7C0C6FD2)
	{
		uint num;
		for (;;)
		{
			Type declaringType = 0D2D22BA.DeclaringType;
			num = 744579419U;
			if (1379150240U == num)
			{
				goto IL_58;
			}
			do
			{
				IL_18:
				bool flag = declaringType != null;
				num = (1194939796U ^ num);
				if (!flag)
				{
					goto IL_26;
				}
			}
			while (num <= 517606654U);
			bool isGenericType = declaringType.IsGenericType;
			num %= 2101895247U;
			if (!isGenericType)
			{
				goto IL_252;
			}
			if (num * 367027941U == 0U)
			{
				continue;
			}
			IL_58:
			Type type = declaringType;
			num &= 1271281865U;
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			num &= 1589661813U;
			RuntimeTypeHandle handle = typeof(Nullable<>).TypeHandle;
			num = 867460007U >> (int)num;
			Type typeFromHandle = Type.GetTypeFromHandle(handle);
			num = 1541896977U << (int)num;
			num ^= 3016766671U;
			if (genericTypeDefinition != typeFromHandle)
			{
				goto IL_252;
			}
			string name = 0D2D22BA.Name;
			num += 931688514U;
			string b = "get_HasValue";
			StringComparison comparisonType = (StringComparison)(num - 2732631309U);
			num >>= 19;
			if (string.Equals(name, b, comparisonType))
			{
				goto Block_3;
			}
			num = 1874613512U >> (int)num;
			bool flag2 = string.Equals(0D2D22BA.Name, "get_Value", (StringComparison)(num ^ 2U));
			num ^= 147218429U;
			if (flag2)
			{
				num = 1589336611U * num;
				if (num == 1894127979U)
				{
					goto IL_18;
				}
				bool flag3 = 69FB1F2C != null;
				num = 111569815U >> (int)num;
				if (!flag3)
				{
					num -= 45889146U;
					if (num >> 24 != 0U)
					{
						goto Block_7;
					}
				}
				else if ((274087018U & num) != 0U)
				{
					object obj = 69FB1F2C;
					num = (1613259798U | num);
					36A90331 = obj;
					if (101198099U <= num)
					{
						goto Block_9;
					}
				}
			}
			else
			{
				num = (285243013U | num);
				if (1348031445U != num)
				{
					goto Block_10;
				}
			}
		}
		IL_26:
		return num - 1800942799U != 0U;
		Block_3:
		num = 1325496475U % num;
		object obj2 = 69FB1F2C;
		num *= 45701037U;
		36A90331 = (obj2 != null);
		goto IL_242;
		Block_7:
		throw new InvalidOperationException();
		Block_9:
		num += 1736867800U;
		goto IL_242;
		Block_10:
		num = 399533037U % num;
		string name2 = 0D2D22BA.Name;
		string value = "GetValueOrDefault";
		num = 366898873U / num;
		StringComparison comparisonType2 = (StringComparison)(num - 4294967292U);
		num *= 1191194845U;
		bool flag4 = name2.Equals(value, comparisonType2);
		num ^= 3350128431U;
		if (flag4)
		{
			if (69FB1F2C == null)
			{
				num = (1345267318U ^ num);
				num = 497764203U >> (int)num;
				Type declaringType2 = 0D2D22BA.DeclaringType;
				num -= 2060194631U;
				Type underlyingType = Nullable.GetUnderlyingType(declaringType2);
				num *= 1263351637U;
				69FB1F2C = Activator.CreateInstance(underlyingType);
				num += 3770124316U;
			}
			if (num == 2099979383U)
			{
				goto IL_26;
			}
			num <<= 24;
			36A90331 = 69FB1F2C;
			num += 2561599279U;
		}
		IL_242:
		num /= 1712462065U;
		return num + 0U != 0U;
		IL_252:
		num &= 468920159U;
		return num + 4105165745U != 0U;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000CBD38 File Offset: 0x000CBD38
	private 0B005140.124B6895 508305B1(MethodBase 4C69561D, bool 450854DF)
	{
		uint num = 1164904645U;
		MethodInfo methodInfo;
		Dictionary<int, 0B005140.124B6895> dictionary;
		object[] array3;
		object obj3;
		object obj5;
		object[] array7;
		for (;;)
		{
			IL_07:
			methodInfo = (4C69561D as MethodInfo);
			num = 1921714164U / num;
			for (;;)
			{
				IL_19:
				num = 1175857993U + num;
				ParameterInfo[] parameters = 4C69561D.GetParameters();
				num <<= 2;
				ParameterInfo[] array = parameters;
				num = 1180790592U + num;
				0B005140.124B6895 124B;
				for (;;)
				{
					dictionary = new Dictionary<int, 0B005140.124B6895>();
					num <<= 7;
					if (num << 11 != 0U)
					{
						for (;;)
						{
							IL_5C:
							ParameterInfo[] array2 = array;
							num = (1529183243U | num);
							int num2 = array2.Length;
							num <<= 18;
							array3 = new object[num2];
							num -= 641163609U;
							if (2096910051U * num == 0U)
							{
								goto IL_19;
							}
							ParameterInfo[] array4 = array;
							num = (580989821U | num);
							int num3 = array4.Length;
							num ^= 374421360U;
							int num4 = num3;
							int num5 = (int)(num - 4255418510U);
							num >>= 18;
							int num6 = num4 - num5;
							num = 1783834289U % num;
							int num7 = num6;
							if (1262440928U + num == 0U)
							{
								break;
							}
							for (;;)
							{
								num ^= 1040276226U;
								if ((1451173562U ^ num) == 0U)
								{
									goto IL_07;
								}
								int num8 = num7;
								uint num9 = num ^ 1040270090U;
								num ^= 1328106636U;
								if (num8 < num9)
								{
									break;
								}
								num = 1449342051U;
								if ((num ^ 1299252293U) == 0U)
								{
									goto IL_5C;
								}
								num = (913002175U & num);
								124B = this.0BD76085();
								if ((1837324078U ^ num) == 0U)
								{
									goto IL_07;
								}
								0B005140.124B6895 124B2 = 124B;
								num = 881272239U - num;
								if (124B2.591DABE5())
								{
									num = 1902712481U % num;
									Dictionary<int, 0B005140.124B6895> dictionary2 = dictionary;
									num = 864319200U + num;
									dictionary2[num7] = 124B;
									num += 3550673071U;
								}
								num = 295384905U + num;
								object[] array5 = array3;
								num |= 1424767902U;
								int num10 = num7;
								object 73FB30F = 124B;
								num = 447249827U + num;
								ParameterInfo parameterInfo = array[num7];
								num <<= 11;
								Type parameterType = parameterInfo.ParameterType;
								num ^= 669869545U;
								array5[num10] = this.33005A42(73FB30F, parameterType).611AD8EF();
								int num11 = num7;
								num = 294790358U << (int)num;
								int num12 = (int)(num - 608807935U);
								num |= 1819550418U;
								num7 = num11 - num12;
								num ^= 1820178138U;
							}
							num = (1264598290U | num);
							if (1941334815U * num == 0U)
							{
								goto IL_07;
							}
							num = 415001326U << (int)num;
							bool isStatic = 4C69561D.IsStatic;
							num = 1071594697U << (int)num;
							0B005140.124B6895 124B3;
							if (!isStatic)
							{
								num *= 612107638U;
								124B3 = this.0BD76085();
							}
							else
							{
								num = 306732313U % num;
								124B3 = null;
								num ^= 2419698879U;
							}
							num %= 1901345278U;
							124B = 124B3;
							if (1924081298U >> (int)num == 0U)
							{
								goto IL_19;
							}
							bool flag = 124B != null;
							num -= 1504904944U;
							object obj;
							if (!flag)
							{
								if (num - 2006989911U == 0U)
								{
									goto IL_19;
								}
								obj = null;
							}
							else
							{
								obj = 124B.611AD8EF();
								num += 0U;
							}
							object obj2;
							bool flag2 = (obj2 = obj) != null;
							num ^= 954692763U;
							if (!flag2)
							{
								if (num >> 9 == 0U)
								{
									goto IL_07;
								}
								obj2 = null;
								num ^= 0U;
							}
							obj3 = obj2;
							num = (164045896U | num);
							if (450854DF)
							{
								num -= 667438934U;
								if (num == 920550066U)
								{
									continue;
								}
								bool flag3 = obj3 != null;
								num = (1042022484U | num);
								num += 296767254U;
								if (!flag3)
								{
									goto Block_17;
								}
							}
							num = 1345341346U + num;
							if ((num ^ 2080711528U) == 0U)
							{
								goto IL_19;
							}
							object obj4 = null;
							num = 521874378U * num;
							obj5 = obj4;
							if (num == 217546092U)
							{
								goto IL_07;
							}
							num = (603598709U ^ num);
							bool isConstructor = 4C69561D.IsConstructor;
							num |= 302524538U;
							if (isConstructor)
							{
								num = (620364999U & num);
								Type declaringType = 4C69561D.DeclaringType;
								num |= 877401857U;
								bool isValueType = declaringType.IsValueType;
								num += 2848057144U;
								if (isValueType)
								{
									goto Block_21;
								}
							}
							num = (2055154921U ^ num);
							num = 1212682326U + num;
							num |= 1139619408U;
							object 69FB1F2C = obj3;
							num = (689112683U | num);
							object[] 7C0C6FD = array3;
							num = 1028020453U / num;
							bool flag4 = this.3FD502FB(4C69561D, 69FB1F2C, ref obj5, 7C0C6FD);
							num = (1026904976U ^ num);
							num ^= 1053337491U;
							if (flag4)
							{
								goto IL_C4B;
							}
							num = 248799705U >> (int)num;
							num = 299390765U * num;
							if (450854DF)
							{
								goto IL_C22;
							}
							if (313267088U >= num)
							{
								goto IL_07;
							}
							num = (1979273415U | num);
							bool isVirtual = 4C69561D.IsVirtual;
							num += 3755917184U;
							if (!isVirtual)
							{
								goto IL_C22;
							}
							num = (751269409U & num);
							num *= 947201570U;
							bool isFinal = 4C69561D.IsFinal;
							num = (493108083U ^ num);
							num ^= 1326793230U;
							if (isFinal)
							{
								goto IL_C22;
							}
							num %= 778704143U;
							if (226571509U * num == 0U)
							{
								goto IL_07;
							}
							ParameterInfo[] array6 = array;
							num = (688346762U ^ num);
							int num13 = array6.Length;
							num &= 8801044U;
							int num14 = num13;
							num = 101460397U % num;
							int num15 = (int)(num ^ 176812U);
							num -= 1769831720U;
							array7 = new object[num14 + num15];
							num = (875823152U & num);
							object[] array8 = array7;
							num ^= 1349663369U;
							int num16 = (int)(num ^ 1148598921U);
							num = (2052333692U ^ num);
							array8[num16] = obj3;
							num = 910115936U << (int)num;
							int num17 = (int)(num - 2348810240U);
							num <<= 5;
							int num18 = num17;
							if (2088061080U >= num)
							{
								goto IL_07;
							}
							for (;;)
							{
								num = 977091817U << (int)num;
								int num19 = num18;
								int num20 = array.Length;
								num = 823544820U / num;
								if (num19 >= num20)
								{
									goto Block_35;
								}
								num = 399392540U;
								if (num < 17241020U)
								{
									break;
								}
								object[] array9 = array7;
								int num21 = num18;
								num <<= 0;
								int num22 = num21 + (int)(num ^ 399392541U);
								object[] array10 = array3;
								num = 2123314302U / num;
								object obj6 = array10[num18];
								num = 1661496298U * num;
								array9[num22] = obj6;
								num = 1562914449U >> (int)num;
								int num23 = num18;
								num -= 964915692U;
								int num24 = (int)(num ^ 3330057567U);
								num <<= 23;
								num18 = num23 + num24;
								num ^= 788529152U;
							}
						}
					}
				}
				Block_21:
				num &= 432164357U;
				if (605578378U < num)
				{
					break;
				}
				Type declaringType2 = 4C69561D.DeclaringType;
				object[] args = array3;
				num <<= 6;
				obj3 = Activator.CreateInstance(declaringType2, args);
				if ((num & 914768543U) == 0U)
				{
					break;
				}
				bool flag5 = 124B != null;
				num ^= 65959235U;
				if (!flag5)
				{
					goto IL_C4B;
				}
				num = 799759650U << (int)num;
				0B005140.124B6895 124B4 = 124B;
				num = 318003557U / num;
				bool flag6 = 124B4.591DABE5();
				num += 1556554636U;
				num += 2805387383U;
				if (!flag6)
				{
					goto IL_C4B;
				}
				0B005140.124B6895 124B5 = 124B;
				num = 207562368U % num;
				object 73FB30F2 = obj3;
				num |= 1160589616U;
				object 4EE42AA = this.33005A42(73FB30F2, 4C69561D.DeclaringType).611AD8EF();
				num |= 1079007568U;
				124B5.53E5679E(4EE42AA);
				if (745234630U != num)
				{
					goto Block_26;
				}
			}
		}
		Block_17:
		num = 1428491072U - num;
		throw new NullReferenceException();
		Block_26:
		num ^= 1182830452U;
		goto IL_C4B;
		Block_35:
		Dictionary<MethodBase, DynamicMethod> dictionary3 = 0B005140.5FA12BDF;
		num = (922563384U ^ num);
		Dictionary<MethodBase, DynamicMethod> obj7 = dictionary3;
		DynamicMethod dynamicMethod;
		lock (obj7)
		{
			num &= 1157198965U;
			do
			{
				IL_6D0:
				Dictionary<MethodBase, DynamicMethod> dictionary4 = 0B005140.5FA12BDF;
				num |= 1574532974U;
				num /= 1129140980U;
				num += 1854155248U;
				if (!dictionary4.TryGetValue(4C69561D, out dynamicMethod))
				{
					num = (1098331723U ^ num);
					if ((1011947528U ^ num) != 0U)
					{
						goto IL_717;
					}
					goto IL_804;
					IL_82F:
					int num26;
					int num25 = num26;
					num %= 1137992152U;
					ParameterInfo[] array;
					int num27 = array.Length;
					num %= 939280149U;
					int num28 = num27;
					num -= 2127720358U;
					if (num25 < num28)
					{
						goto IL_7A0;
					}
					Type[] array11;
					if (687305970U != num)
					{
						string name = "";
						if (methodInfo == null)
						{
							goto IL_89A;
						}
						MethodInfo methodInfo2 = methodInfo;
						num ^= 348068250U;
						if (methodInfo2.ReturnType == typeof(void))
						{
							num ^= 348068250U;
							goto IL_89A;
						}
						Type returnType = methodInfo.ReturnType;
						num ^= 348068250U;
						IL_8B1:
						Type[] parameterTypes = array11;
						num = 574826915U % num;
						Type typeFromHandle = typeof(0B005140);
						num = 1979852977U << (int)num;
						DynamicMethod dynamicMethod2 = new DynamicMethod(name, returnType, parameterTypes, typeFromHandle.Module, num - 2953921927U != 0U);
						num >>= 9;
						dynamicMethod = dynamicMethod2;
						num = (61425273U ^ num);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						num *= 85992357U;
						ILGenerator ilgenerator2 = ilgenerator;
						ILGenerator ilgenerator3 = ilgenerator2;
						0B005140.124B6895 124B;
						0B005140.124B6895 124B6 = 124B;
						num = (771054625U ^ num);
						OpCode opcode;
						if (!124B6.591DABE5())
						{
							opcode = OpCodes.Ldarg;
						}
						else
						{
							opcode = OpCodes.Ldarga;
							num += 0U;
						}
						num = (1445212432U | num);
						ilgenerator3.Emit(opcode, (int)(num ^ 3615406358U));
						int num29 = (int)(num ^ 3615406359U);
						num /= 99039844U;
						int num30 = num29;
						for (;;)
						{
							num = (998850729U & num);
							int num31 = num30;
							int num32 = array11.Length;
							num = (237910615U & num);
							if (num31 >= num32)
							{
								break;
							}
							num = 376066731U;
							if (num % 757750510U == 0U)
							{
								goto IL_6D0;
							}
							ILGenerator ilgenerator4 = ilgenerator2;
							Dictionary<int, 0B005140.124B6895> dictionary5 = dictionary;
							int num33 = num30;
							num = (179834655U ^ num);
							int key = num33 - (int)(num + 3811418701U);
							num = 1100354886U * num;
							OpCode opcode2;
							if (!dictionary5.ContainsKey(key))
							{
								num ^= 63648078U;
								opcode2 = OpCodes.Ldarg;
							}
							else
							{
								opcode2 = OpCodes.Ldarga;
								num ^= 63648078U;
							}
							ilgenerator4.Emit(opcode2, num30);
							num >>= 14;
							int num34 = num30;
							num = (1880888079U ^ num);
							int num35 = (int)(num ^ 1881073303U);
							num = 921728649U / num;
							int num36 = num34 + num35;
							num = 1044737906U >> (int)num;
							num30 = num36;
							num ^= 1044737878U;
						}
						num /= 946495022U;
						ILGenerator ilgenerator5 = ilgenerator2;
						OpCode call = OpCodes.Call;
						num /= 1432639511U;
						ilgenerator5.Emit(call, methodInfo);
						num = 611525121U - num;
						ILGenerator ilgenerator6 = ilgenerator2;
						OpCode ret = OpCodes.Ret;
						num = 332666279U % num;
						ilgenerator6.Emit(ret);
						if ((num ^ 151000782U) != 0U)
						{
							Dictionary<MethodBase, DynamicMethod> dictionary6 = 0B005140.5FA12BDF;
							num ^= 1180969550U;
							dictionary6[4C69561D] = dynamicMethod;
							num ^= 993269272U;
							goto IL_AAC;
						}
						goto IL_7A0;
						IL_89A:
						returnType = null;
						goto IL_8B1;
					}
					continue;
					IL_717:
					object[] array12 = array7;
					num = 774796559U * num;
					int num37 = array12.Length;
					num |= 357915461U;
					array11 = new Type[num37];
					num = 1459450006U * num;
					if (878140297U >= num)
					{
						Type[] array13 = array11;
						num = 1275275795U + num;
						int num38 = (int)(num - 1748003693U);
						num -= 1686779573U;
						Type declaringType3 = 4C69561D.DeclaringType;
						num = 222112331U - num;
						array13[num38] = declaringType3;
						num = (645430125U ^ num);
						num26 = (int)(num ^ 804163326U);
						if (num == 1572810861U)
						{
							goto IL_7A0;
						}
					}
					goto IL_82F;
					IL_804:
					int num39 = num26;
					num *= 418519143U;
					int num40 = (int)(num ^ 1342177281U);
					num |= 1741898009U;
					num26 = num39 + num40;
					num += 3088797157U;
					goto IL_82F;
					IL_7A0:
					Type[] array14 = array11;
					num = 653554185U;
					int num41 = num26;
					num = 1341667309U % num;
					int num42 = num41 + (int)(num + 4260408358U);
					num = 573972239U << (int)num;
					ParameterInfo[] array15 = array;
					num -= 237765613U;
					ParameterInfo parameterInfo2 = array15[num26];
					num = (265833111U & num);
					array14[num42] = parameterInfo2.ParameterType;
					num <<= 28;
					if ((num ^ 127868494U) != 0U)
					{
						goto IL_804;
					}
					goto IL_717;
				}
				IL_AAC:;
			}
			while (num / 2069854393U != 0U);
		}
		do
		{
			num = 873947860U;
			MethodBase methodBase = dynamicMethod;
			object obj8 = null;
			num = 2055408002U * num;
			object obj9 = methodBase.Invoke(obj8, array7);
			num = 121716372U / num;
			obj5 = obj9;
		}
		while (984162241U < num);
		Dictionary<int, 0B005140.124B6895>.Enumerator enumerator = dictionary.GetEnumerator();
		try
		{
			if ((1776057680U ^ num) == 0U)
			{
				goto IL_B1A;
			}
			IL_B15:
			goto IL_B8F;
			IL_B1A:
			num = 925331306U;
			KeyValuePair<int, 0B005140.124B6895> keyValuePair = enumerator.Current;
			num = (1519395898U | num);
			num /= 1052383357U;
			0B005140.124B6895 value = keyValuePair.Value;
			num ^= 1980242984U;
			object[] array16 = array7;
			num -= 1708013502U;
			num += 320169127U;
			int key2 = keyValuePair.Key;
			int num43 = (int)(num ^ 592398610U);
			num *= 2039547761U;
			value.53E5679E(array16[key2 + num43]);
			num += 3762174365U;
			IL_B8F:
			if (859131706U == num)
			{
				goto IL_B15;
			}
			bool flag7 = enumerator.MoveNext();
			num = (25500604U & num);
			if (flag7)
			{
				goto IL_B1A;
			}
			if ((1889882825U ^ num) == 0U)
			{
				goto IL_B15;
			}
		}
		finally
		{
			do
			{
				num = 628062426U;
				if (num <= 121899713U)
				{
					break;
				}
				num <<= 22;
				((IDisposable)enumerator).Dispose();
			}
			while (num == 1779334117U);
		}
		do
		{
			Dictionary<int, 0B005140.124B6895> dictionary7 = dictionary;
			num = 1409837088U;
			dictionary7.Clear();
		}
		while (num >= 1567300497U);
		num += 2952104931U;
		goto IL_C4B;
		IL_C22:
		num = (1223714446U ^ num);
		object obj10 = obj3;
		object[] parameters2 = array3;
		num = 1641314999U / num;
		obj5 = 4C69561D.Invoke(obj10, parameters2);
		num ^= 66974723U;
		IL_C4B:
		num *= 1459948391U;
		enumerator = dictionary.GetEnumerator();
		try
		{
			if (2005944043U + num == 0U)
			{
				goto IL_C9F;
			}
			KeyValuePair<int, 0B005140.124B6895> keyValuePair3;
			for (;;)
			{
				IL_CED:
				num /= 598030711U;
				if (num << 18 != 0U)
				{
					bool flag8 = enumerator.MoveNext();
					num = 779910965U - num;
					if (!flag8)
					{
						break;
					}
					num = 115427159U;
					KeyValuePair<int, 0B005140.124B6895> keyValuePair2 = enumerator.Current;
					num |= 1772687277U;
					keyValuePair3 = keyValuePair2;
					num = 1424713630U * num;
					if (num != 2039962858U)
					{
						goto IL_C9F;
					}
				}
			}
			goto IL_D40;
			goto IL_CED;
			IL_C9F:
			0B005140.124B6895 value2 = keyValuePair3.Value;
			num >>= 26;
			object[] array17 = array3;
			num += 1389783460U;
			num = 505423649U - num;
			object 4EE42AA2 = array17[keyValuePair3.Key];
			num = 624310566U >> (int)num;
			value2.53E5679E(4EE42AA2);
			num ^= 1303924284U;
			goto IL_CED;
		}
		finally
		{
			do
			{
				num = 862462590U;
				((IDisposable)enumerator).Dispose();
			}
			while (2018340741U == num);
		}
		do
		{
			IL_D40:
			num = 1358500477U;
			if (num <= 70791500U)
			{
				break;
			}
			if (methodInfo == null)
			{
				goto IL_D9A;
			}
		}
		while (967331632U == num);
		Type returnType2 = methodInfo.ReturnType;
		num = (482360688U & num);
		RuntimeTypeHandle handle = typeof(void).TypeHandle;
		num += 897593103U;
		if (returnType2 != Type.GetTypeFromHandle(handle))
		{
			num = 665329711U >> (int)num;
			num *= 616704108U;
			object 73FB30F3 = obj5;
			MethodInfo methodInfo3 = methodInfo;
			num >>= 16;
			return this.33005A42(73FB30F3, methodInfo3.ReturnType);
		}
		num += 179884798U;
		IL_D9A:
		return null;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x000CCB60 File Offset: 0x000CCB60
	private 0B005140.124B6895 24C803D1(int 4D847142, bool 0A736953)
	{
		uint num = 2057581249U;
		Dictionary<int, 0B005140.124B6895> dictionary2;
		object[] array;
		for (;;)
		{
			IL_06:
			num = 1160408627U + num;
			int num2 = this.107A346B;
			for (;;)
			{
				IL_15:
				num = 1589052865U * num;
				int num3 = 4D847142;
				num <<= 5;
				this.107A346B = num3;
				num /= 543315949U;
				num = 220036620U + num;
				ushort num4 = (ushort)this.0E1F2D8D();
				num = 1469452716U % num;
				Dictionary<int, 0B005140.124B6895> dictionary = new Dictionary<int, 0B005140.124B6895>();
				num = 1644514291U * num;
				dictionary2 = dictionary;
				num = (2082225097U ^ num);
				array = null;
				num &= 125785047U;
				uint num5 = (uint)num4;
				num += 1249736554U;
				if (num5 > num + 2922084181U)
				{
					if (num > 1713188204U)
					{
						goto IL_06;
					}
					int num6 = (int)num4;
					num = 1502174157U * num;
					array = new object[num6];
					num = 1213665953U / num;
					int num7 = (int)((uint)num4 - (num - uint.MaxValue));
					num = 1280445052U * num;
					int num8 = num7;
					if (1028795178U < num)
					{
						goto IL_06;
					}
					for (;;)
					{
						num -= 358445914U;
						if (num << 2 == 0U)
						{
							goto IL_06;
						}
						if (num8 < (int)(num ^ 3936521382U))
						{
							break;
						}
						num = 730364118U;
						if (1481187633U + num == 0U)
						{
							goto IL_06;
						}
						num = (1266301200U ^ num);
						0B005140.124B6895 124B = this.0BD76085();
						num /= 171861255U;
						if (num - 1746612820U == 0U)
						{
							goto IL_06;
						}
						bool flag = 124B.591DABE5();
						num ^= 2095808172U;
						if (flag)
						{
							if (num / 807425418U == 0U)
							{
								goto IL_06;
							}
							Dictionary<int, 0B005140.124B6895> dictionary3 = dictionary2;
							num += 1937206633U;
							int key = num8;
							num = 1029850503U % num;
							0B005140.124B6895 value = 124B;
							num = (2094034191U | num);
							dictionary3[key] = value;
							num += 4277735702U;
						}
						num += 2093302409U;
						if (num <= 535967699U)
						{
							goto IL_06;
						}
						object[] array2 = array;
						num %= 915750126U;
						int num9 = num8;
						num |= 102585933U;
						object 73FB30F = 124B;
						num = 1024619975U * num;
						int 041B468A = this.074259D8();
						num ^= 554238419U;
						Type 48EE707B = this.556E394E(041B468A);
						num = 569075359U + num;
						array2[num9] = this.33005A42(73FB30F, 48EE707B).611AD8EF();
						if (num > 1684497228U)
						{
							goto IL_15;
						}
						int num10 = num8;
						num = 796555519U - num;
						num8 = num10 - (int)(num ^ 4261300983U);
						num += 33666314U;
					}
					num ^= 3145073677U;
				}
				if (2084048553U % num == 0U)
				{
					goto IL_06;
				}
				int num11 = this.074259D8();
				num = 400906263U / num;
				int num12 = num11;
				if (num % 256915798U != 0U)
				{
					goto IL_06;
				}
				4D847142 = this.107A346B;
				if ((num & 584784064U) == 0U)
				{
					num ^= 506926157U;
					int num13 = num2;
					num = (533951002U | num);
					this.107A346B = num13;
					num /= 268720981U;
					if (!0A736953)
					{
						break;
					}
					if (1673078179U / num == 0U)
					{
						goto IL_06;
					}
					if (array != null)
					{
						num = 1532055150U - num;
						object[] array3 = array;
						num -= 4524321U;
						bool flag2 = array3[(int)(num ^ 1527530828U)];
						num ^= 1984984358U;
						num += 3533950871U;
						if (flag2)
						{
							break;
						}
						num ^= 0U;
					}
					if (num != 495147816U)
					{
						goto Block_19;
					}
				}
			}
			num |= 692998955U;
			if (num - 1826042906U != 0U)
			{
				goto Block_20;
			}
		}
		Block_19:
		throw new NullReferenceException();
		Block_20:
		0B005140 0B = new 0B005140();
		object[] 72C3372A = array;
		num = (346384258U ^ num);
		int 2CF265CD = 4D847142;
		num = (1945327138U & num);
		object obj = 0B.35C217A7(72C3372A, 2CF265CD);
		num = (1444879679U | num);
		object obj2 = obj;
		num <<= 13;
		Dictionary<int, 0B005140.124B6895>.Enumerator enumerator = dictionary2.GetEnumerator();
		num %= 2121676751U;
		using (Dictionary<int, 0B005140.124B6895>.Enumerator enumerator2 = enumerator)
		{
			for (;;)
			{
				for (;;)
				{
					num = 1302334389U * num;
					if (144974407U < num)
					{
						bool flag3 = enumerator2.MoveNext();
						num *= 717323799U;
						if (!flag3)
						{
							if ((num ^ 1957966099U) != 0U)
							{
								goto Block_27;
							}
						}
						else
						{
							num = 62216403U;
							KeyValuePair<int, 0B005140.124B6895> keyValuePair = enumerator2.Current;
							num = 1633634153U / num;
							KeyValuePair<int, 0B005140.124B6895> keyValuePair2 = keyValuePair;
							num -= 593830681U;
							0B005140.124B6895 value2 = keyValuePair2.Value;
							num = 2049600829U - num;
							object[] array4 = array;
							num ^= 1098582366U;
							num = 2076850861U - num;
							value2.53E5679E(array4[keyValuePair2.Key]);
							num ^= 4226025850U;
						}
					}
				}
			}
			Block_27:;
		}
		Type type2;
		for (;;)
		{
			num = 1584280984U;
			int num12;
			bool flag4 = num12 != 0;
			num ^= 1396459862U;
			if (!flag4)
			{
				goto IL_43F;
			}
			IL_3C0:
			num = (1014986424U | num);
			Type type = this.556E394E(num12);
			num -= 1144928182U;
			type2 = type;
			num = (794968961U | num);
			Type type3 = type2;
			num = 1406820117U << (int)num;
			RuntimeTypeHandle handle = typeof(void).TypeHandle;
			num = 1645442983U - num;
			Type typeFromHandle = Type.GetTypeFromHandle(handle);
			num -= 127931139U;
			num += 1738359338U;
			if (type3 != typeFromHandle)
			{
				if (num * 1775065350U != 0U)
				{
					break;
				}
				continue;
			}
			IL_43F:
			num = 1208557316U - num;
			if (num > 408366337U)
			{
				goto Block_24;
			}
			goto IL_3C0;
		}
		num <<= 22;
		object 73FB30F2 = obj2;
		num -= 656875940U;
		return this.33005A42(73FB30F2, type2);
		Block_24:
		return null;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x000CCFD0 File Offset: 0x000CCFD0
	private bool 09384B2D(object 664F17B7, Type 6AD65A21)
	{
		uint num;
		Type type;
		for (;;)
		{
			num = 1470698827U;
			if (664F17B7 == null)
			{
				break;
			}
			if (1822300650U >= num)
			{
				num |= 1090389611U;
				type = 664F17B7.GetType();
				num /= 1276464824U;
				if (1790338886U / num != 0U)
				{
					goto Block_2;
				}
			}
		}
		num = (1209820268U ^ num);
		return (num ^ 531984678U) != 0U;
		Block_2:
		Type type2 = type;
		num &= 1147145246U;
		if (type2 != 6AD65A21)
		{
			if (!6AD65A21.IsAssignableFrom(type))
			{
				num /= 1708815396U;
				return num - 0U != 0U;
			}
			num ^= 0U;
		}
		return (num ^ 1U) != 0U;
	}

	// Token: 0x06000123 RID: 291 RVA: 0x000CD064 File Offset: 0x000CD064
	private void 21C44FC8(Exception 3638383C)
	{
		uint num;
		for (;;)
		{
			IL_00:
			num = 1072259852U;
			this.09B46D51.Clear();
			if (num == 1699366147U)
			{
				goto IL_49;
			}
			do
			{
				IL_1E:
				Stack<int> stack = this.5836773B;
				num = (1041521115U | num);
				stack.Clear();
				num = (396843920U ^ num);
			}
			while (967602535U < num);
			IL_49:
			bool flag = this.38763065 != null;
			num /= 1272599011U;
			if (!flag)
			{
				num = 792278195U - num;
				goto IL_68;
			}
			0B005140.516357D5 516357D3;
			for (;;)
			{
				IL_6A3:
				num = (497493660U | num);
				Stack<0B005140.11482F88> stack2 = this.410C421C;
				num = 1769349429U % num;
				if (stack2.Count == 0)
				{
					goto Block_33;
				}
				List<0B005140.516357D5> list;
				do
				{
					num = 1922710442U;
					if (1622351947U >= num)
					{
						goto IL_00;
					}
					list = this.410C421C.Peek().6C5F487C();
					for (;;)
					{
						IL_C3:
						bool flag2 = this.38763065 != null;
						num |= 1487359925U;
						int num4;
						if (flag2)
						{
							if ((652415984U & num) == 0U)
							{
								goto IL_1E;
							}
							int num2 = list.IndexOf(this.38763065);
							num = 1361597588U + num;
							int num3 = (int)(num ^ 3420968018U);
							num *= 153948745U;
							num4 = num2 + num3;
						}
						else
						{
							num4 = (int)(num + 2235596865U);
							num += 887153132U;
						}
						0B005140.516357D5 516357D = null;
						num = 1397102291U >> (int)num;
						this.38763065 = 516357D;
						num = (121980322U & num);
						int num5 = num4;
						if (num << 16 != 0U)
						{
							while ((num ^ 1656902938U) != 0U)
							{
								int num6 = num5;
								num /= 828794613U;
								List<0B005140.516357D5> list2 = list;
								num ^= 846666198U;
								if (num6 >= list2.Count)
								{
									goto Block_21;
								}
								num = 1769287069U;
								List<0B005140.516357D5> list3 = list;
								num <<= 9;
								0B005140.516357D5 516357D2 = list3[num5];
								num %= 1828019181U;
								516357D3 = 516357D2;
								if ((1561658723U ^ num) == 0U)
								{
									goto IL_00;
								}
								0B005140.516357D5 516357D4 = 516357D3;
								num += 1491105566U;
								byte b = 516357D4.79A84666();
								num -= 2047872804U;
								byte b2 = b;
								num |= 2142707271U;
								if (b2 != 0)
								{
									num *= 325472944U;
									byte b3 = b2;
									num = 1044867228U - num;
									uint num7 = num ^ 3527508941U;
									num = 966595774U * num;
									if (b3 == num7)
									{
										goto IL_36F;
									}
								}
								else
								{
									if (num % 1735020261U == 0U)
									{
										goto IL_00;
									}
									Type type = 3638383C.GetType();
									num = 2070744822U >> (int)num;
									Type type2 = type;
									num %= 246574727U;
									num |= 1336871783U;
									0B005140.516357D5 516357D5 = 516357D3;
									num %= 1764770222U;
									Type type3 = this.556E394E(516357D5.400A0B48());
									if (num >= 2020234081U)
									{
										goto IL_00;
									}
									Type type4 = type2;
									num &= 1857028283U;
									if (type4 != type3)
									{
										num = 1215435883U * num;
										if (1114200324U >> (int)num == 0U)
										{
											goto IL_00;
										}
										Type type5 = type2;
										Type c = type3;
										num = (1544438567U & num);
										bool flag3 = type5.IsSubclassOf(c);
										num ^= 1575159731U;
										num += 1629403606U;
										if (!flag3)
										{
											goto IL_3F0;
										}
										num ^= 632799571U;
									}
									num >>= 27;
									if (1010650716U >> (int)num != 0U)
									{
										goto Block_14;
									}
									goto IL_C3;
								}
								IL_3F0:
								num = 87259275U << (int)num;
								int num8 = num5;
								int num9 = (int)(num ^ 863537921U);
								num = 151784493U - num;
								int num10 = num8 + num9;
								num += 2050182797U;
								num5 = num10;
								num ^= 1338412856U;
							}
							goto IL_1E;
						}
						goto IL_1E;
					}
					Block_21:;
				}
				while (1099441758U >> (int)num == 0U);
				num %= 700661776U;
				Stack<0B005140.11482F88> stack3 = this.410C421C;
				num = (867633928U | num);
				stack3.Pop();
				num |= 230840477U;
				num /= 1097342665U;
				List<0B005140.516357D5> list4 = list;
				num = (795762103U & num);
				int num11 = list4.Count;
				if (420086925U <= num)
				{
					goto IL_68;
				}
				for (;;)
				{
					uint num12 = (uint)num11;
					num <<= 11;
					if (num12 <= (num ^ 0U))
					{
						break;
					}
					List<0B005140.516357D5> list5 = list;
					num = 1516600578U;
					int num13 = num11;
					num = 1629753631U >> (int)num;
					0B005140.516357D5 516357D6 = list5[num13 - (int)(num ^ 407438406U)];
					num -= 940530774U;
					0B005140.516357D5 516357D7 = 516357D6;
					num = (435432297U | num);
					if (num != 1430138622U)
					{
						uint num14 = (uint)516357D7.79A84666();
						num %= 307365685U;
						if (num14 == num + 4096568762U)
						{
							goto IL_584;
						}
						num |= 1091267286U;
						if (num / 350647314U == 0U)
						{
							goto IL_00;
						}
						0B005140.516357D5 516357D8 = 516357D7;
						num &= 1115694862U;
						byte b4 = 516357D8.79A84666();
						num = 965823224U >> (int)num;
						uint num15 = num - 58945U;
						num /= 1630089747U;
						if (b4 == num15)
						{
							num += 198398536U;
							goto IL_584;
						}
						IL_5B4:
						num *= 1496936607U;
						if (1613319929U - num != 0U)
						{
							int num16 = num11;
							num = 187052429U * num;
							int num17 = (int)(num ^ 1U);
							num = 1723940594U >> (int)num;
							num11 = num16 - num17;
							num += 2571026702U;
							continue;
						}
						goto IL_1E;
						IL_584:
						num |= 2057176448U;
						Stack<int> stack4 = this.5836773B;
						int item = 516357D7.147B6C82();
						num += 2011192093U;
						stack4.Push(item);
						num += 205540635U;
						goto IL_5B4;
					}
					goto IL_1E;
				}
				if (1548830601 << (int)num == 0)
				{
					goto IL_00;
				}
				num ^= 1701330830U;
				bool count = this.5836773B.Count != 0;
				num ^= 998706856U;
				num ^= 1592733990U;
				if (count)
				{
					goto Block_31;
				}
			}
			Block_14:
			num /= 1855139056U;
			this.410C421C.Pop();
			num = (797199684U | num);
			if (1542656025U <= num)
			{
				continue;
			}
			num |= 1613963444U;
			Stack<0B005140.375D71A4> stack5 = this.09B46D51;
			num = 158992735U + num;
			num = 1041783400U * num;
			0B005140.375D71A4 item2 = new 0B005140.744E73A6(this.2EA261BB);
			num += 475098493U;
			stack5.Push(item2);
			num = (549929473U ^ num);
			num *= 196108321U;
			0B005140.516357D5 516357D9 = 516357D3;
			num /= 331092041U;
			int num18 = 516357D9.147B6C82();
			num = (510811755U ^ num);
			this.107A346B = num18;
			if (257115539U <= num)
			{
				break;
			}
			continue;
			IL_36F:
			if (2132949746U % num == 0U)
			{
				goto IL_1E;
			}
			num >>= 19;
			this.38763065 = 516357D3;
			num &= 210965845U;
			if (num >= 1623867132U)
			{
				goto IL_1E;
			}
			Stack<0B005140.375D71A4> stack6 = this.09B46D51;
			num /= 775636088U;
			num = 1754944397U + num;
			stack6.Push(new 0B005140.744E73A6(this.2EA261BB));
			num <<= 31;
			this.107A346B = 516357D3.400A0B48();
			if (num >= 1575657U)
			{
				return;
			}
			continue;
			Block_31:
			num = 1054802007U * num;
			if (1160645582 << (int)num != 0)
			{
				goto Block_32;
			}
			continue;
			Block_33:
			if ((num & 425994707U) != 0U)
			{
				goto Block_34;
			}
			goto IL_1E;
			IL_68:
			num = 2003851599U + num;
			num = 387928150U - num;
			this.2EA261BB = 3638383C;
			if (num + 1078550350U != 0U)
			{
				num ^= 1886765652U;
				goto IL_6A3;
			}
		}
		return;
		Block_32:
		num >>= 8;
		num *= 53369721U;
		int num19 = this.5836773B.Pop();
		num = (377912995U | num);
		this.107A346B = num19;
		return;
		Block_34:
		throw 3638383C;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x000CD748 File Offset: 0x000CD748
	private void 5AD53B14()
	{
		uint num = 826761920U;
		if (2045667747U / num == 0U)
		{
			goto IL_B3;
		}
		IL_12:
		num = 1602762725U / num;
		0B005140.124B6895 124B = this.0BD76085();
		num = 918423716U + num;
		Type type = this.556E394E(124B.DCFDB33F());
		0B005140.124B6895 124B2 = this.0BD76085();
		num = (8928090U | num);
		0B005140.124B6895 124B3 = 124B2;
		num = 1995061728U + num;
		0B005140.124B6895 124B5;
		do
		{
			num |= 190982571U;
			num *= 1415732703U;
			0B005140.124B6895 124B4 = this.0BD76085();
			num *= 2135061751U;
			object 73FB30F = 124B4.611AD8EF();
			Type 48EE707B = type;
			num = 1998875148U >> (int)num;
			124B5 = this.33005A42(73FB30F, 48EE707B);
			0B005140.124B6895 124B6 = 124B3;
			num += 1219976211U;
			bool flag = 124B6.591DABE5();
			num = 2015823852U - num;
			if (!flag)
			{
				goto IL_CB;
			}
			num = (1715625139U & num);
		}
		while ((1053900600U & num) == 0U);
		IL_B3:
		0B005140.124B6895 124B7 = new 0B005140.0A626AC2(124B5, 124B3);
		num |= 371153099U;
		124B5 = 124B7;
		num += 4178596352U;
		IL_CB:
		num = (1936272819U & num);
		List<0B005140.124B6895> list = this.578B1C04;
		num <<= 29;
		0B005140.124B6895 item = 124B5;
		num = 1629489137U - num;
		list.Add(item);
		if (num != 582491662U)
		{
			return;
		}
		goto IL_12;
	}

	// Token: 0x06000125 RID: 293 RVA: 0x000CD850 File Offset: 0x000CD850
	private void 14136211()
	{
		int num = this.0BD76085().DCFDB33F();
		uint num2 = 629700348U;
		int num3 = num;
		num2 = 1015613137U + num2;
		List<0B005140.11482F88> list = this.4E1277A9;
		num2 /= 254816208U;
		List<0B005140.11482F88>.Enumerator enumerator = list.GetEnumerator();
		try
		{
			if ((num2 & 743645428U) != 0U)
			{
				goto IL_85;
			}
			IL_3F:
			0B005140.11482F88 11482F = enumerator.Current;
			num2 = 1684364142U;
			0B005140.11482F88 11482F2 = 11482F;
			0B005140.11482F88 11482F3 = 11482F2;
			num2 -= 332611136U;
			int num4 = 11482F3.4BB56715();
			int num5 = num3;
			num2 = 1594519136U % num2;
			num2 ^= 242766132U;
			if (num4 == num5)
			{
				this.410C421C.Push(11482F2);
				num2 ^= 0U;
			}
			IL_85:
			num2 >>= 2;
			num2 -= 1490949594U;
			if (enumerator.MoveNext())
			{
				goto IL_3F;
			}
		}
		finally
		{
			do
			{
				num2 = 2047807384U;
				((IDisposable)enumerator).Dispose();
			}
			while ((1817728209U & num2) == 0U);
		}
	}

	// Token: 0x06000126 RID: 294 RVA: 0x000CD934 File Offset: 0x000CD934
	private void 5A914153()
	{
		uint num = 532104025U;
		if (num <= 2001221276U)
		{
			do
			{
				num = (1708270548U & num);
				int 0D6B27B = this.074259D8();
				num = 1129725610U - num;
				this.2D04165D(new 0B005140.07685083(0D6B27B));
			}
			while (2051883674U == num);
		}
	}

	// Token: 0x06000127 RID: 295 RVA: 0x000CD980 File Offset: 0x000CD980
	private void 75395636()
	{
		uint num;
		do
		{
			0B005140.124B6895 23717D = new 0B005140.13AF7E46(this.6BE55D80());
			num = 128476950U;
			this.2D04165D(23717D);
		}
		while (num * 394221653U == 0U);
	}

	// Token: 0x06000128 RID: 296 RVA: 0x000CD9B0 File Offset: 0x000CD9B0
	private void 5DA526D1()
	{
		uint num = 2113342644U;
		if (num * 1822784044U != 0U)
		{
			do
			{
				num /= 1008555095U;
				float 474F1D1D = this.01DC17F4();
				num *= 1634039479U;
				0B005140.124B6895 23717D = new 0B005140.721F5C60(474F1D1D);
				num &= 2127838743U;
				this.2D04165D(23717D);
			}
			while (379858048U > num);
		}
	}

	// Token: 0x06000129 RID: 297 RVA: 0x000CDA04 File Offset: 0x000CDA04
	private void 50D41666()
	{
		uint num;
		do
		{
			num = 826817402U;
			num = 109135753U % num;
			double 702B = this.40176C9C();
			num += 484468931U;
			0B005140.124B6895 23717D = new 0B005140.6B6D1F66(702B);
			num += 1218976134U;
			this.2D04165D(23717D);
		}
		while ((1357344148U ^ num) == 0U);
	}

	// Token: 0x0600012A RID: 298 RVA: 0x000CDA4C File Offset: 0x000CDA4C
	private void 3E50525D()
	{
		object 4E = null;
		uint num = 1798768602U;
		0B005140.124B6895 23717D = new 0B005140.744E73A6(4E);
		num = 1714650317U + num;
		this.2D04165D(23717D);
	}

	// Token: 0x0600012B RID: 299 RVA: 0x000CDA74 File Offset: 0x000CDA74
	private void 51C6440E()
	{
		uint num = 1747084855U;
		0B005140.124B6895 124B = this.0BD76085();
		num %= 802234349U;
		string <<EMPTY_NAME>> = this.11A061CA(124B.DCFDB33F());
		num |= 1651387772U;
		this.2D04165D(new 0B005140.3C1E7579(<<EMPTY_NAME>>));
	}

	// Token: 0x0600012C RID: 300 RVA: 0x000CDAB4 File Offset: 0x000CDAB4
	private void 721F15E5()
	{
		uint num = 1238372320U;
		do
		{
			num &= 1048251358U;
			0B005140.124B6895 23717D = this.261921B8().1FB8DBBA();
			num >>= 31;
			this.2D04165D(23717D);
		}
		while (num == 1877561435U);
	}

	// Token: 0x0600012D RID: 301 RVA: 0x000CDAF4 File Offset: 0x000CDAF4
	private void 2A960EA9()
	{
		0B005140.124B6895 124B = this.0BD76085();
		uint num = 333778805U;
		0B005140.124B6895 124B2 = 124B;
		0B005140.124B6895 124B3;
		if (num < 777202101U)
		{
			num = 367662784U >> (int)num;
			124B3 = this.0BD76085();
			num >>= 8;
		}
		num %= 432034011U;
		num /= 619460657U;
		0B005140.124B6895 0180289E = 124B2;
		0B005140.124B6895 44730D = 124B3;
		bool 2FC51F2C = (num ^ 0U) != 0U;
		num = 1516975048U * num;
		0B005140.124B6895 23717D = this.097918FD(0180289E, 44730D, 2FC51F2C, num + 0U != 0U);
		num *= 1217098198U;
		this.2D04165D(23717D);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x000CDB74 File Offset: 0x000CDB74
	private void 556B5BE8()
	{
		uint num = 747714364U;
		0B005140.124B6895 124B = this.0BD76085();
		if (num - 1911244263U == 0U)
		{
			goto IL_49;
		}
		IL_19:
		num = 1201759815U >> (int)num;
		0B005140.124B6895 124B2 = this.0BD76085();
		num = (148983986U | num);
		0B005140.124B6895 124B3 = 124B2;
		num = 1102713609U % num;
		if (1826894042U == num)
		{
			return;
		}
		IL_49:
		0B005140.124B6895 0180289E = 124B;
		num = 784550483U - num;
		0B005140.124B6895 44730D = 124B3;
		bool 2FC51F2C = num - 724724803U != 0U;
		num = 1860788590U << (int)num;
		bool 22F5584E = (num ^ 4002813664U) != 0U;
		num = 1575571264U + num;
		this.2D04165D(this.097918FD(0180289E, 44730D, 2FC51F2C, 22F5584E));
		if (num <= 1062693495U)
		{
			goto IL_19;
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x000CDC10 File Offset: 0x000CDC10
	private void 5D146CD8()
	{
		uint num = 91231548U;
		0B005140.124B6895 124B2;
		do
		{
			num = (1913483494U | num);
			0B005140.124B6895 124B = this.0BD76085();
			num &= 1399006820U;
			124B2 = 124B;
		}
		while (1804230628U < num);
		0B005140.124B6895 124B3 = this.0BD76085();
		num &= 399387662U;
		0B005140.124B6895 44730D = 124B3;
		num >>= 24;
		if ((941428777U ^ num) != 0U)
		{
			num = 1759790740U * num;
			num >>= 23;
			0B005140.124B6895 0180289E = 124B2;
			num -= 1517246411U;
			this.2D04165D(this.097918FD(0180289E, 44730D, num + 1517246011U != 0U, (num ^ 2777721287U) != 0U));
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x000CDC9C File Offset: 0x000CDC9C
	private void 5023492D()
	{
		uint num = 1261596880U;
		0B005140.124B6895 124B = this.0BD76085();
		do
		{
			0B005140.124B6895 124B2 = this.0BD76085();
			num = 1715275046U - num;
			0B005140.124B6895 124B3 = 124B2;
			num = (1541027704U ^ num);
			num >>= 28;
			0B005140.124B6895 1212438F = 124B3;
			0B005140.124B6895 0E2E5EBB = 124B;
			bool 32C920AF = num - 4U != 0U;
			num |= 1267729176U;
			this.2D04165D(this.21D71344(1212438F, 0E2E5EBB, 32C920AF, (num ^ 1267729180U) != 0U));
		}
		while (num == 800613543U);
	}

	// Token: 0x06000131 RID: 305 RVA: 0x000CDD04 File Offset: 0x000CDD04
	private void 253C6BB5()
	{
		uint num = 252190687U;
		0B005140.124B6895 124B = this.0BD76085();
		num ^= 858590609U;
		0B005140.124B6895 124B2 = 124B;
		num *= 484855672U;
		num *= 13656289U;
		0B005140.124B6895 124B3 = this.0BD76085();
		num ^= 297822667U;
		0B005140.124B6895 124B4 = 124B3;
		num = 92428630U / num;
		num = (415652124U ^ num);
		0B005140.124B6895 1212438F = 124B4;
		num = (1108167735U | num);
		0B005140.124B6895 0E2E5EBB = 124B2;
		num >>= 0;
		bool 32C920AF = num + 2771428034U != 0U;
		num >>= 27;
		bool 273A = (num ^ 11U) != 0U;
		num *= 990661216U;
		0B005140.124B6895 23717D = this.21D71344(1212438F, 0E2E5EBB, 32C920AF, 273A);
		num >>= 27;
		this.2D04165D(23717D);
	}

	// Token: 0x06000132 RID: 306 RVA: 0x000CDD9C File Offset: 0x000CDD9C
	private void 37CC26B6()
	{
		uint num = 1550079465U;
		0B005140.124B6895 124B = this.0BD76085();
		num -= 839322358U;
		0B005140.124B6895 124B2 = 124B;
		num = 722801611U / num;
		num ^= 1936791815U;
		0B005140.124B6895 124B3 = this.0BD76085();
		num += 709649820U;
		0B005140.124B6895 124B4 = 124B3;
		if (1437355343U + num != 0U)
		{
			num -= 1835605058U;
			0B005140.124B6895 1212438F = 124B4;
			0B005140.124B6895 0E2E5EBB = 124B2;
			bool 32C920AF = num + 3484130721U != 0U;
			bool 273A = (num ^ 810836577U) != 0U;
			num &= 1320886729U;
			0B005140.124B6895 23717D = this.21D71344(1212438F, 0E2E5EBB, 32C920AF, 273A);
			num = (337525999U | num);
			this.2D04165D(23717D);
		}
	}

	// Token: 0x06000133 RID: 307 RVA: 0x000CDE20 File Offset: 0x000CDE20
	private void 0B5D0864()
	{
		uint num;
		0B005140.124B6895 124B2;
		0B005140.124B6895 124B4;
		for (;;)
		{
			0B005140.124B6895 124B = this.0BD76085();
			num = 928210548U;
			124B2 = 124B;
			if (num != 2107775372U)
			{
				0B005140.124B6895 124B3 = this.0BD76085();
				num <<= 16;
				124B4 = 124B3;
				num *= 2048066378U;
				if (num > 685407395U)
				{
					break;
				}
			}
		}
		do
		{
			num /= 416629644U;
			0B005140.124B6895 1C9465A = 124B4;
			num <<= 25;
			0B005140.124B6895 33A759BC = 124B2;
			bool 540408C = (num ^ 201326592U) != 0U;
			bool 0433778B = (num ^ 201326592U) != 0U;
			num = 670379101U / num;
			0B005140.124B6895 23717D = this.447B6411(1C9465A, 33A759BC, 540408C, 0433778B);
			num = (1061765729U ^ num);
			this.2D04165D(23717D);
		}
		while (1573420382U % num == 0U);
	}

	// Token: 0x06000134 RID: 308 RVA: 0x000CDEB0 File Offset: 0x000CDEB0
	private void 12C527F0()
	{
		uint num = 1335654379U;
		num &= 137248549U;
		0B005140.124B6895 124B = this.0BD76085();
		do
		{
			0B005140.124B6895 124B2 = this.0BD76085();
			num = 784607315U % num;
			0B005140.124B6895 124B3 = 124B2;
			num -= 1106645699U;
			0B005140.124B6895 1C9465A = 124B3;
			0B005140.124B6895 33A759BC = 124B;
			num = (2040272369U ^ num);
			bool 540408C = (num ^ 3171750939U) != 0U;
			num ^= 1328043033U;
			0B005140.124B6895 23717D = this.447B6411(1C9465A, 33A759BC, 540408C, num - 4062527491U != 0U);
			num = (1404054435U ^ num);
			this.2D04165D(23717D);
		}
		while (num <= 1499948564U);
	}

	// Token: 0x06000135 RID: 309 RVA: 0x000CDF28 File Offset: 0x000CDF28
	private void 617B47EC()
	{
		for (;;)
		{
			0B005140.124B6895 124B = this.0BD76085();
			uint num = 2107130910U;
			if (1010966540U <= num)
			{
				num -= 350508067U;
				0B005140.124B6895 124B2 = this.0BD76085();
				num >>= 1;
				0B005140.124B6895 124B3 = 124B2;
				num = 1726308164U / num;
				0B005140.124B6895 1C9465A = 124B3;
				num = 1884952630U * num;
				0B005140.124B6895 33A759BC = 124B;
				num = (2033649955U ^ num);
				bool 540408C = num - 158142740U != 0U;
				num = 910896720U + num;
				this.2D04165D(this.447B6411(1C9465A, 33A759BC, 540408C, (num ^ 1069039460U) != 0U));
				if (num <= 1428510523U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x000CDFAC File Offset: 0x000CDFAC
	private void 20D0612C()
	{
		uint num = 870534267U;
		0B005140.124B6895 124B;
		0B005140.124B6895 124B3;
		if (574439647U < num)
		{
			124B = this.0BD76085();
			num -= 465320239U;
			num >>= 4;
			0B005140.124B6895 124B2 = this.0BD76085();
			num = 2083866648U + num;
			124B3 = 124B2;
		}
		num *= 324304450U;
		0B005140.124B6895 <<EMPTY_NAME>> = 124B3;
		0B005140.124B6895 38D742A = 124B;
		bool 2 = (num ^ 1199648152U) != 0U;
		num <<= 11;
		this.2D04165D(this.60953A65(<<EMPTY_NAME>>, 38D742A, 2));
	}

	// Token: 0x06000137 RID: 311 RVA: 0x000CE018 File Offset: 0x000CE018
	private void 2FF10145()
	{
		uint num;
		0B005140.124B6895 38D742A;
		0B005140.124B6895 124B2;
		do
		{
			num = 1395985024U;
			38D742A = this.0BD76085();
			num = (1875324950U | num);
			num >>= 16;
			0B005140.124B6895 124B = this.0BD76085();
			num *= 27602595U;
			124B2 = 124B;
			num = 1043992044U << (int)num;
		}
		while ((1290670462U ^ num) == 0U);
		do
		{
			num = 1879015179U - num;
			0B005140.124B6895 <<EMPTY_NAME>> = 124B2;
			num &= 352997642U;
			0B005140.124B6895 23717D = this.60953A65(<<EMPTY_NAME>>, 38D742A, num + 4294426359U != 0U);
			num = 1033180373U - num;
			this.2D04165D(23717D);
		}
		while (num == 219694657U);
	}

	// Token: 0x06000138 RID: 312 RVA: 0x000CE0A4 File Offset: 0x000CE0A4
	private void 4CCE0252()
	{
		uint num = 200693129U;
		num = (2061385207U & num);
		0B005140.124B6895 124B = this.0BD76085();
		num = 628184100U << (int)num;
		0B005140.124B6895 124B2 = 124B;
		0B005140.124B6895 124B3;
		if (1806252391U >= num)
		{
			num = 1198523808U % num;
			124B3 = this.0BD76085();
		}
		num = 1796552070U % num;
		0B005140.124B6895 06052C4E = 124B3;
		num = 767830023U * num;
		0B005140.124B6895 <<EMPTY_NAME>> = 124B2;
		num *= 154630913U;
		bool 5F2F75B = (num ^ 3160853834U) != 0U;
		num = (359941346U | num);
		0B005140.124B6895 23717D = this.5B4F582F(06052C4E, <<EMPTY_NAME>>, 5F2F75B);
		num = 2124640174U % num;
		this.2D04165D(23717D);
	}

	// Token: 0x06000139 RID: 313 RVA: 0x000CE12C File Offset: 0x000CE12C
	private void 555A0DB3()
	{
		0B005140.124B6895 124B = this.0BD76085();
		uint num = 1914908661U;
		num |= 823531032U;
		0B005140.124B6895 124B2 = this.0BD76085();
		num %= 420354871U;
		num /= 341254653U;
		0B005140.124B6895 06052C4E = 124B2;
		0B005140.124B6895 <<EMPTY_NAME>> = 124B;
		bool 5F2F75B = num - uint.MaxValue != 0U;
		num = 1557675961U >> (int)num;
		0B005140.124B6895 23717D = this.5B4F582F(06052C4E, <<EMPTY_NAME>>, 5F2F75B);
		num <<= 28;
		this.2D04165D(23717D);
	}

	// Token: 0x0600013A RID: 314 RVA: 0x000CE190 File Offset: 0x000CE190
	private void 6BCA29D4()
	{
		uint num = 2093355504U;
		do
		{
			num += 1333605389U;
			0B005140.124B6895 124B = this.0BD76085();
			num = 1435136533U - num;
			0B005140.124B6895 124B2 = this.0BD76085();
			num += 924470579U;
			0B005140.124B6895 124B3 = 124B2;
			num = 1689546197U / num;
			num = 893793015U >> (int)num;
			0B005140.124B6895 02D043E = 124B3;
			0B005140.124B6895 45C87D = 124B;
			num |= 739011593U;
			this.2D04165D(this.201B029C(02D043E, 45C87D));
		}
		while ((1281645241U ^ num) == 0U);
	}

	// Token: 0x0600013B RID: 315 RVA: 0x000CE204 File Offset: 0x000CE204
	private void 5DB25352()
	{
		uint num = 1542404561U;
		0B005140.124B6895 124B = this.0BD76085();
		num = 1142775151U - num;
		0B005140.124B6895 620E313F = 124B;
		num += 1350371883U;
		0B005140.124B6895 124B2 = this.0BD76085();
		num = 999052967U / num;
		0B005140.124B6895 124B3 = 124B2;
		num = 1345335275U + num;
		0B005140.124B6895 14CE4C = 124B3;
		num = (2002209985U | num);
		this.2D04165D(this.2FE94915(14CE4C, 620E313F));
	}

	// Token: 0x0600013C RID: 316 RVA: 0x000CE25C File Offset: 0x000CE25C
	private void 6D3963E2()
	{
		uint num = 1278832669U;
		0B005140.124B6895 124B = this.0BD76085();
		num += 271080024U;
		0B005140.124B6895 124B2 = 124B;
		0B005140.124B6895 124B3;
		if (num != 949436739U)
		{
			do
			{
				124B3 = this.0BD76085();
			}
			while (885620497U - num == 0U);
		}
		0B005140.124B6895 3D5E49D = 124B3;
		0B005140.124B6895 2A8824D = 124B2;
		num = (1908609246U | num);
		0B005140.124B6895 23717D = this.42A22042(3D5E49D, 2A8824D);
		num = (839078423U & num);
		this.2D04165D(23717D);
	}

	// Token: 0x0600013D RID: 317 RVA: 0x000CE2BC File Offset: 0x000CE2BC
	private void 54B95DF1()
	{
		uint num = 179725798U;
		if (num * 1836737148U != 0U)
		{
			num /= 416439225U;
			0B005140.124B6895 124B = this.0BD76085();
			num /= 1683831233U;
			0B005140.124B6895 124B2 = 124B;
			if (336789571 << (int)num != 0)
			{
				0B005140.124B6895 602D02A = 124B2;
				num = (764949309U ^ num);
				0B005140.124B6895 23717D = this.4A8D17D4(602D02A);
				num %= 1310207543U;
				this.2D04165D(23717D);
			}
		}
	}

	// Token: 0x0600013E RID: 318 RVA: 0x000CE324 File Offset: 0x000CE324
	private void 608029DD()
	{
		uint num;
		0B005140.124B6895 67B354DA;
		do
		{
			num = 441937755U;
			0B005140.124B6895 124B = this.0BD76085();
			num ^= 2043423586U;
			67B354DA = 124B;
			num = 242818080U % num;
		}
		while ((num & 1720605575U) == 0U);
		do
		{
			num = (910109985U & num);
			this.2D04165D(this.4BBA5C85(67B354DA));
		}
		while ((num & 482034454U) == 0U);
	}

	// Token: 0x0600013F RID: 319 RVA: 0x000CE37C File Offset: 0x000CE37C
	private void 17987A23()
	{
		0B005140.124B6895 124B;
		0B005140.124B6895 124B2;
		uint num;
		do
		{
			124B = this.0BD76085();
			124B2 = this.0BD76085();
			num = 1120087447U;
		}
		while (1888294311U <= num);
		num = 1529109700U - num;
		0B005140.124B6895 7361750D = 124B2;
		0B005140.124B6895 6AB = 124B;
		num = (1400774148U | num);
		bool 571773B = (num ^ 1535065901U) != 0U;
		num = (2127184972U & num);
		this.2D04165D(this.65A21502(7361750D, 6AB, 571773B));
	}

	// Token: 0x06000140 RID: 320 RVA: 0x000CE3D8 File Offset: 0x000CE3D8
	private void 73B7760D()
	{
		uint num;
		0B005140.124B6895 124B2;
		0B005140.124B6895 124B4;
		for (;;)
		{
			0B005140.124B6895 124B = this.0BD76085();
			num = 1900875778U;
			124B2 = 124B;
			if ((num & 174538576U) != 0U)
			{
				0B005140.124B6895 124B3 = this.0BD76085();
				num %= 1333993035U;
				124B4 = 124B3;
				num *= 1611494223U;
				if (1508778272U >> (int)num != 0U)
				{
					break;
				}
			}
		}
		num %= 490605008U;
		num *= 652353695U;
		0B005140.124B6895 7361750D = 124B4;
		num -= 79233930U;
		0B005140.124B6895 6AB = 124B2;
		bool 571773B = (num ^ 2710969244U) != 0U;
		num &= 245240470U;
		0B005140.124B6895 23717D = this.65A21502(7361750D, 6AB, 571773B);
		num = 1444876104U >> (int)num;
		this.2D04165D(23717D);
	}

	// Token: 0x06000141 RID: 321 RVA: 0x000CE46C File Offset: 0x000CE46C
	private void 69C70694()
	{
		uint num = 850018892U;
		if (num >> 1 == 0U)
		{
			goto IL_21;
		}
		IL_12:
		num = 1352022351U % num;
		0B005140.124B6895 124B = this.0BD76085();
		IL_21:
		0B005140.124B6895 124B2 = this.0BD76085();
		num = 483333145U - num;
		num %= 1776222767U;
		0B005140.124B6895 438122D = 124B2;
		num = (1946959520U ^ num);
		0B005140.124B6895 19CA334E = 124B;
		num = (1387669454U | num);
		0B005140.124B6895 23717D = this.6F2C0E7F(438122D, 19CA334E);
		num = 1993367391U - num;
		this.2D04165D(23717D);
		if ((1409438424U ^ num) != 0U)
		{
			return;
		}
		goto IL_12;
	}

	// Token: 0x06000142 RID: 322 RVA: 0x000CE4E4 File Offset: 0x000CE4E4
	private void 4FAD3F96()
	{
		uint num = 101005211U;
		do
		{
			num |= 1401511383U;
			Type type = this.556E394E(this.0BD76085().DCFDB33F());
			num %= 1642927666U;
			if (644570061U + num == 0U)
			{
				break;
			}
			num = 2058630123U - num;
			num <<= 19;
			num /= 1633838661U;
			object 73FB30F = this.0BD76085();
			Type 48EE707B = type;
			num >>= 23;
			this.2D04165D(this.33005A42(73FB30F, 48EE707B));
		}
		while (num > 1192054213U);
	}

	// Token: 0x06000143 RID: 323 RVA: 0x000CE564 File Offset: 0x000CE564
	private void 512E6F9A()
	{
		uint num;
		do
		{
			num = 1766659013U;
			num /= 2041987643U;
			0B005140.124B6895 124B = this.0BD76085();
			num = 318060369U * num;
			int 041B468A = 124B.DCFDB33F();
			num += 1203400680U;
			Type type = this.556E394E(041B468A);
			num = (197094490U | num);
			if (num == 1345416582U)
			{
				break;
			}
			num = (1912096512U | num);
			num &= 600006603U;
			0B005140.124B6895 124B2 = this.0BD76085();
			num = 225930334U >> (int)num;
			this.2D04165D(this.33005A42(124B2.FBC53937(type, (num ^ 220635U) != 0U), type));
		}
		while (num - 979661890U == 0U);
	}

	// Token: 0x06000144 RID: 324 RVA: 0x000CE600 File Offset: 0x000CE600
	private void 752C72A8()
	{
		uint num = 578819272U;
		0B005140.124B6895 124B = this.0BD76085();
		num /= 1871930486U;
		Type type = this.556E394E(124B.DCFDB33F());
		num = 2061663609U - num;
		if (num >= 1923171265U)
		{
			num -= 11935885U;
			0B005140.124B6895 124B2 = this.0BD76085();
			num -= 303462124U;
			object 73FB30F = 124B2.FBC53937(type, (num ^ 1746265601U) != 0U);
			Type 48EE707B = type;
			num *= 87322544U;
			this.2D04165D(this.33005A42(73FB30F, 48EE707B));
		}
	}

	// Token: 0x06000145 RID: 325 RVA: 0x000CE678 File Offset: 0x000CE678
	private void 7D8B090C()
	{
		uint num = 2090826306U;
		if (num > 1799036217U)
		{
			do
			{
				num ^= 1315855013U;
				num = 1497003453U << (int)num;
				int 041B468A = this.074259D8();
				num = (1874358539U & num);
				Type t = this.556E394E(041B468A);
				num = 844434062U + num;
				0B005140.124B6895 23717D = new 0B005140.07685083(Marshal.SizeOf(t));
				num += 365897083U;
				this.2D04165D(23717D);
			}
			while (843057317 << (int)num == 0);
		}
	}

	// Token: 0x06000146 RID: 326 RVA: 0x000CE6F4 File Offset: 0x000CE6F4
	private void 7F7E38F7()
	{
		uint num;
		do
		{
			IL_00:
			Type type = this.556E394E(this.0BD76085().DCFDB33F());
			num = 1964841835U;
			Type type2 = type;
			num = (604122026U ^ num);
			for (;;)
			{
				0B005140.124B6895 124B = this.0BD76085();
				num %= 811338121U;
				0B005140.124B6895 124B2 = 124B;
				num /= 405503420U;
				bool flag = 124B2.591DABE5();
				num = 2145003303U << (int)num;
				if (!flag)
				{
					num = (1687897771U & num);
					bool flag2 = 124B.611AD8EF() is Pointer;
					num /= 1167356801U;
					if (!flag2)
					{
						break;
					}
					if ((num ^ 857039321U) == 0U)
					{
						goto IL_00;
					}
					0B005140.124B6895 124B3 = 124B;
					num %= 1057901201U;
					IntPtr 0C055FD = new IntPtr(Pointer.Unbox(124B3.611AD8EF()));
					Type 1DC679F = type2;
					num >>= 13;
					124B = new 0B005140.658470CB(0C055FD, 1DC679F);
					num += 4290006606U;
				}
				num %= 1279404387U;
				num -= 831338348U;
				object 73FB30F = 124B;
				num = 265648021U - num;
				Type 48EE707B = type2;
				num = (386300563U ^ num);
				0B005140.124B6895 23717D = this.33005A42(73FB30F, 48EE707B);
				num = 17105727U % num;
				this.2D04165D(23717D);
				if (num - 876035841U != 0U)
				{
					return;
				}
			}
		}
		while (706164739U <= num);
		throw new ArgumentException();
	}

	// Token: 0x06000147 RID: 327 RVA: 0x000CE804 File Offset: 0x000CE804
	private void 3F133A57()
	{
		uint num = 1522484742U;
		if (679040430U - num == 0U)
		{
			goto IL_78;
		}
		FieldInfo fieldInfo;
		do
		{
			IL_12:
			fieldInfo = this.4F380A52(this.0BD76085().DCFDB33F());
			num /= 1945778946U;
		}
		while (241376490U >> (int)num == 0U);
		object obj2;
		do
		{
			0B005140.124B6895 124B = this.0BD76085();
			num = (877598782U & num);
			object obj = 124B.611AD8EF();
			num |= 940195312U;
			obj2 = obj;
			FieldInfo fieldInfo2 = fieldInfo;
			num = (724721709U & num);
			if (fieldInfo2.IsStatic)
			{
				goto IL_A0;
			}
		}
		while (904752722U <= num);
		IL_78:
		bool flag = obj2 != null;
		num += 0U;
		if (!flag)
		{
			num |= 1547266720U;
			if (num - 172188504U != 0U)
			{
				throw new NullReferenceException();
			}
			goto IL_12;
		}
		IL_A0:
		num = (209549542U & num);
		if (num == 231492888U)
		{
			goto IL_12;
		}
		FieldInfo fieldInfo3 = fieldInfo;
		num >>= 2;
		object value = fieldInfo3.GetValue(obj2);
		num |= 1581802170U;
		this.2D04165D(this.33005A42(value, fieldInfo.FieldType));
		if (num >= 1333134089U)
		{
			return;
		}
		goto IL_12;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x000CE8F8 File Offset: 0x000CE8F8
	private void 702F266B()
	{
		uint num = 1507986856U;
		num -= 1189812682U;
		int 4B6E = this.0BD76085().DCFDB33F();
		num = 1872439492U / num;
		FieldInfo fieldInfo = this.4F380A52(4B6E);
		num = 1069031981U * num;
		FieldInfo fieldInfo2 = fieldInfo;
		if (1490909263U == num)
		{
			goto IL_5A;
		}
		IL_3B:
		0B005140.124B6895 124B = this.0BD76085();
		num &= 2117930908U;
		object obj = 124B.611AD8EF();
		if (num == 899637426U)
		{
			goto IL_75;
		}
		IL_5A:
		FieldInfo fieldInfo3 = fieldInfo2;
		num = 609949241U - num;
		if (fieldInfo3.IsStatic)
		{
			goto IL_99;
		}
		num = (519054534U & num);
		IL_75:
		bool flag = obj != null;
		num = 627642911U + num;
		num ^= 3454671142U;
		if (!flag)
		{
			num *= 1429228674U;
			throw new NullReferenceException();
		}
		IL_99:
		if (267983928U * num == 0U)
		{
			goto IL_3B;
		}
		FieldInfo 61580CF = fieldInfo2;
		object 4547547D = obj;
		num = 17066217U - num;
		this.2D04165D(new 0B005140.40315214(61580CF, 4547547D));
		if (num != 1358627386U)
		{
			return;
		}
		goto IL_3B;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x000CE9CC File Offset: 0x000CE9CC
	private void 505C30CE()
	{
		uint num = 1371866269U;
		if (73350585U != num)
		{
			goto IL_11;
		}
		0B005140.124B6895 124B2;
		object obj;
		FieldInfo fieldInfo2;
		for (;;)
		{
			IL_3B:
			0B005140.124B6895 124B = this.0BD76085();
			num -= 646059306U;
			124B2 = 124B;
			if (869729237U - num == 0U)
			{
				goto IL_11;
			}
			for (;;)
			{
				obj = this.0BD76085().611AD8EF();
				if (num <= 348015699U)
				{
					goto IL_3B;
				}
				FieldInfo fieldInfo = fieldInfo2;
				num *= 704065444U;
				bool isStatic = fieldInfo.IsStatic;
				num <<= 17;
				if (isStatic)
				{
					break;
				}
				num <<= 7;
				if (num > 1739211925U)
				{
					goto Block_3;
				}
			}
			IL_CB:
			num = 1287795898U + num;
			if ((79778263U ^ num) != 0U)
			{
				goto Block_6;
			}
			continue;
			Block_3:
			bool flag = obj != null;
			num <<= 5;
			num += 487063552U;
			if (!flag)
			{
				break;
			}
			goto IL_CB;
		}
		num &= 2089880677U;
		if (464679590U * num != 0U)
		{
			throw new NullReferenceException();
		}
		goto IL_11;
		Block_6:
		FieldInfo fieldInfo3 = fieldInfo2;
		object obj2 = obj;
		num /= 1611614025U;
		object 73FB30F = 124B2;
		FieldInfo fieldInfo4 = fieldInfo2;
		num = 908935160U % num;
		Type fieldType = fieldInfo4.FieldType;
		num = (2091349892U & num);
		0B005140.124B6895 124B3 = this.33005A42(73FB30F, fieldType);
		num %= 1343310051U;
		fieldInfo3.SetValue(obj2, 124B3.611AD8EF());
		return;
		IL_11:
		num = 1504974362U / num;
		num |= 1850684603U;
		0B005140.124B6895 124B4 = this.0BD76085();
		num &= 309880103U;
		fieldInfo2 = this.4F380A52(124B4.DCFDB33F());
		goto IL_3B;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x000CEAF4 File Offset: 0x000CEAF4
	private void 68151E18()
	{
		uint num = 240153469U;
		FieldInfo fieldInfo = this.4F380A52(this.0BD76085().DCFDB33F());
		0B005140.124B6895 73FB30F;
		if (num / 680609733U == 0U)
		{
			num = (440426822U ^ num);
			73FB30F = this.0BD76085();
		}
		FieldInfo fieldInfo2 = fieldInfo;
		num = 890450955U * num;
		object obj = null;
		num /= 1396405472U;
		0B005140.124B6895 124B = this.33005A42(73FB30F, fieldInfo.FieldType);
		num = (990385475U & num);
		fieldInfo2.SetValue(obj, 124B.611AD8EF());
	}

	// Token: 0x0600014B RID: 331 RVA: 0x000CEB68 File Offset: 0x000CEB68
	private void 777A0C42()
	{
		uint num;
		for (;;)
		{
			IL_00:
			num = 720839384U;
			num -= 354634710U;
			int 041B468A = this.0BD76085().DCFDB33F();
			num <<= 26;
			Type type = this.556E394E(041B468A);
			num = 171403427U << (int)num;
			Type type2 = type;
			if (1742342020U + num != 0U)
			{
				for (;;)
				{
					num = (267274913U & num);
					0B005140.124B6895 124B = this.0BD76085();
					if ((num & 1553665269U) != 0U)
					{
						num = (1896043777U | num);
						0B005140.124B6895 124B2 = this.0BD76085();
						num = (746915972U | num);
						if (num < 307721411U)
						{
							break;
						}
						for (;;)
						{
							0B005140.124B6895 124B3 = 124B2;
							num %= 1243874119U;
							if (!124B3.591DABE5())
							{
								num = (2079658399U | num);
								if (num >> 0 == 0U)
								{
									break;
								}
								0B005140.124B6895 124B4 = 124B2;
								num = (1125203856U & num);
								object obj = 124B4.611AD8EF();
								num <<= 14;
								if (!(obj is Pointer))
								{
									goto IL_126;
								}
								num = (1200030058U | num);
								0B005140.124B6895 124B5 = 124B2;
								num ^= 1141401189U;
								object ptr = 124B5.611AD8EF();
								num = 545265938U + num;
								IntPtr 0C055FD = new IntPtr(Pointer.Unbox(ptr));
								num *= 542782704U;
								Type 1DC679F = type2;
								num = 1052328854U + num;
								0B005140.124B6895 124B6 = new 0B005140.658470CB(0C055FD, 1DC679F);
								num = (1559907197U ^ num);
								124B2 = 124B6;
								if (340866542U * num == 0U)
								{
									goto IL_00;
								}
								num ^= 1369114533U;
							}
							if (num < 656819636U)
							{
								break;
							}
							0B005140.124B6895 124B7 = 124B2;
							num = 274803562U % num;
							object 73FB30F = 124B;
							num -= 1905865791U;
							Type 48EE707B = type2;
							num <<= 18;
							124B7.53E5679E(this.33005A42(73FB30F, 48EE707B).611AD8EF());
							if (num * 1461346120U != 0U)
							{
								return;
							}
						}
					}
				}
			}
		}
		IL_126:
		num = 501440065U + num;
		throw new ArgumentException();
	}

	// Token: 0x0600014C RID: 332 RVA: 0x000CECEC File Offset: 0x000CECEC
	private void 718E0370()
	{
		uint num;
		do
		{
			num = 1014855162U;
			List<0B005140.124B6895> list = this.578B1C04;
			num *= 1405819909U;
			num += 596845095U;
			0B005140.124B6895 23717D = list[(int)((ushort)this.0E1F2D8D())].1FB8DBBA();
			num = 1036527685U + num;
			this.2D04165D(23717D);
		}
		while (951912051U >= num);
	}

	// Token: 0x0600014D RID: 333 RVA: 0x000CED40 File Offset: 0x000CED40
	private void 426939D3()
	{
		uint num = 1345077260U;
		num -= 2055490590U;
		List<0B005140.124B6895> list = this.578B1C04;
		num += 690166834U;
		num >>= 19;
		ushort num2 = (ushort)this.0E1F2D8D();
		num -= 491525269U;
		0B005140.124B6895 41D = list[(int)num2];
		num <<= 9;
		0B005140.124B6895 23717D = new 0B005140.18446303(41D);
		num = 1810910931U % num;
		this.2D04165D(23717D);
	}

	// Token: 0x0600014E RID: 334 RVA: 0x000CEDA0 File Offset: 0x000CEDA0
	private void 40090BB7()
	{
		uint num = 1523741941U;
		if (805198681U + num == 0U)
		{
			goto IL_31;
		}
		IL_12:
		num = 1716484211U / num;
		0B005140.124B6895 124B = this.0BD76085();
		num >>= 26;
		0B005140.124B6895 124B2 = 124B;
		num /= 567098134U;
		IL_31:
		List<0B005140.124B6895> list = this.578B1C04;
		num = 793845828U + num;
		num = (1242644649U ^ num);
		int index = (int)((ushort)this.0E1F2D8D());
		num /= 114770416U;
		0B005140.124B6895 124B3 = list[index];
		num %= 1256135937U;
		0B005140.124B6895 124B4 = 124B3;
		0B005140.124B6895 124B5 = 124B4;
		object 73FB30F = 124B2;
		num /= 1023939636U;
		0B005140.124B6895 124B6 = 124B4;
		num -= 1131021587U;
		0B005140.124B6895 124B7 = this.33005A42(73FB30F, 124B6.3A79FD5F());
		num = 1411742926U % num;
		124B5.53E5679E(124B7.611AD8EF());
		if (1373053907U - num != 0U)
		{
			return;
		}
		goto IL_12;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x000CEE50 File Offset: 0x000CEE50
	private void 62AB7105()
	{
		uint num = 1048474097U;
		num -= 1220964192U;
		num *= 1550074121U;
		this.641E1D21 = this.556E394E(this.0BD76085().DCFDB33F());
	}

	// Token: 0x06000150 RID: 336 RVA: 0x000CEE8C File Offset: 0x000CEE8C
	private void 08C843B8()
	{
		uint num = 1310612443U;
		int 6C3838F = this.0BD76085().DCFDB33F();
		num &= 810429764U;
		MethodBase methodBase = this.4FB70B10(6C3838F);
		if (631078707U >> (int)num == 0U)
		{
			goto IL_80;
		}
		0B005140.124B6895 124B2;
		do
		{
			IL_32:
			num = 1908888140U << (int)num;
			MethodBase 4C69561D = methodBase;
			num = (274149989U & num);
			bool 450854DF = (num ^ 273093188U) != 0U;
			num /= 1726184749U;
			0B005140.124B6895 124B = this.508305B1(4C69561D, 450854DF);
			num /= 1601511178U;
			124B2 = 124B;
		}
		while (1022368493U <= num);
		if (124B2 == null)
		{
			goto IL_9D;
		}
		num = 1173514101U - num;
		IL_80:
		num = 2086347003U >> (int)num;
		this.2D04165D(124B2);
		num += 4294966302U;
		IL_9D:
		if (num <= 1305636621U)
		{
			return;
		}
		goto IL_32;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x000CEF44 File Offset: 0x000CEF44
	private void 6C310717()
	{
		uint num = 2010924963U;
		if (num % 839871662U == 0U)
		{
			goto IL_65;
		}
		IL_14:
		num ^= 1713048294U;
		int 6C3838F = this.0BD76085().DCFDB33F();
		num -= 1430529449U;
		MethodBase methodBase = this.4FB70B10(6C3838F);
		num &= 1431130781U;
		MethodBase methodBase2 = methodBase;
		if (571504354U == num)
		{
			goto IL_C3;
		}
		IL_50:
		num = 744575991U / num;
		if (this.641E1D21 == null)
		{
			goto IL_1EF;
		}
		IL_65:
		MethodBase methodBase3 = methodBase2;
		num = 439045895U + num;
		ParameterInfo[] parameters = methodBase3.GetParameters();
		int num2 = parameters.Length;
		num = (2050126192U | num);
		Type[] array = new Type[num2];
		num |= 745024622U;
		Type[] array2 = array;
		num = 395340557U % num;
		int num3 = (int)(num ^ 395340557U);
		num = 1421229733U / num;
		int num4 = num3;
		num = 557587347U << (int)num;
		ParameterInfo[] array3 = parameters;
		IL_C3:
		int num5 = (int)(num + 4129235816U);
		for (;;)
		{
			while ((2089630329U ^ num) != 0U)
			{
				if (num5 >= array3.Length)
				{
					goto Block_2;
				}
				ParameterInfo parameterInfo = array3[num5];
				Type[] array4 = array2;
				num = 585180087U;
				int num6 = num4;
				num = 1417613822U >> (int)num;
				int num7 = (int)(num - 167U);
				num -= 1100943564U;
				num4 = num6 + num7;
				ParameterInfo parameterInfo2 = parameterInfo;
				num <<= 9;
				Type parameterType = parameterInfo2.ParameterType;
				num = 1710128728U + num;
				array4[num6] = parameterType;
				num &= 1951426234U;
				int num8 = num5;
				num ^= 1895897186U;
				num5 = num8 + (int)(num ^ 1430339195U);
				num += 3030359582U;
			}
		}
		Block_2:
		num = 2043285823U + num;
		if (num == 285565047U)
		{
			goto IL_65;
		}
		Type type = this.641E1D21;
		num = (896551665U | num);
		MemberInfo memberInfo = methodBase2;
		num *= 466557594U;
		MethodInfo method = type.GetMethod(memberInfo.Name, (BindingFlags)(num ^ 1057767842U), null, array2, null);
		num = (1369325166U & num);
		if (76578165U >= num)
		{
			goto IL_50;
		}
		if (method != null)
		{
			methodBase2 = method;
			num ^= 0U;
		}
		num = 219495622U * num;
		this.641E1D21 = null;
		num += 3067310942U;
		IL_1EF:
		num = (322860555U | num);
		if (num >= 1016936511U)
		{
			goto IL_14;
		}
		MethodBase 4C69561D = methodBase2;
		bool 450854DF = (num ^ 322860554U) != 0U;
		num %= 92147475U;
		0B005140.124B6895 124B = this.508305B1(4C69561D, 450854DF);
		num &= 161552095U;
		if (num + 824136176U == 0U)
		{
			goto IL_14;
		}
		bool flag = 124B != null;
		num = (575288983U & num);
		if (flag)
		{
			num = (905005600U | num);
			this.2D04165D(124B);
			num ^= 905005600U;
		}
		if (num >> 22 == 0U)
		{
			return;
		}
		goto IL_65;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x000CF1C0 File Offset: 0x000CF1C0
	private void 58E41DB7()
	{
		uint num = 1997744919U;
		if (num <= 1841836034U)
		{
			goto IL_46;
		}
		IL_11:
		object obj = this.0BD76085().611AD8EF();
		num = (306127652U | num);
		MethodBase methodBase = obj as MethodBase;
		num += 823276971U;
		MethodBase methodBase2 = methodBase;
		num <<= 24;
		if (num % 1728781636U == 0U)
		{
			goto IL_58;
		}
		IL_46:
		if (methodBase2 == null)
		{
			if ((num & 1210999102U) == 0U)
			{
				goto IL_11;
			}
		}
		else
		{
			num = 1768437716U >> (int)num;
			0B005140.124B6895 124B;
			if (num > 1203437959U)
			{
				MethodBase 4C69561D = methodBase2;
				bool 450854DF = num + 2526529580U != 0U;
				num = 1306224451U / num;
				124B = this.508305B1(4C69561D, 450854DF);
				num = (1544359326U ^ num);
				if (124B == null)
				{
					goto IL_C7;
				}
				num -= 1040517452U;
				if (878385168U * num == 0U)
				{
					goto IL_58;
				}
			}
			IL_B0:
			0B005140.124B6895 23717D = 124B;
			num *= 587273847U;
			this.2D04165D(23717D);
			num ^= 3160802176U;
			IL_C7:
			if (777401508U <= num)
			{
				return;
			}
			goto IL_B0;
		}
		IL_58:
		throw new ArgumentException();
	}

	// Token: 0x06000153 RID: 339 RVA: 0x000CF2A0 File Offset: 0x000CF2A0
	private void 7B7F0C90()
	{
		uint num = 14580788U;
		0B005140.124B6895 124B3;
		for (;;)
		{
			0B005140.124B6895 124B = this.0BD76085();
			num %= 1577282808U;
			0B005140.124B6895 124B2 = this.24C803D1(124B.DCFDB33F(), num - 14580788U != 0U);
			num = 655758063U / num;
			124B3 = 124B2;
			num = 1470511018U * num;
			if (num <= 1675250945U)
			{
				bool flag = 124B3 != null;
				num = 1035166630U + num;
				if (!flag)
				{
					return;
				}
				num &= 101462328U;
				if (num <= 423704087U)
				{
					break;
				}
			}
		}
		this.2D04165D(124B3);
		num += 1212204230U;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x000CF320 File Offset: 0x000CF320
	private void 0C911BA6()
	{
		uint num = 347169397U;
		int 4D = this.0BD76085().DCFDB33F();
		num |= 37300618U;
		0B005140.124B6895 124B = this.24C803D1(4D, num - 381250558U != 0U);
		num = (481448826U ^ num);
		0B005140.124B6895 124B2 = 124B;
		num ^= 1145137542U;
		do
		{
			bool flag = 124B2 != null;
			num = (119680974U ^ num);
			if (!flag)
			{
				goto IL_76;
			}
			num /= 1107952823U;
		}
		while (num >> 7 != 0U);
		IL_59:
		num = 939408796U >> (int)num;
		this.2D04165D(124B2);
		num += 761880575U;
		IL_76:
		if (num <= 1473085216U)
		{
			return;
		}
		goto IL_59;
	}

	// Token: 0x06000155 RID: 341 RVA: 0x000CF3B0 File Offset: 0x000CF3B0
	private void 070C691A()
	{
		uint num = 1126570321U;
		0B005140.124B6895 124B2;
		if ((num ^ 1929734529U) != 0U)
		{
			MethodBase 3A8D;
			do
			{
				num = 108606183U * num;
				0B005140.124B6895 124B = this.0BD76085();
				num -= 606433634U;
				int 6C3838F = 124B.DCFDB33F();
				num &= 18639135U;
				MethodBase methodBase = this.4FB70B10(6C3838F);
				num &= 1190860743U;
				3A8D = methodBase;
			}
			while (num >> 20 == 0U);
			124B2 = this.43C112F1(3A8D);
		}
		bool flag = 124B2 != null;
		num = (184424687U | num);
		if (flag)
		{
			num &= 1238193465U;
			0B005140.124B6895 23717D = 124B2;
			num <<= 30;
			this.2D04165D(23717D);
			num ^= 1258166511U;
		}
	}

	// Token: 0x06000156 RID: 342 RVA: 0x000CF444 File Offset: 0x000CF444
	private void 4BA3699C()
	{
		uint num;
		0B005140.124B6895 124B2;
		for (;;)
		{
			IL_00:
			int 041B468A = this.0BD76085().DCFDB33F();
			num = 1844905770U;
			Type type = this.556E394E(041B468A);
			for (;;)
			{
				0B005140.124B6895 124B = this.0BD76085();
				num *= 1211186417U;
				124B2 = 124B;
				bool isGenericType = type.IsGenericType;
				num <<= 3;
				if (isGenericType && 202440925U / num == 0U)
				{
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					num <<= 11;
					RuntimeTypeHandle handle = typeof(Nullable<>).TypeHandle;
					num -= 336875779U;
					Type typeFromHandle = Type.GetTypeFromHandle(handle);
					num /= 1865291612U;
					num += 3526145104U;
					if (genericTypeDefinition == typeFromHandle)
					{
						goto Block_2;
					}
				}
				num |= 1195719451U;
				Type type2 = type;
				num = 427891014U + num;
				bool isValueType = type2.IsValueType;
				num += 2013660599U;
				if (!isValueType)
				{
					goto IL_1AC;
				}
				if (489711844U > num)
				{
					goto IL_00;
				}
				Type type3 = type;
				BindingFlags bindingAttr = (BindingFlags)(num - 1760878052U);
				num -= 165482300U;
				FieldInfo[] fields = type3.GetFields(bindingAttr);
				num &= 1535970943U;
				int num2 = (int)(num + 2767909348U);
				num = 835983894U + num;
				int num3 = num2;
				while (num > 1093629787U)
				{
					int num4 = num3;
					int num5 = fields.Length;
					num = 1559576420U + num;
					if (num4 >= num5)
					{
						goto Block_7;
					}
					FieldInfo[] array = fields;
					num = 2018341726U;
					FieldInfo fieldInfo = array[num3];
					num &= 1792806869U;
					FieldInfo fieldInfo2 = fieldInfo;
					FieldInfo fieldInfo3 = fieldInfo2;
					num = 169428397U >> (int)num;
					object obj = 124B2.611AD8EF();
					object value;
					if (!fieldInfo2.FieldType.IsValueType)
					{
						value = null;
					}
					else
					{
						num = (1314018506U | num);
						value = Activator.CreateInstance(fieldInfo2.FieldType);
						num ^= 1314018378U;
					}
					fieldInfo3.SetValue(obj, value);
					num = 1628447142U + num;
					int num6 = num3;
					num >>= 15;
					num3 = num6 + (int)(num ^ 49697U);
					num += 2362992146U;
				}
			}
			Block_7:
			if (1211582019U <= num)
			{
				return;
			}
			continue;
			IL_1AC:
			if (num << 17 != 0U)
			{
				124B2.53E5679E(null);
				if (764360233U - num != 0U)
				{
					return;
				}
			}
		}
		Block_2:
		num ^= 1696549886U;
		0B005140.124B6895 124B3 = 124B2;
		num = (718621671U & num);
		object 4EE42AA = null;
		num ^= 384835623U;
		124B3.53E5679E(4EE42AA);
	}

	// Token: 0x06000157 RID: 343 RVA: 0x000CF61C File Offset: 0x000CF61C
	private void 5FE76993()
	{
		for (;;)
		{
			0B005140.124B6895 124B = this.0BD76085();
			uint num = 1141051212U;
			int num2 = 124B.DCFDB33F();
			num = 2038192857U / num;
			int <<EMPTY_NAME>> = num2;
			if (num != 722089727U)
			{
				num %= 1454273074U;
				0B005140.124B6895 124B2 = this.0BD76085();
				0B005140.124B6895 124B3 = this.0BD76085();
				num = 244003703U - num;
				0B005140.124B6895 124B4 = 124B3;
				num >>= 23;
				num = (1528912918U | num);
				num %= 1058490960U;
				0B005140.124B6895 3847547A = 124B4;
				0B005140.124B6895 034C703F = 124B2;
				bool 721D338F = num - 470421967U != 0U;
				num <<= 10;
				int 0D6B27B = this.76D30FAD(3847547A, 034C703F, 721D338F, <<EMPTY_NAME>>);
				num ^= 876293882U;
				this.2D04165D(new 0B005140.07685083(0D6B27B));
				if (num <= 1690128539U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000158 RID: 344 RVA: 0x000CF6BC File Offset: 0x000CF6BC
	private void 2F517C82()
	{
		int num = this.0BD76085().DCFDB33F();
		uint num2 = 2077045221U;
		int num3 = num;
		0B005140.124B6895 124B;
		if (1175070525U <= num2)
		{
			num2 /= 1859592135U;
			124B = this.0BD76085();
			num2 = (990002229U & num2);
		}
		num2 = 470905693U / num2;
		0B005140.124B6895 124B2 = this.0BD76085();
		0B005140.124B6895 3847547A = 124B2;
		num2 = 1208841027U + num2;
		0B005140.124B6895 034C703F = 124B;
		bool 721D338F = (num2 ^ 1679746721U) != 0U;
		num2 ^= 1449665917U;
		int <<EMPTY_NAME>> = num3;
		num2 = 1363414956U + num2;
		int 0D6B27B = this.76D30FAD(3847547A, 034C703F, 721D338F, <<EMPTY_NAME>>);
		num2 >>= 16;
		0B005140.124B6895 23717D = new 0B005140.07685083(0D6B27B);
		num2 = (55257734U | num2);
		this.2D04165D(23717D);
	}

	// Token: 0x06000159 RID: 345 RVA: 0x000CF750 File Offset: 0x000CF750
	private void 25A07462()
	{
		for (;;)
		{
			uint num = 200025613U;
			0B005140.124B6895 124B = this.0BD76085();
			num = 1223378072U / num;
			Type type = this.556E394E(124B.DCFDB33F());
			num /= 1725388927U;
			Type type2 = type;
			num += 1415862788U;
			if (2072717071U / num != 0U)
			{
				Type elementType = type2;
				num %= 1316965111U;
				num ^= 1167686703U;
				0B005140.124B6895 124B2 = this.0BD76085();
				num ^= 713248376U;
				0B005140.124B6895 23717D = new 0B005140.149C28AA(Array.CreateInstance(elementType, 124B2.DCFDB33F()));
				num <<= 23;
				this.2D04165D(23717D);
				if (num / 865085061U != 0U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600015A RID: 346 RVA: 0x000CF7E4 File Offset: 0x000CF7E4
	private void 75390910()
	{
		for (;;)
		{
			uint num = 1385907865U;
			0B005140.124B6895 124B = this.0BD76085();
			num -= 991314726U;
			Type type = this.556E394E(124B.DCFDB33F());
			num ^= 308170068U;
			0B005140.124B6895 124B3;
			do
			{
				num *= 1108215314U;
				0B005140.124B6895 124B2 = this.0BD76085();
				num *= 501039188U;
				124B3 = 124B2;
				num = 126306665U * num;
			}
			while (668366772U / num != 0U);
			num = (1124226347U | num);
			0B005140.124B6895 124B4 = this.0BD76085();
			num = 1325545687U - num;
			Array array = this.0BD76085().611AD8EF() as Array;
			if (array == null)
			{
				break;
			}
			num /= 1091915634U;
			Array array2 = array;
			num &= 1894335576U;
			object 73FB30F = 124B3;
			num = 1442342908U >> (int)num;
			Type 48EE707B = type;
			num /= 2005611426U;
			object 73FB30F2 = this.33005A42(73FB30F, 48EE707B);
			num /= 225072538U;
			object obj = array;
			num = 1974421524U + num;
			0B005140.124B6895 124B5 = this.33005A42(73FB30F2, obj.GetType().GetElementType());
			num = 429544561U - num;
			object value = 124B5.611AD8EF();
			0B005140.124B6895 124B6 = 124B4;
			num /= 1825777631U;
			array2.SetValue(value, 124B6.DCFDB33F());
			if (1801796331U >= num)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	// Token: 0x0600015B RID: 347 RVA: 0x000CF914 File Offset: 0x000CF914
	private void 31665807()
	{
		uint num;
		Type type2;
		Array array;
		0B005140.124B6895 124B2;
		for (;;)
		{
			int 041B468A = this.0BD76085().DCFDB33F();
			num = 846811945U;
			Type type = this.556E394E(041B468A);
			num /= 675242111U;
			type2 = type;
			if (num + 1188177821U != 0U)
			{
				goto IL_2C;
			}
			IL_43:
			array = (this.0BD76085().611AD8EF() as Array);
			num = 1173100536U * num;
			if (1689672131U < num)
			{
				bool flag = array != null;
				num = (1023301100U ^ num);
				if (flag)
				{
					goto IL_8F;
				}
				num %= 1919365825U;
				if (262696863U - num != 0U)
				{
					break;
				}
				continue;
			}
			IL_2C:
			num = (457268745U | num);
			0B005140.124B6895 124B = this.0BD76085();
			num -= 269098880U;
			124B2 = 124B;
			goto IL_43;
		}
		throw new ArgumentException();
		IL_8F:
		num = (2117402801U & num);
		num &= 133368003U;
		num = 1941636040U + num;
		Array array2 = array;
		num = (1910309205U | num);
		0B005140.124B6895 124B3 = 124B2;
		num = (1486581539U & num);
		object value = array2.GetValue(124B3.DCFDB33F());
		Type 48EE707B = type2;
		num = 488060828U - num;
		this.2D04165D(this.33005A42(value, 48EE707B));
	}

	// Token: 0x0600015C RID: 348 RVA: 0x000CF9FC File Offset: 0x000CF9FC
	private void 63A566F8()
	{
		uint num = 175734000U;
		Array array = this.0BD76085().611AD8EF() as Array;
		num *= 1011973674U;
		bool flag = array != null;
		num = (912020574U ^ num);
		if (flag)
		{
			num = 2015248685U << (int)num;
			num = 899029720U - num;
			int length = array.Length;
			num -= 75827550U;
			0B005140.124B6895 23717D = new 0B005140.07685083(length);
			num = (507908098U | num);
			this.2D04165D(23717D);
			if (1154289946U < num)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	// Token: 0x0600015D RID: 349 RVA: 0x000CFA80 File Offset: 0x000CFA80
	private void 3C6D67F6()
	{
		0B005140.124B6895 124B;
		uint num;
		Array array;
		for (;;)
		{
			124B = this.0BD76085();
			num = 484797660U;
			0B005140.124B6895 124B2 = this.0BD76085();
			num = (646731835U | num);
			object obj = 124B2.611AD8EF();
			num += 1417495400U;
			array = (obj as Array);
			num <<= 16;
			if (2079463549U + num != 0U)
			{
				if (array == null)
				{
					break;
				}
				if ((num ^ 2064989284U) != 0U)
				{
					goto Block_3;
				}
			}
		}
		num |= 2104558501U;
		if (1757166982U < num)
		{
			throw new ArgumentException();
		}
		return;
		Block_3:
		num &= 628849599U;
		Array 1C1C2F = array;
		0B005140.124B6895 124B3 = 124B;
		num <<= 30;
		0B005140.124B6895 23717D = new 0B005140.75F76FC0(1C1C2F, 124B3.DCFDB33F());
		num ^= 1862870121U;
		this.2D04165D(23717D);
	}

	// Token: 0x0600015E RID: 350 RVA: 0x000CFB24 File Offset: 0x000CFB24
	private void 430D3460()
	{
		uint num;
		do
		{
			num = 57624047U;
			MethodBase 159F7EC = this.4FB70B10(this.0BD76085().DCFDB33F());
			num -= 331424282U;
			0B005140.124B6895 23717D = new 0B005140.28534615(159F7EC);
			num = 1706319606U + num;
			this.2D04165D(23717D);
		}
		while (1539908667 << (int)num == 0);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x000CFB78 File Offset: 0x000CFB78
	private void 45935BA6()
	{
		uint num = 1887044632U;
		MethodBase methodBase;
		for (;;)
		{
			IL_06:
			num = (1615664382U ^ num);
			0B005140.124B6895 124B = this.0BD76085();
			num >>= 11;
			int 6C3838F = 124B.DCFDB33F();
			num = 625347818U - num;
			methodBase = this.4FB70B10(6C3838F);
			num += 1251102810U;
			for (;;)
			{
				IL_39:
				0B005140.124B6895 124B2 = this.0BD76085();
				num = 239230415U + num;
				Type type = 124B2.611AD8EF().GetType();
				for (;;)
				{
					IL_52:
					MemberInfo memberInfo = methodBase;
					num = 1437363959U / num;
					Type declaringType = memberInfo.DeclaringType;
					MethodBase methodBase2 = methodBase;
					num = (2017614252U | num);
					ParameterInfo[] parameters = methodBase2.GetParameters();
					num += 392525646U;
					num = 1012552030U % num;
					int num2 = parameters.Length;
					num = 2048663916U * num;
					Type[] array = new Type[num2];
					int num3 = (int)(num - 3437195688U);
					num -= 71568143U;
					int num4 = num3;
					num = (1379146562U ^ num);
					ParameterInfo[] array2 = parameters;
					num = 627649655U % num;
					int num5 = (int)(num - 627649655U);
					for (;;)
					{
						int num6 = num5;
						int num7 = array2.Length;
						num <<= 4;
						int num8 = num7;
						num = 468922882U + num;
						if (num6 >= num8)
						{
							break;
						}
						ParameterInfo[] array3 = array2;
						int num9 = num5;
						num = 750810539U;
						ParameterInfo parameterInfo = array3[num9];
						num = 662401207U >> (int)num;
						if (num + 1727945632U == 0U)
						{
							goto IL_39;
						}
						Type[] array4 = array;
						num = 1123231981U >> (int)num;
						int num10 = num4;
						num = 679304970U << (int)num;
						int num11 = (int)(num ^ 3589316609U);
						num = 980291647U - num;
						int num12 = num10 + num11;
						num += 1154704685U;
						num4 = num12;
						num = 593892743U + num;
						ParameterInfo parameterInfo2 = parameterInfo;
						num ^= 374287698U;
						array4[num10] = parameterInfo2.ParameterType;
						num = 422669836U >> (int)num;
						if (1728212732U % num == 0U)
						{
							goto IL_06;
						}
						int num13 = num5;
						num %= 2118024273U;
						num5 = num13 + (int)(num - 211334917U);
						num += 416314737U;
					}
					if (1647777825U > num)
					{
						break;
					}
					MethodInfo method;
					for (;;)
					{
						bool flag = type != null;
						num ^= 70588814U;
						num += 2007693955U;
						if (!flag)
						{
							goto IL_28D;
						}
						num |= 331626727U;
						if (1499086965U + num == 0U)
						{
							goto IL_39;
						}
						Type type2 = type;
						Type type3 = declaringType;
						num ^= 180321446U;
						if (type2 == type3)
						{
							goto Block_11;
						}
						Type type4 = type;
						string name = methodBase.Name;
						num = 812193677U;
						method = type4.GetMethod(name, (BindingFlags)(num - 812115799U), null, (CallingConventions)(num - 812193674U), array, null);
						bool flag2 = method != null;
						num -= 1999793716U;
						if (flag2)
						{
							num = (91558601U ^ num);
							MethodInfo methodInfo = method;
							num &= 500709620U;
							MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
							num = (432218361U & num);
							MethodBase methodBase3 = methodBase;
							num ^= 2708900297U;
							if (baseDefinition == methodBase3)
							{
								break;
							}
						}
						num += 1033139846U;
						if (1070552829U >= num)
						{
							goto IL_52;
						}
						Type baseType = type.BaseType;
						num <<= 17;
						type = baseType;
						num += 851966322U;
					}
					num ^= 1533836087U;
					MethodBase methodBase4 = method;
					num |= 1817385755U;
					methodBase = methodBase4;
					if (num > 594942334U)
					{
						goto Block_7;
					}
				}
			}
		}
		Block_7:
		goto IL_28D;
		Block_11:
		num ^= 456875046U;
		IL_28D:
		num = (1447254458U & num);
		0B005140.124B6895 23717D = new 0B005140.28534615(methodBase);
		num -= 1203272150U;
		this.2D04165D(23717D);
	}

	// Token: 0x06000160 RID: 352 RVA: 0x000CFE30 File Offset: 0x000CFE30
	private void 10DD4D96()
	{
		uint num = 1285127058U;
		if ((800659752U ^ num) != 0U)
		{
			do
			{
				num = 1298291369U % num;
				num -= 1598191617U;
				this.107A346B = this.0BD76085().DCFDB33F();
			}
			while (1405963003U >= num);
		}
	}

	// Token: 0x06000161 RID: 353 RVA: 0x000CFE7C File Offset: 0x000CFE7C
	private void 7A4223E5()
	{
		uint num = 661470351U;
		if (879631386U != num)
		{
			do
			{
				this.0BD76085();
			}
			while (num > 905465876U);
		}
	}

	// Token: 0x06000162 RID: 354 RVA: 0x000CFEAC File Offset: 0x000CFEAC
	private void 4F776CFF()
	{
		uint num;
		for (;;)
		{
			IL_00:
			num = 923749139U;
			Stack<int> stack = this.5836773B;
			int item = this.0BD76085().DCFDB33F();
			num /= 857221194U;
			stack.Push(item);
			num = 1434674821U % num;
			for (;;)
			{
				IL_2C:
				num = 950412925U >> (int)num;
				int num2 = this.0BD76085().DCFDB33F();
				if ((903365634U ^ num) != 0U)
				{
					for (;;)
					{
						for (;;)
						{
							IL_1A7:
							num = (1486037174U & num);
							num <<= 0;
							Stack<0B005140.11482F88> stack2 = this.410C421C;
							num = 1797091986U * num;
							bool count = stack2.Count != 0;
							num = 1061515012U << (int)num;
							if (!count)
							{
								break;
							}
							num |= 1883183220U;
							int num3 = num2;
							num >>= 1;
							num = 240337744U * num;
							Stack<0B005140.11482F88> stack3 = this.410C421C;
							num = 1913866699U >> (int)num;
							if (num3 <= stack3.Peek().072C4A6E())
							{
								goto Block_9;
							}
							num = 2138115418U;
							if (683681676U >= num)
							{
								goto IL_00;
							}
							num ^= 665393796U;
							0B005140.11482F88 11482F = this.410C421C.Pop();
							num = 1056450040U - num;
							List<0B005140.516357D5> list = 11482F.6C5F487C();
							num <<= 11;
							if (num > 361257998U)
							{
								goto IL_00;
							}
							List<0B005140.516357D5> list2 = list;
							num = 149952007U % num;
							int count2 = list2.Count;
							num = 1930370194U % num;
							int num4 = count2;
							if (960439524U >= num)
							{
								while (813725708U != num)
								{
									if (num4 <= (int)(num ^ 443719U))
									{
										num += 949969206U;
										goto IL_1A7;
									}
									List<0B005140.516357D5> list3 = list;
									int num5 = num4;
									int num6 = 1;
									num = 2002017079U;
									int index = num5 - num6;
									num = 1388799361U + num;
									0B005140.516357D5 516357D = list3[index];
									num = 210534024U >> (int)num;
									0B005140.516357D5 516357D2 = 516357D;
									num &= 2066563683U;
									byte b = 516357D2.79A84666();
									num += 1229810859U;
									uint num7 = num + 3065156439U;
									num = 568935412U * num;
									if (b == num7)
									{
										num /= 511387472U;
										if ((1680569285U ^ num) == 0U)
										{
											break;
										}
										num = (1350897339U | num);
										this.5836773B.Push(516357D2.147B6C82());
										num += 3277473089U;
									}
									num = (1845196448U | num);
									if (1836344596U % num == 0U)
									{
										goto IL_2C;
									}
									int num8 = num4;
									num *= 330062335U;
									int num9 = (int)(num ^ 2709463045U);
									num = 2069855270U - num;
									int num10 = num8 - num9;
									num ^= 228137660U;
									num4 = num10;
									num ^= 3565126617U;
								}
								goto IL_00;
							}
							goto IL_00;
						}
						IL_222:
						num = (1575043156U & num);
						num ^= 1442719988U;
						this.2EA261BB = null;
						if (num < 424877171U)
						{
							break;
						}
						continue;
						Block_9:
						num += 3546004021U;
						goto IL_222;
					}
					num *= 1227963849U;
					Stack<0B005140.375D71A4> stack4 = this.09B46D51;
					num -= 2006999079U;
					stack4.Clear();
					if (610041128U <= num)
					{
						goto Block_11;
					}
				}
			}
		}
		Block_11:
		num = 1985892556U * num;
		int num11 = this.5836773B.Pop();
		num /= 612043821U;
		this.107A346B = num11;
	}

	// Token: 0x06000163 RID: 355 RVA: 0x000D0144 File Offset: 0x000D0144
	private void 26982A6E()
	{
		uint num = 776478858U;
		num &= 939327560U;
		if (this.2EA261BB == null)
		{
			int num2 = this.5836773B.Pop();
			num <<= 10;
			this.107A346B = num2;
			return;
		}
		num |= 1975659951U;
		num = 898498786U - num;
		this.21C44FC8(this.2EA261BB);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x000D01A0 File Offset: 0x000D01A0
	private void 177C0751()
	{
		uint num = 940248730U;
		bool flag = this.0BD76085().DCFDB33F() != 0;
		num = (285242865U & num);
		if (flag)
		{
			num >>= 25;
			if (711211396U - num == 0U)
			{
				goto IL_B8;
			}
			this.410C421C.Pop();
			num = 1278951710U + num;
		}
		else
		{
			num ^= 642476526U;
			num *= 400062239U;
			num /= 1547785522U;
			this.21C44FC8(this.2EA261BB);
			if (num != 1686316816U)
			{
				return;
			}
		}
		num >>= 31;
		Stack<0B005140.375D71A4> stack = this.09B46D51;
		num |= 1766418944U;
		object 4E = this.2EA261BB;
		num = 1828610098U + num;
		0B005140.375D71A4 item = new 0B005140.744E73A6(4E);
		num <<= 19;
		stack.Push(item);
		if (730870924U <= num)
		{
			num <<= 14;
			num += 307105053U;
			0B005140.516357D5 516357D = this.38763065;
			num += 1163623262U;
			this.107A346B = 516357D.147B6C82();
			num = (1261176298U | num);
		}
		IL_B8:
		num = 1266424271U - num;
		0B005140.516357D5 516357D2 = null;
		num <<= 10;
		this.38763065 = 516357D2;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x000D02AC File Offset: 0x000D02AC
	private void 70C52FBD()
	{
		uint num = 2034918249U;
		num = 333122U << (int)num;
		Type type = this.556E394E(this.0BD76085().DCFDB33F());
		num <<= 23;
		Type 48EE707B = type;
		num = 142566872U + num;
		num = (654327788U | num);
		num = 1004888499U << (int)num;
		object 73FB30F = this.0BD76085();
		num /= 527652070U;
		0B005140.124B6895 124B = this.33005A42(73FB30F, 48EE707B);
		num = 289933666U >> (int)num;
		object 4E = 124B.611AD8EF();
		num %= 1575358277U;
		0B005140.124B6895 23717D = new 0B005140.744E73A6(4E);
		num >>= 24;
		this.2D04165D(23717D);
	}

	// Token: 0x06000166 RID: 358 RVA: 0x000D0348 File Offset: 0x000D0348
	private void 4E483802()
	{
		uint num;
		do
		{
			num = 1202473393U;
			num = 1273454901U % num;
			int 041B468A = this.0BD76085().DCFDB33F();
			num >>= 23;
			Type type = this.556E394E(041B468A);
			num = 2034836323U + num;
			Type type2 = type;
			num = 529806947U % num;
			if (num > 717300747U)
			{
				break;
			}
			num = 2097481114U % num;
			num = 1156927392U * num;
			object 73FB30F = this.0BD76085().611AD8EF();
			Type 48EE707B = type2;
			num = 1770082313U >> (int)num;
			0B005140.124B6895 23717D = this.33005A42(73FB30F, 48EE707B);
			num /= 1520322890U;
			this.2D04165D(23717D);
		}
		while (num + 94330226U == 0U);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x000D03E4 File Offset: 0x000D03E4
	private void 63B53B22()
	{
		uint num;
		object obj2;
		for (;;)
		{
			IL_00:
			num = 610879708U;
			num &= 577452249U;
			int 041B468A = this.0BD76085().DCFDB33F();
			num = 959914282U - num;
			Type type = this.556E394E(041B468A);
			num += 137504437U;
			Type type2 = type;
			num = 329281853U >> (int)num;
			for (;;)
			{
				0B005140.124B6895 124B = this.0BD76085();
				for (;;)
				{
					object obj = 124B.611AD8EF();
					num += 168893133U;
					obj2 = obj;
					if (num > 1015179423U)
					{
						goto IL_00;
					}
					for (;;)
					{
						bool flag = obj2 != null;
						num = 847195556U / num;
						if (!flag)
						{
							goto Block_0;
						}
						Type type3 = type2;
						num = 1464931929U + num;
						if (type3.IsValueType)
						{
							Type type4 = type2;
							Type type5 = obj2.GetType();
							num <<= 17;
							if (type4 != type5)
							{
								goto Block_2;
							}
							num = (1119503760U | num);
							if (num >> 31 != 0U)
							{
								goto IL_00;
							}
							0B005140.124B6895 23717D = 124B;
							num = 2048081124U % num;
							this.2D04165D(23717D);
							if (373885685 << (int)num != 0)
							{
								return;
							}
						}
						else
						{
							if (1891060037 << (int)num == 0)
							{
								goto IL_00;
							}
							TypeCode typeCode = Type.GetTypeCode(type2);
							if (1979670783U > num)
							{
								TypeCode typeCode2 = typeCode;
								uint num2 = num ^ 1464931934U;
								num <<= 7;
								switch (typeCode2 - num2)
								{
								case 0:
									goto IL_15C;
								case 1:
									goto IL_18B;
								case 2:
									goto IL_1CA;
								case 3:
									goto IL_1DD;
								case 4:
									goto IL_217;
								case 5:
									goto IL_25D;
								case 6:
									num = 1018170088U % num;
									if (num < 1711760108U)
									{
										goto Block_13;
									}
									continue;
								case 7:
									goto IL_2A6;
								case 8:
									goto IL_2CD;
								case 9:
									goto IL_2E8;
								case 10:
									goto IL_311;
								case 11:
									goto IL_34C;
								}
								goto Block_7;
							}
							goto IL_00;
						}
					}
					IL_1DD:
					if (1689265425U < num)
					{
						goto Block_10;
					}
					continue;
					IL_217:
					num = 344018485U / num;
					num <<= 23;
					object obj3 = obj2;
					num = (217386715U | num);
					short 004C0E5C = (short)obj3;
					num = 486764816U - num;
					0B005140.124B6895 23717D2 = new 0B005140.083F6CB0(004C0E5C);
					num -= 1200242030U;
					this.2D04165D(23717D2);
					if (1576611067U != num)
					{
						return;
					}
				}
				Block_0:
				if ((num ^ 551879073U) != 0U)
				{
					goto IL_7B;
				}
			}
			IL_15C:
			if ((464983444U ^ num) != 0U)
			{
				goto Block_8;
			}
			continue;
			IL_18B:
			num = (858800544U ^ num);
			if (1687046689U / num == 0U)
			{
				goto Block_9;
			}
			continue;
			Block_10:
			byte 22DC = (byte)obj2;
			num = 1199202717U / num;
			0B005140.124B6895 23717D3 = new 0B005140.560C2D3B(22DC);
			num %= 1915583359U;
			this.2D04165D(23717D3);
			if (num << 28 == 0U)
			{
				return;
			}
			continue;
			IL_2A6:
			num += 1203005860U;
			if (num / 2049586679U != 0U)
			{
				goto Block_14;
			}
			continue;
			IL_34C:
			if ((num & 1236603868U) != 0U)
			{
				goto Block_15;
			}
		}
		IL_7B:
		throw new NullReferenceException();
		Block_2:
		num ^= 1633578409U;
		throw new InvalidCastException();
		Block_7:
		throw new InvalidCastException();
		Block_8:
		object obj4 = obj2;
		num += 762396160U;
		bool <<EMPTY_NAME>> = (bool)obj4;
		num *= 1283999222U;
		this.2D04165D(new 0B005140.759B7CAC(<<EMPTY_NAME>>));
		return;
		Block_9:
		object obj5 = obj2;
		num *= 1931483350U;
		char 4ACB4F = (char)obj5;
		num |= 1828521235U;
		0B005140.124B6895 23717D4 = new 0B005140.7EB526D5(4ACB4F);
		num &= 457997646U;
		this.2D04165D(23717D4);
		return;
		IL_1CA:
		this.2D04165D(new 0B005140.67617919((sbyte)obj2));
		return;
		IL_25D:
		object obj6 = obj2;
		num <<= 12;
		this.2D04165D(new 0B005140.4F521487((ushort)obj6));
		return;
		Block_13:
		0B005140.124B6895 23717D5 = new 0B005140.07685083((int)obj2);
		num += 307259863U;
		this.2D04165D(23717D5);
		return;
		Block_14:
		this.2D04165D(new 0B005140.074A0932((uint)obj2));
		return;
		IL_2CD:
		0B005140.124B6895 23717D6 = new 0B005140.13AF7E46((long)obj2);
		num = (265125420U | num);
		this.2D04165D(23717D6);
		return;
		IL_2E8:
		num *= 1425035154U;
		ulong 0F4F = (ulong)obj2;
		num = 1509450162U << (int)num;
		this.2D04165D(new 0B005140.2BAF4849(0F4F));
		return;
		IL_311:
		num |= 2065245356U;
		num *= 191105729U;
		object obj7 = obj2;
		num = 228142812U + num;
		float 474F1D1D = (float)obj7;
		num = 1978020596U * num;
		0B005140.124B6895 23717D7 = new 0B005140.721F5C60(474F1D1D);
		num = 1302071700U * num;
		this.2D04165D(23717D7);
		return;
		Block_15:
		object obj8 = obj2;
		num = 42926989U >> (int)num;
		this.2D04165D(new 0B005140.6B6D1F66((double)obj8));
		if ((829494511U ^ num) != 0U)
		{
			return;
		}
		goto IL_7B;
	}

	// Token: 0x06000168 RID: 360 RVA: 0x000D077C File Offset: 0x000D077C
	private void 25BB5201()
	{
		uint num = 18743632U;
		long num2 = this.6C727377;
		num %= 606474444U;
		ulong num3 = (ulong)this.0BD76085().49390C3B();
		num = (437661880U | num);
		long num4 = (long)num3;
		num <<= 22;
		long value = num2 + num4;
		num = (659306527U & num);
		int 0D6B27B = Marshal.ReadInt32(new IntPtr(value));
		num &= 1180110193U;
		0B005140.124B6895 23717D = new 0B005140.07685083(0D6B27B);
		num /= 1695304783U;
		this.2D04165D(23717D);
	}

	// Token: 0x06000169 RID: 361 RVA: 0x000D07E8 File Offset: 0x000D07E8
	private void 0CF05115()
	{
		uint num = 246701463U;
		int num2;
		int num5;
		for (;;)
		{
			0B005140.124B6895 124B = this.0BD76085();
			num = (742483700U & num);
			num2 = 124B.DCFDB33F();
			num = 1723020826U >> (int)num;
			if (467892940U % num != 0U)
			{
				for (;;)
				{
					int num3 = num2;
					int num4 = (int)(num ^ 1651U);
					num += 1354723215U;
					num5 = num3 >> num4;
					if ((num ^ 156460717U) != 0U)
					{
						if (num5 <= (int)(num ^ 1354724848U))
						{
							num = (1119693631U & num);
						}
						else
						{
							num = 2146840245U / num;
							int num6 = num5;
							uint num7 = num - 4294967270U;
							num ^= 1086136635U;
							if (num6 == num7)
							{
								goto IL_152;
							}
							if (1098858441 << (int)num != 0)
							{
								goto Block_7;
							}
							continue;
						}
					}
					for (;;)
					{
						switch (num5 - (int)(num ^ 1086136635U))
						{
						case 0:
						case 1:
							goto IL_152;
						case 2:
						case 4:
							goto IL_2EB;
						case 3:
							num = 409824441U / num;
							if (num + 1733184511U != 0U)
							{
								goto Block_9;
							}
							continue;
						case 5:
							goto IL_1B1;
						}
						break;
					}
					if (num == 890069028U)
					{
						break;
					}
					if (num5 != (int)(num ^ 1086136624U))
					{
						goto Block_5;
					}
					num |= 1192700470U;
					if (num >= 813122568U)
					{
						goto Block_12;
					}
					continue;
					IL_152:
					if (344664834U * num != 0U)
					{
						goto Block_10;
					}
				}
			}
		}
		Block_5:
		num += 0U;
		IL_AD:
		goto IL_2EB;
		Block_7:
		int num8 = num5;
		uint num9 = num ^ 1086136593U;
		num += 0U;
		if (num8 != num9)
		{
			num += 0U;
			goto IL_2EB;
		}
		goto IL_1B1;
		Block_9:
		Module module = this.42D33E78;
		num -= 1745631032U;
		object 14D50CDD = module.ModuleHandle.ResolveFieldHandle(num2);
		num = 1402106369U << (int)num;
		this.2D04165D(new 0B005140.4FCC199C(14D50CDD));
		return;
		Block_10:
		num = (963853894U ^ num);
		ModuleHandle moduleHandle = this.42D33E78.ModuleHandle;
		num = (1195077193U & num);
		ModuleHandle moduleHandle2 = moduleHandle;
		num -= 1668744662U;
		num = 1383203114U << (int)num;
		object 14D50CDD2 = moduleHandle2.ResolveTypeHandle(num2);
		num <<= 7;
		this.2D04165D(new 0B005140.4FCC199C(14D50CDD2));
		return;
		IL_1B1:
		if (num * 2123842552U != 0U)
		{
			num |= 907747912U;
			moduleHandle2 = this.42D33E78.ModuleHandle;
			num = (785582805U ^ num);
			object 14D50CDD3 = moduleHandle2.ResolveMethodHandle(num2);
			num *= 937902870U;
			this.2D04165D(new 0B005140.4FCC199C(14D50CDD3));
			return;
		}
		goto IL_AD;
		Block_12:
		try
		{
			num = 1075673481U % num;
			if (493093429U <= num)
			{
				num = (1651013117U ^ num);
				moduleHandle2 = this.42D33E78.ModuleHandle;
				num = 783024442U * num;
				num &= 273250034U;
				RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num2);
				num = 845049841U << (int)num;
				object 14D50CDD4 = runtimeFieldHandle;
				num &= 1041637002U;
				0B005140.124B6895 23717D = new 0B005140.4FCC199C(14D50CDD4);
				num %= 251420686U;
				this.2D04165D(23717D);
			}
			return;
		}
		catch (object obj)
		{
			num = 851979161U;
			do
			{
				num |= 767045201U;
				ModuleHandle moduleHandle3 = this.42D33E78.ModuleHandle;
				num = (585447504U ^ num);
				moduleHandle2 = moduleHandle3;
				int methodToken = num2;
				num |= 529272320U;
				RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(methodToken);
				num = 1201692025U / num;
				object 14D50CDD5 = runtimeMethodHandle;
				num >>= 24;
				0B005140.124B6895 23717D2 = new 0B005140.4FCC199C(14D50CDD5);
				num &= 1606509707U;
				this.2D04165D(23717D2);
			}
			while (1171292053U == num);
			return;
		}
		IL_2EB:
		if (num / 498401647U != 0U)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x0600016A RID: 362 RVA: 0x000D0B04 File Offset: 0x000D0B04
	private void 493F68A3()
	{
		0B005140.124B6895 124B = this.0BD76085();
		uint num = 1669096375U;
		Exception ex = 124B.611AD8EF() as Exception;
		num = 2069786481U % num;
		if (ex == null)
		{
			num *= 1960728563U;
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x000D0B44 File Offset: 0x000D0B44
	private void 31BE63C9()
	{
		uint num = 1029126510U;
		num <<= 17;
		if (this.2EA261BB == null)
		{
			throw new InvalidOperationException();
		}
		num = (371935991U & num);
		throw this.2EA261BB;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x000D0B80 File Offset: 0x000D0B80
	private void 5C0664E0()
	{
		uint num = 1740465320U;
		for (;;)
		{
			0B005140.124B6895 124B = this.0BD76085();
			num = 749822318U >> (int)num;
			Type 6AD65A = this.556E394E(124B.DCFDB33F());
			num = (1762885341U ^ num);
			if (1890652269U - num == 0U)
			{
				goto IL_75;
			}
			0B005140.124B6895 124B2;
			do
			{
				124B2 = this.0BD76085();
			}
			while (num % 1174866964U == 0U);
			0B005140.124B6895 124B3 = 124B2;
			num = 1805650926U << (int)num;
			if (!this.09384B2D(124B3.611AD8EF(), 6AD65A))
			{
				break;
			}
			this.2D04165D(124B2);
			if (num << 9 == 0U)
			{
				return;
			}
		}
		num >>= 23;
		IL_75:
		throw new InvalidCastException();
	}

	// Token: 0x0600016D RID: 365 RVA: 0x000D0C1C File Offset: 0x000D0C1C
	private void 5F8E3204()
	{
		uint num = 442577581U;
		0B005140.124B6895 124B2;
		for (;;)
		{
			num |= 671241686U;
			0B005140.124B6895 124B = this.0BD76085();
			num >>= 2;
			Type type = this.556E394E(124B.DCFDB33F());
			num = (663957127U | num);
			Type type2 = type;
			num >>= 23;
			if ((num & 618603912U) != 0U)
			{
				for (;;)
				{
					124B2 = this.0BD76085();
					num |= 335680589U;
					num >>= 30;
					object 664F17B = 124B2.611AD8EF();
					num = (1841324146U | num);
					Type 6AD65A = type2;
					num %= 361702784U;
					bool flag = this.09384B2D(664F17B, 6AD65A);
					num %= 88833290U;
					if (!flag)
					{
						if (num == 210391876U)
						{
							break;
						}
						0B005140.124B6895 124B3 = new 0B005140.744E73A6(null);
						num <<= 10;
						124B2 = 124B3;
						num ^= 3546770674U;
					}
					if (num != 285625786U)
					{
						goto Block_3;
					}
				}
			}
		}
		Block_3:
		num ^= 1023296572U;
		0B005140.124B6895 23717D = 124B2;
		num = 728107242U / num;
		this.2D04165D(23717D);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x000D0CF4 File Offset: 0x000D0CF4
	private void 2C947ABF()
	{
		uint num;
		for (;;)
		{
			IL_00:
			0B005140.124B6895 124B = this.0BD76085();
			num = 962544384U;
			0B005140.124B6895 124B2 = 124B;
			num %= 775446653U;
			bool flag = 124B2.611AD8EF() is IConvertible;
			num = 606475261U / num;
			if (flag)
			{
				num = 524494828U * num;
				double num2;
				do
				{
					0B005140.124B6895 124B3 = 124B2;
					num = 82063076U / num;
					num2 = 124B3.BD97D382();
					num = (1261662563U & num);
					if (num == 461066806U)
					{
						goto IL_00;
					}
					if (double.IsNaN(num2))
					{
						goto IL_91;
					}
				}
				while (num - 195830808U == 0U);
				double d = num2;
				num = 1689466549U * num;
				bool flag2 = double.IsInfinity(d);
				num /= 1052782073U;
				if (flag2)
				{
					break;
				}
			}
			else
			{
				num = (920151322U | num);
				0B005140.124B6895 124B4 = new 0B005140.6B6D1F66(double.NaN);
				num = (569590292U ^ num);
				124B2 = 124B4;
				num ^= 388704015U;
			}
			num = 483272948U << (int)num;
			num = 434900153U << (int)num;
			this.2D04165D(124B2);
			if (1174617645U / num == 0U)
			{
				return;
			}
		}
		num += 0U;
		IL_91:
		num %= 1043624129U;
		throw new OverflowException();
	}

	// Token: 0x0600016F RID: 367 RVA: 0x000D0DF8 File Offset: 0x000D0DF8
	private unsafe void 5B98082D()
	{
		uint num = 567176624U;
		0B005140.124B6895 124B = this.0BD76085();
		num = 932777132U - num;
		IntPtr cb = 124B.861F6A75();
		num >>= 12;
		IntPtr intPtr = Marshal.AllocHGlobal(cb);
		num = 1794386462U / num;
		IntPtr item = intPtr;
		num %= 575879244U;
		List<IntPtr> list = this.2FA72A62;
		num = (678252753U | num);
		list.Add(item);
		num = 1054109984U >> (int)num;
		num += 1076780941U;
		num = (1023950687U ^ num);
		void* ptr = item.ToPointer();
		Type typeFromHandle = typeof(void*);
		num = 1328110906U % num;
		object 4E = Pointer.Box(ptr, typeFromHandle);
		num = 794841579U - num;
		this.2D04165D(new 0B005140.744E73A6(4E));
	}

	// Token: 0x06000170 RID: 368 RVA: 0x000D0EA0 File Offset: 0x000D0EA0
	private void 417E130F()
	{
		uint num = 1273974489U;
		List<IntPtr> list = this.2FA72A62;
		num = 835852467U - num;
		using (List<IntPtr>.Enumerator enumerator = list.GetEnumerator())
		{
			if (num % 841248374U != 0U)
			{
			}
			IL_53:
			while (825850584U <= num)
			{
				num = 300646398U >> (int)num;
				if (!enumerator.MoveNext())
				{
					if (num != 342708037U)
					{
						break;
					}
				}
				else
				{
					num = 1301092572U;
					num = 211574997U << (int)num;
					Marshal.FreeHGlobal(enumerator.Current);
					num += 2514667994U;
				}
			}
			return;
			goto IL_53;
		}
	}

	// Token: 0x06000171 RID: 369 RVA: 0x000D0F54 File Offset: 0x000D0F54
	public object 35C217A7(object[] 72C3372A, int 2CF265CD)
	{
		uint num = 1656302580U;
		do
		{
			num = 1837463600U * num;
			this.107A346B = 2CF265CD;
			num ^= 944440439U;
		}
		while (num == 437923912U);
		num &= 1982273474U;
		0B005140.124B6895 23717D = new 0B005140.149C28AA(72C3372A);
		num = (1532125670U | num);
		this.2D04165D(23717D);
		object result;
		try
		{
			for (;;)
			{
				num = 1389637475U;
				try
				{
					num = 674265815U - num;
					if (2077186260U / num == 0U)
					{
						num = 59473174U >> (int)num;
						Dictionary<uint, 0B005140.38CC03B8> dictionary = this.0313506C;
						num = 191585518U * num;
						num -= 1455302210U;
						0B005140.38CC03B8 38CC03B = dictionary[(uint)this.44376D54()];
						num = 1345740403U << (int)num;
						38CC03B();
						if (num >> 8 == 0U)
						{
							continue;
						}
					}
					bool flag = this.107A346B != 0;
					num ^= 602240746U;
					if (!flag)
					{
						break;
					}
					continue;
				}
				catch (Exception ex)
				{
					num = 1227573095U;
					Exception 3638383C = ex;
					num = (1616596522U ^ num);
					num = 1140409895U % num;
					this.21C44FC8(3638383C);
					continue;
				}
				break;
			}
			do
			{
				0B005140.124B6895 124B = this.0BD76085();
				num = 904101160U;
				result = 124B.611AD8EF();
			}
			while (911883886U / num == 0U);
		}
		finally
		{
			do
			{
				num = 1299332701U;
				this.417E130F();
			}
			while (51256031U > num);
		}
		return result;
	}

	// Token: 0x06000172 RID: 370 RVA: 0x000D10AC File Offset: 0x000D10AC
	// Note: this type is marked as 'beforefieldinit'.
	static 0B005140()
	{
		uint num;
		do
		{
			Dictionary<int, object> dictionary = new Dictionary<int, object>();
			num = 1183581108U;
			0B005140.35EB737B = dictionary;
			num %= 936339033U;
			Dictionary<MethodBase, DynamicMethod> dictionary2 = new Dictionary<MethodBase, DynamicMethod>();
			num = (1143098880U | num);
			0B005140.5FA12BDF = dictionary2;
		}
		while (num == 2038844227U);
	}

	// Token: 0x04000173 RID: 371
	private readonly Dictionary<uint, 0B005140.38CC03B8> 0313506C;

	// Token: 0x04000174 RID: 372
	private readonly Module 42D33E78;

	// Token: 0x04000175 RID: 373
	private readonly long 6C727377;

	// Token: 0x04000176 RID: 374
	private int 107A346B;

	// Token: 0x04000177 RID: 375
	private Type 641E1D21;

	// Token: 0x04000178 RID: 376
	private Stack<0B005140.375D71A4> 09B46D51;

	// Token: 0x04000179 RID: 377
	private static readonly Dictionary<int, object> 35EB737B;

	// Token: 0x0400017A RID: 378
	private static readonly Dictionary<MethodBase, DynamicMethod> 5FA12BDF;

	// Token: 0x0400017B RID: 379
	private List<0B005140.124B6895> 578B1C04;

	// Token: 0x0400017C RID: 380
	private List<0B005140.11482F88> 4E1277A9;

	// Token: 0x0400017D RID: 381
	private Stack<0B005140.11482F88> 410C421C;

	// Token: 0x0400017E RID: 382
	private Stack<int> 5836773B;

	// Token: 0x0400017F RID: 383
	private Exception 2EA261BB;

	// Token: 0x04000180 RID: 384
	private 0B005140.516357D5 38763065;

	// Token: 0x04000181 RID: 385
	private List<IntPtr> 2FA72A62;

	// Token: 0x0200004F RID: 79
	private static class 12D64BCB
	{
	}

	// Token: 0x02000050 RID: 80
	private abstract class 124B6895
	{
		// Token: 0x060001E9 RID: 489
		public abstract 0B005140.124B6895 1FB8DBBA();

		// Token: 0x060001EA RID: 490
		public abstract object 611AD8EF();

		// Token: 0x060001EB RID: 491
		public abstract void 53E5679E(object 4EE42AA1);

		// Token: 0x060001EC RID: 492 RVA: 0x000C268C File Offset: 0x000C268C
		public virtual bool 591DABE5()
		{
			return false;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000D2EF8 File Offset: 0x000D2EF8
		public virtual 0B005140.375D71A4 58C2988C()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000D2F0C File Offset: 0x000D2F0C
		public virtual 0B005140.124B6895 3D08BB82()
		{
			return this;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000D2EF8 File Offset: 0x000D2EF8
		public virtual Type 3A79FD5F()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000D2EF8 File Offset: 0x000D2EF8
		public virtual TypeCode 08177016()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000D2F1C File Offset: 0x000D2F1C
		public virtual bool A29D7A45()
		{
			return Convert.ToBoolean(this.611AD8EF());
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000D2F3C File Offset: 0x000D2F3C
		public virtual sbyte 3759DB5E()
		{
			uint num = 2049581783U;
			num *= 146635859U;
			return Convert.ToSByte(this.611AD8EF());
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000D2F64 File Offset: 0x000D2F64
		public virtual short D846A716()
		{
			uint num = 143931805U;
			num ^= 989494648U;
			object value = this.611AD8EF();
			num <<= 20;
			return Convert.ToInt16(value);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000D2F94 File Offset: 0x000D2F94
		public virtual int DCFDB33F()
		{
			uint num = 674371522U;
			num >>= 30;
			return Convert.ToInt32(this.611AD8EF());
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000D2FBC File Offset: 0x000D2FBC
		public virtual long EB2B8B0E()
		{
			uint num = 377640552U;
			object value = this.611AD8EF();
			num = (1813654780U & num);
			return Convert.ToInt64(value);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000D2FE4 File Offset: 0x000D2FE4
		public virtual char C299D4B1()
		{
			uint num = 1844076516U;
			num &= 1256266775U;
			return Convert.ToChar(this.611AD8EF());
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000D300C File Offset: 0x000D300C
		public virtual byte 7CCA383B()
		{
			uint num = 2054445565U;
			object value = this.611AD8EF();
			num /= 94576717U;
			return Convert.ToByte(value);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000D3034 File Offset: 0x000D3034
		public virtual ushort E35975AC()
		{
			uint num = 1950174937U;
			object value = this.611AD8EF();
			num = 1683380695U >> (int)num;
			return Convert.ToUInt16(value);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000D3060 File Offset: 0x000D3060
		public virtual uint 49390C3B()
		{
			return Convert.ToUInt32(this.611AD8EF());
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000D3080 File Offset: 0x000D3080
		public virtual ulong 6DD020CC()
		{
			uint num = 663503439U;
			num = 1132747952U % num;
			object value = this.611AD8EF();
			num ^= 1271555973U;
			return Convert.ToUInt64(value);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000D30B0 File Offset: 0x000D30B0
		public virtual float 84027CE6()
		{
			return Convert.ToSingle(this.611AD8EF());
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000D30C8 File Offset: 0x000D30C8
		public virtual double BD97D382()
		{
			uint num = 1168849601U;
			object value = this.611AD8EF();
			num <<= 2;
			return Convert.ToDouble(value);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000D30F0 File Offset: 0x000D30F0
		public override string ToString()
		{
			uint num = 1592355963U;
			object obj2;
			if (num << 18 != 0U)
			{
				num = (1337553930U & num);
				object obj = this.611AD8EF();
				num = (512688575U | num);
				obj2 = obj;
				num = 1020418497U << (int)num;
				bool flag = obj2 != null;
				num = 1927050114U * num;
				if (!flag)
				{
					num &= 1652230679U;
					if ((829175533U & num) == 0U)
					{
						return null;
					}
				}
			}
			return Convert.ToString(obj2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000D2EF8 File Offset: 0x000D2EF8
		public virtual IntPtr 861F6A75()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000D2EF8 File Offset: 0x000D2EF8
		public virtual UIntPtr 1A796C90()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000D2EF8 File Offset: 0x000D2EF8
		public virtual object FBC53937(Type 4CDE617C, bool 1E8F6FC0)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000C25B4 File Offset: 0x000C25B4
		protected 124B6895()
		{
			uint num = 1517715308U;
			if (1002778062 << (int)num != 0)
			{
				num = 66812164U + num;
				base..ctor();
			}
		}
	}

	// Token: 0x02000051 RID: 81
	private abstract class 375D71A4 : 0B005140.124B6895
	{
		// Token: 0x06000202 RID: 514 RVA: 0x000D2F0C File Offset: 0x000D2F0C
		public override 0B005140.375D71A4 58C2988C()
		{
			return this;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000C268C File Offset: 0x000C268C
		public override TypeCode 08177016()
		{
			return TypeCode.Empty;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000D3160 File Offset: 0x000D3160
		protected 375D71A4()
		{
			uint num = 1403485289U;
			do
			{
				num = 683150196U + num;
				base..ctor();
			}
			while (211708951U >> (int)num != 0U);
		}
	}

	// Token: 0x02000052 RID: 82
	private sealed class 07685083 : 0B005140.375D71A4
	{
		// Token: 0x06000205 RID: 517 RVA: 0x000D3194 File Offset: 0x000D3194
		public 07685083(int 0D6B27B4)
		{
			uint num = 933500670U;
			base..ctor();
			num = 1621185457U / num;
			do
			{
				num = (1395813134U | num);
				this.446E341F = 0D6B27B4;
			}
			while (num == 921052323U);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000D31D0 File Offset: 0x000D31D0
		public override Type 3A79FD5F()
		{
			uint num = 1113480500U;
			RuntimeTypeHandle handle = typeof(int).TypeHandle;
			num = (261835978U & num);
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000D31F8 File Offset: 0x000D31F8
		public override TypeCode 08177016()
		{
			uint num = 65887753U;
			return (TypeCode)(num - 65887744U);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000D3214 File Offset: 0x000D3214
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 536819258U;
			num = 1540566638U - num;
			int 0D6B27B = this.446E341F;
			num /= 1700009037U;
			return new 0B005140.07685083(0D6B27B);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000D3244 File Offset: 0x000D3244
		public override object 611AD8EF()
		{
			return this.446E341F;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000D3264 File Offset: 0x000D3264
		public override void 53E5679E(object 58CB2CE5)
		{
			uint num = 1454521136U;
			num = 1162954544U / num;
			num = 1835170062U << (int)num;
			this.446E341F = Convert.ToInt32(58CB2CE5);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000D329C File Offset: 0x000D329C
		public override bool A29D7A45()
		{
			uint num = 600713499U;
			return this.446E341F > (int)(num + 3694253797U);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000D32C0 File Offset: 0x000D32C0
		public override sbyte 3759DB5E()
		{
			uint num = 371660680U;
			sbyte b = (sbyte)this.446E341F;
			num |= 552821907U;
			return b;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000D32E4 File Offset: 0x000D32E4
		public override short D846A716()
		{
			return (short)this.446E341F;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000D32F8 File Offset: 0x000D32F8
		public override int DCFDB33F()
		{
			return this.446E341F;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000D330C File Offset: 0x000D330C
		public override long EB2B8B0E()
		{
			return (long)this.446E341F;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000D3320 File Offset: 0x000D3320
		public override char C299D4B1()
		{
			return (char)this.446E341F;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000D333C File Offset: 0x000D333C
		public override byte 7CCA383B()
		{
			uint num = 1980513368U;
			byte b = (byte)this.446E341F;
			num = (599488788U ^ num);
			return b;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000D3320 File Offset: 0x000D3320
		public override ushort E35975AC()
		{
			return (ushort)this.446E341F;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000D32F8 File Offset: 0x000D32F8
		public override uint 49390C3B()
		{
			return (uint)this.446E341F;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000D3360 File Offset: 0x000D3360
		public override ulong 6DD020CC()
		{
			return (ulong)this.446E341F;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000D337C File Offset: 0x000D337C
		public override float 84027CE6()
		{
			uint num = 233657784U;
			float num2 = (float)this.446E341F;
			num = 921125661U - num;
			return num2;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000D33A0 File Offset: 0x000D33A0
		public override double BD97D382()
		{
			uint num = 456544374U;
			double num2 = (double)this.446E341F;
			num = 2088454090U << (int)num;
			return num2;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000D33C8 File Offset: 0x000D33C8
		public override IntPtr 861F6A75()
		{
			return new IntPtr(this.446E341F);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000D33E8 File Offset: 0x000D33E8
		public override UIntPtr 1A796C90()
		{
			return new UIntPtr((uint)this.446E341F);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000D3408 File Offset: 0x000D3408
		public override 0B005140.124B6895 3D08BB82()
		{
			uint num = 884285825U;
			num &= 171900938U;
			return new 0B005140.074A0932((uint)this.446E341F);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000D3430 File Offset: 0x000D3430
		public override object FBC53937(Type 04E720A0, bool 402A2FA1)
		{
			uint num;
			for (;;)
			{
				num = 1015497590U;
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num = 1222574406U * num;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num += 1042032236U;
				if (04E720A0 == typeFromHandle)
				{
					if ((1096091625U ^ num) == 0U)
					{
						goto IL_5F;
					}
				}
				else
				{
					num ^= 1531712577U;
					RuntimeTypeHandle handle2 = typeof(UIntPtr).TypeHandle;
					num = 708662944U >> (int)num;
					if (04E720A0 == Type.GetTypeFromHandle(handle2))
					{
						num %= 1119490019U;
						if (!402A2FA1)
						{
							goto Block_7;
						}
						if (22751969U != num)
						{
							goto Block_8;
						}
						continue;
					}
					else
					{
						num = 723210406U >> (int)num;
						if (1678664166U >> (int)num == 0U)
						{
							continue;
						}
						num = 1681795561U << (int)num;
						TypeCode typeCode = Type.GetTypeCode(04E720A0);
						num = 338564063U >> (int)num;
						TypeCode typeCode2 = typeCode;
						object obj = typeCode2;
						num <<= 20;
						object obj2 = num ^ 1888485381U;
						num = (2080770797U ^ num);
						object obj3 = obj - obj2;
						num = (2125871881U ^ num);
						switch (obj3)
						{
						case 0:
							num = 1365721511U % num;
							if (num >= 1265376428U)
							{
								goto Block_12;
							}
							continue;
						case 1:
							if (691346981U >= num)
							{
								continue;
							}
							if (!402A2FA1)
							{
								if (num != 64126896U)
								{
									goto Block_26;
								}
								continue;
							}
							else
							{
								num += 1204423778U;
								if (84630427U - num != 0U)
								{
									goto Block_27;
								}
								continue;
							}
							break;
						case 2:
							if (1678271258U + num == 0U)
							{
								continue;
							}
							num = (1462401782U & num);
							if (!402A2FA1)
							{
								num = (638807363U | num);
								if (1117061463U + num != 0U)
								{
									goto Block_16;
								}
								continue;
							}
							else
							{
								num -= 773812226U;
								if (num <= 1354064171U)
								{
									goto Block_17;
								}
								continue;
							}
							break;
						case 3:
							if (402A2FA1)
							{
								goto IL_4A3;
							}
							num = 729244698U << (int)num;
							if (1286426962U / num == 0U)
							{
								goto Block_29;
							}
							break;
						case 4:
							num >>= 9;
							if (num << 13 == 0U)
							{
								goto IL_5F;
							}
							num = (1847144236U & num);
							if (!402A2FA1)
							{
								goto Block_19;
							}
							num *= 1068644707U;
							if (num / 2019978144U != 0U)
							{
								goto Block_20;
							}
							continue;
						case 5:
							if (!402A2FA1)
							{
								goto Block_30;
							}
							num = 776610055U - num;
							if ((1130899628U ^ num) != 0U)
							{
								goto Block_31;
							}
							continue;
						case 6:
							if (1498563813U == num)
							{
								goto IL_5F;
							}
							num = 1240492849U - num;
							if (!402A2FA1)
							{
								goto Block_22;
							}
							if (num > 1077558389U)
							{
								goto Block_23;
							}
							continue;
						case 7:
							num /= 1196848996U;
							if (num == 612122909U)
							{
								continue;
							}
							num = 160770628U + num;
							if (!402A2FA1)
							{
								if (66338940U != num)
								{
									goto Block_34;
								}
								continue;
							}
							else
							{
								if (1993495743U > num)
								{
									goto Block_35;
								}
								continue;
							}
							break;
						case 8:
							goto IL_5F4;
						case 9:
							num = 1952726485U + num;
							if (num == 1481512860U)
							{
								continue;
							}
							if (402A2FA1)
							{
								goto IL_5C2;
							}
							if (num > 492403279U)
							{
								goto Block_38;
							}
							goto IL_B6;
						default:
							if (num - 1353845442U != 0U)
							{
								goto Block_11;
							}
							break;
						}
					}
				}
				int size = IntPtr.Size;
				num <<= 17;
				uint num2 = num - 492830716U;
				num %= 81597832U;
				if (size != num2)
				{
					goto IL_B6;
				}
				if ((num ^ 660218515U) == 0U)
				{
					continue;
				}
				IL_5F:
				if (!402A2FA1)
				{
					break;
				}
				if (189664704U > num)
				{
					goto Block_3;
				}
				continue;
				IL_B6:
				if (num < 407203565U)
				{
					goto Block_4;
				}
			}
			num |= 1051866070U;
			IL_6D:
			int value = this.446E341F;
			goto IL_A3;
			Block_3:
			uint num3 = (uint)this.446E341F;
			num *= 501041149U;
			int num4 = (int)num3;
			num = 2144812515U + num;
			value = num4;
			num += 3392552547U;
			IL_A3:
			num = (451049011U | num);
			return new IntPtr(value);
			Block_4:
			long value2;
			if (!402A2FA1)
			{
				num >>= 20;
				num = 359274676U % num;
				long num5 = (long)this.446E341F;
				num = 1272258710U << (int)num;
				value2 = num5;
			}
			else
			{
				num = 833631175U + num;
				value2 = (long)((ulong)this.446E341F);
				num ^= 2789995451U;
			}
			return new IntPtr(value2);
			Block_7:
			num = 1908415580U >> (int)num;
			num >>= 25;
			uint num6 = (uint)this.446E341F;
			num >>= 15;
			uint value3 = num6;
			goto IL_192;
			Block_8:
			num = 991776419U * num;
			value3 = (uint)this.446E341F;
			num ^= 1424135706U;
			IL_192:
			num = (1526275683U & num);
			UIntPtr uintPtr = new UIntPtr(value3);
			num -= 1193356900U;
			return uintPtr;
			Block_11:
			num += 0U;
			goto IL_5F4;
			Block_12:
			num += 1706754704U;
			sbyte b2;
			if (!402A2FA1)
			{
				num -= 2015567711U;
				sbyte b = (sbyte)this.446E341F;
				num = 1816272672U >> (int)num;
				b2 = b;
			}
			else
			{
				uint num7 = (uint)this.446E341F;
				num &= 871519401U;
				b2 = checked((sbyte)num7);
				num += 3437083723U;
			}
			return b2;
			Block_16:
			num = (1735812807U | num);
			short num8 = (short)this.446E341F;
			num = 801506183U << (int)num;
			short num9 = num8;
			goto IL_333;
			Block_17:
			num *= 261962192U;
			num9 = checked((short)((uint)this.446E341F));
			num += 4007180768U;
			IL_333:
			num = (499792596U ^ num);
			return num9;
			Block_19:
			num /= 843391498U;
			int num10 = this.446E341F;
			goto IL_3A2;
			Block_20:
			int num11 = (int)(checked((uint)this.446E341F));
			num = 311249640U * num;
			num10 = num11;
			num += 3925541440U;
			IL_3A2:
			num %= 703429445U;
			return num10;
			Block_22:
			num ^= 1011484817U;
			long num12 = (long)this.446E341F;
			num = 649931769U / num;
			long num13 = num12;
			goto IL_3FF;
			Block_23:
			num13 = (long)((ulong)this.446E341F);
			num ^= 3620747597U;
			IL_3FF:
			num = 1359180559U - num;
			return num13;
			Block_26:
			num >>= 12;
			byte b3;
			checked
			{
				b3 = (byte)this.446E341F;
				goto IL_469;
				Block_27:
				byte b4 = (byte)((uint)this.446E341F);
				num &= 1266368981U;
				b3 = b4;
			}
			num += 4137492927U;
			IL_469:
			num = 1479489573U + num;
			return b3;
			Block_29:
			ushort num14 = checked((ushort)this.446E341F);
			goto IL_4C3;
			IL_4A3:
			num /= 841034731U;
			num = 53897741U - num;
			num14 = checked((ushort)((uint)this.446E341F));
			num ^= 3024104363U;
			IL_4C3:
			num &= 823405364U;
			return num14;
			Block_30:
			num *= 1597125765U;
			num %= 1389697279U;
			uint num15 = (uint)this.446E341F;
			num |= 434404589U;
			uint num16 = num15;
			goto IL_51D;
			Block_31:
			num16 = (uint)this.446E341F;
			num += 2210042074U;
			IL_51D:
			return num16;
			Block_34:
			num = 710634904U - num;
			uint num17 = checked((uint)this.446E341F);
			goto IL_57C;
			Block_35:
			num17 = (uint)this.446E341F;
			num ^= 693332246U;
			IL_57C:
			num /= 688859143U;
			return num17;
			Block_38:
			double num18 = (double)this.446E341F;
			num = 1668105589U / num;
			double num19 = num18;
			goto IL_5EE;
			IL_5C2:
			if (num >> 22 == 0U)
			{
				goto IL_6D;
			}
			num = 149250175U * num;
			int num20 = this.446E341F;
			num -= 829778306U;
			num19 = num20;
			num += 1935645883U;
			IL_5EE:
			return num19;
			IL_5F4:
			num = 1784175672U * num;
			throw new ArgumentException();
		}

		// Token: 0x040001D9 RID: 473
		private int 446E341F;
	}

	// Token: 0x02000053 RID: 83
	private sealed class 13AF7E46 : 0B005140.375D71A4
	{
		// Token: 0x0600021B RID: 539 RVA: 0x000D3A40 File Offset: 0x000D3A40
		public 13AF7E46(long 23214560)
		{
			uint num;
			do
			{
				base..ctor();
				num = 674563432U;
			}
			while ((num ^ 253369993U) == 0U);
			do
			{
				this.6C776920 = 23214560;
			}
			while (num <= 539062183U);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000D3A78 File Offset: 0x000D3A78
		public override Type 3A79FD5F()
		{
			return typeof(long);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000D3A98 File Offset: 0x000D3A98
		public override TypeCode 08177016()
		{
			return TypeCode.Int64;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000D3AA8 File Offset: 0x000D3AA8
		public override 0B005140.124B6895 3D08BB82()
		{
			uint num = 1886024048U;
			num = (2075670794U & num);
			ulong 0F4F = (ulong)this.6C776920;
			num %= 1206147344U;
			return new 0B005140.2BAF4849(0F4F);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000D3AD8 File Offset: 0x000D3AD8
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.13AF7E46(this.6C776920);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000D3AF8 File Offset: 0x000D3AF8
		public override object 611AD8EF()
		{
			uint num = 1984263175U;
			long num2 = this.6C776920;
			num |= 1326452740U;
			return num2;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000D3B20 File Offset: 0x000D3B20
		public override void 53E5679E(object 30222F8C)
		{
			uint num = 1446251005U;
			if (1506296964U > num)
			{
				num += 1996121628U;
				this.6C776920 = Convert.ToInt64(30222F8C);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000D3B54 File Offset: 0x000D3B54
		public override bool A29D7A45()
		{
			long num = this.6C776920;
			uint num2 = 1166874801U;
			long num3 = num2 ^ 1166874801U;
			num2 = 868243593U * num2;
			long num4 = num3;
			num2 = 1584879940U + num2;
			return num > num4;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000D3B88 File Offset: 0x000D3B88
		public override char C299D4B1()
		{
			uint num = 812730597U;
			num = 1147157809U / num;
			char c = (char)this.6C776920;
			num >>= 11;
			return c;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000D3BB4 File Offset: 0x000D3BB4
		public override byte 7CCA383B()
		{
			uint num = 1492398368U;
			byte b = (byte)this.6C776920;
			num = 36838545U - num;
			return b;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000D3BD8 File Offset: 0x000D3BD8
		public override sbyte 3759DB5E()
		{
			uint num = 624637980U;
			sbyte b = (sbyte)this.6C776920;
			num <<= 15;
			return b;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000D3BFC File Offset: 0x000D3BFC
		public override short D846A716()
		{
			return (short)this.6C776920;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000D3C10 File Offset: 0x000D3C10
		public override int DCFDB33F()
		{
			uint num = 387719273U;
			num = (393761994U ^ num);
			int num2 = (int)this.6C776920;
			num -= 464926676U;
			return num2;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000D3C3C File Offset: 0x000D3C3C
		public override long EB2B8B0E()
		{
			return this.6C776920;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000D3B88 File Offset: 0x000D3B88
		public override ushort E35975AC()
		{
			uint num = 812730597U;
			num = 1147157809U / num;
			ushort num2 = (ushort)this.6C776920;
			num >>= 11;
			return num2;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000D3C58 File Offset: 0x000D3C58
		public override uint 49390C3B()
		{
			return (uint)this.6C776920;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000D3C3C File Offset: 0x000D3C3C
		public override ulong 6DD020CC()
		{
			return (ulong)this.6C776920;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000D3C74 File Offset: 0x000D3C74
		public override float 84027CE6()
		{
			return (float)this.6C776920;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000D3C88 File Offset: 0x000D3C88
		public override double BD97D382()
		{
			uint num = 100688242U;
			double num2 = (double)this.6C776920;
			num &= 337518641U;
			return num2;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000D3CAC File Offset: 0x000D3CAC
		public override IntPtr 861F6A75()
		{
			uint num = 527580533U;
			long value;
			if (170335708U >> (int)num != 0U)
			{
				for (;;)
				{
					int size = IntPtr.Size;
					uint num2 = num + 3767386767U;
					num = (1034694024U ^ num);
					if (size == num2)
					{
						break;
					}
					num = 1227754302U >> (int)num;
					if (num % 1165114399U != 0U)
					{
						goto IL_4B;
					}
				}
				value = (long)((int)this.6C776920);
				num ^= 584978687U;
				goto IL_66;
			}
			IL_4B:
			value = this.6C776920;
			IL_66:
			return new IntPtr(value);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000D3D24 File Offset: 0x000D3D24
		public override UIntPtr 1A796C90()
		{
			uint num;
			do
			{
				uint size = (uint)UIntPtr.Size;
				num = 273041840U;
				if (size == (num ^ 273041844U))
				{
					goto IL_35;
				}
			}
			while (1782728448U < num);
			num = (1847481012U ^ num);
			ulong value = (ulong)this.6C776920;
			goto IL_4D;
			IL_35:
			uint num2 = (uint)this.6C776920;
			num = 793341021U * num;
			value = (ulong)num2;
			num ^= 2643927028U;
			IL_4D:
			return new UIntPtr(value);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000D3D84 File Offset: 0x000D3D84
		public override object FBC53937(Type 15A80BF8, bool 6E0E7BE9)
		{
			uint num = 1145963955U;
			long value;
			if (num << 8 != 0U)
			{
				for (;;)
				{
					IL_12:
					num = (1481265693U & num);
					RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
					num = (1706372262U ^ num);
					if (15A80BF8 != Type.GetTypeFromHandle(handle))
					{
						goto IL_A5;
					}
					num = (975131167U ^ num);
					IL_3A:
					while (!6E0E7BE9)
					{
						if ((num ^ 530187816U) != 0U)
						{
							goto IL_4C;
						}
					}
					if (num > 175252234U)
					{
						break;
					}
					for (;;)
					{
						IL_A5:
						num = 1526886248U - num;
						RuntimeTypeHandle handle2 = typeof(UIntPtr).TypeHandle;
						num = 2126606121U % num;
						if (15A80BF8 == Type.GetTypeFromHandle(handle2))
						{
							break;
						}
						num ^= 1808613961U;
						if ((num ^ 1788023466U) == 0U)
						{
							goto IL_12;
						}
						TypeCode typeCode = Type.GetTypeCode(15A80BF8);
						num = 1448949740U + num;
						TypeCode typeCode2 = typeCode;
						num = (1643394001U & num);
						if (num >> 9 == 0U)
						{
							goto IL_12;
						}
						for (;;)
						{
							TypeCode typeCode3 = typeCode2;
							uint num2 = num ^ 1104421717U;
							num = 660825049U << (int)num;
							switch (typeCode3 - num2)
							{
							case 0:
								goto IL_1A7;
							case 1:
								goto IL_35D;
							case 2:
								goto IL_205;
							case 3:
								if (644548623U + num != 0U)
								{
									goto Block_24;
								}
								continue;
							case 4:
								goto IL_29D;
							case 5:
								goto IL_42A;
							case 6:
								goto IL_2EE;
							case 7:
								goto IL_472;
							case 8:
								goto IL_549;
							case 9:
								goto IL_4CF;
							}
							goto Block_9;
						}
						IL_205:
						num = 419723044U >> (int)num;
						if ((num ^ 1130393145U) != 0U)
						{
							goto Block_13;
						}
					}
					num >>= 5;
					if (num + 1676178369U == 0U)
					{
						continue;
					}
					if (!6E0E7BE9)
					{
						goto Block_6;
					}
					if (num != 701712651U)
					{
						goto Block_7;
					}
					goto IL_3A;
					Block_13:
					num >>= 30;
					if (!6E0E7BE9)
					{
						num = (1034758083U | num);
						if (num > 379218317U)
						{
							goto Block_15;
						}
						continue;
					}
					else
					{
						if (1879854259U != num)
						{
							goto Block_16;
						}
						continue;
					}
					IL_35D:
					num ^= 1161762596U;
					if (!6E0E7BE9)
					{
						goto Block_22;
					}
					num %= 1652693263U;
					if (357520156U != num)
					{
						goto Block_23;
					}
					continue;
					Block_24:
					if (!6E0E7BE9)
					{
						num = 1731147436U / num;
						if (1756310805U - num != 0U)
						{
							goto Block_26;
						}
						continue;
					}
					else
					{
						num *= 245826213U;
						if (2063561046 << (int)num != 0)
						{
							goto Block_27;
						}
						continue;
					}
					IL_472:
					num += 1851788924U;
					if ((763718379U ^ num) == 0U)
					{
						goto IL_4C;
					}
					if (6E0E7BE9)
					{
						goto IL_4B3;
					}
					num &= 1732721928U;
					if (1784699079U >= num)
					{
						goto Block_31;
					}
					continue;
					IL_4CF:
					num = 1246788471U * num;
					if (num >> 23 == 0U)
					{
						continue;
					}
					if (!6E0E7BE9)
					{
						if (num > 2096330229U)
						{
							goto Block_34;
						}
						continue;
					}
					else
					{
						if (1634275447U != num)
						{
							goto Block_35;
						}
						goto IL_3A;
					}
					IL_2EE:
					num -= 813055132U;
					if (!6E0E7BE9)
					{
						goto Block_19;
					}
					num *= 364402469U;
					if (num % 1866685300U != 0U)
					{
						goto Block_21;
					}
					goto IL_3A;
					IL_29D:
					num = 1619358271U >> (int)num;
					if (1872394465U >= num)
					{
						goto Block_17;
					}
					goto IL_3A;
					IL_1A7:
					num -= 1400248192U;
					if (!6E0E7BE9)
					{
						goto Block_10;
					}
					if (num != 1643918489U)
					{
						goto Block_12;
					}
					goto IL_3A;
				}
				num = (845428822U & num);
				long num3 = (long)(checked((ulong)this.6C776920));
				num /= 1288977396U;
				value = num3;
				num += 356537942U;
				goto IL_8A;
				Block_6:
				num -= 1392643649U;
				ulong value2 = checked((ulong)this.6C776920);
				goto IL_10C;
				Block_7:
				value2 = (ulong)this.6C776920;
				num ^= 2902859331U;
				IL_10C:
				num -= 526796459U;
				return new UIntPtr(value2);
				Block_9:
				num ^= 0U;
				goto IL_549;
				Block_10:
				num = 289152150U * num;
				sbyte b;
				sbyte b2;
				checked
				{
					if (1090413886U != num)
					{
						num ^= 269943114U;
						b = (sbyte)this.6C776920;
						goto IL_1FF;
					}
					goto IL_4C;
					Block_12:
					b2 = (sbyte)((ulong)this.6C776920);
				}
				num -= 405175829U;
				b = b2;
				num ^= 2169065505U;
				IL_1FF:
				return b;
				Block_15:
				num = (1102210921U & num);
				short num4 = (short)this.6C776920;
				num = 1128795432U + num;
				short num5 = num4;
				goto IL_28F;
				Block_16:
				num &= 595227153U;
				ulong num6 = (ulong)this.6C776920;
				num = (272442763U | num);
				short num7 = (short)num6;
				num = 1063324358U + num;
				num5 = num7;
				num ^= 192283704U;
				IL_28F:
				num = 896156025U % num;
				return num5;
				Block_17:
				int num9;
				if (!6E0E7BE9)
				{
					num = 1555856599U * num;
					int num8 = (int)this.6C776920;
					num /= 769213952U;
					num9 = num8;
				}
				else
				{
					num9 = checked((int)((ulong)this.6C776920));
					num += 2675609026U;
				}
				return num9;
				Block_19:
				num &= 484326503U;
				long num10;
				if ((num ^ 969698300U) != 0U)
				{
					num = (1429805818U | num);
					num10 = this.6C776920;
					goto IL_357;
				}
				goto IL_4C;
				Block_21:
				num *= 1464819349U;
				long num11 = (long)(checked((ulong)this.6C776920));
				num = 24591409U / num;
				num10 = num11;
				num += 1434131198U;
				IL_357:
				return num10;
				Block_22:
				byte b3;
				checked
				{
					b3 = (byte)this.6C776920;
					goto IL_3A2;
					Block_23:
					ulong num12 = (ulong)this.6C776920;
					num ^= 1469739267U;
					b3 = (byte)num12;
				}
				num += 3043602685U;
				IL_3A2:
				num &= 1410076348U;
				return b3;
				Block_26:
				num = 1181028231U + num;
				ushort num13 = (ushort)this.6C776920;
				num = (248149856U ^ num);
				ushort num14 = num13;
				goto IL_424;
				Block_27:
				ushort num15 = (ushort)(checked((uint)this.6C776920));
				num -= 698817782U;
				num14 = num15;
				num ^= 2879036386U;
				IL_424:
				return num14;
				IL_42A:
				num %= 177042968U;
				uint num16;
				if (!6E0E7BE9)
				{
					num &= 1158939110U;
					num16 = checked((uint)this.6C776920);
				}
				else
				{
					num = 1579374253U + num;
					uint num17 = (uint)(checked((ulong)this.6C776920));
					num = 793069590U + num;
					num16 = num17;
					num += 1909164341U;
				}
				return num16;
				Block_31:
				ulong num18 = (ulong)this.6C776920;
				num = 1974944606U % num;
				ulong num19 = num18;
				goto IL_4C1;
				IL_4B3:
				num19 = (ulong)this.6C776920;
				num ^= 3784259882U;
				IL_4C1:
				num = 702875413U * num;
				return num19;
				Block_34:
				double num20 = (double)this.6C776920;
				num = 2014992054U - num;
				double num21 = num20;
				goto IL_53B;
				Block_35:
				num >>= 29;
				long num22 = this.6C776920;
				num -= 802310244U;
				double num23 = num22;
				num /= 595873224U;
				num21 = num23;
				num ^= 3409663667U;
				IL_53B:
				num |= 135141720U;
				return num21;
				IL_549:
				num -= 1983279389U;
				throw new ArgumentException();
			}
			IL_4C:
			num -= 178268242U;
			value = this.6C776920;
			IL_8A:
			num = 939727111U % num;
			IntPtr intPtr = new IntPtr(value);
			num = (435040351U ^ num);
			return intPtr;
		}

		// Token: 0x040001DA RID: 474
		private long 6C776920;
	}

	// Token: 0x02000054 RID: 84
	private sealed class 721F5C60 : 0B005140.375D71A4
	{
		// Token: 0x06000231 RID: 561 RVA: 0x000D42E8 File Offset: 0x000D42E8
		public 721F5C60(float 474F1D1D)
		{
			uint num = 145697611U;
			num = 158734830U / num;
			this.1E8F288E = 474F1D1D;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000D4310 File Offset: 0x000D4310
		public override Type 3A79FD5F()
		{
			return typeof(float);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000D4330 File Offset: 0x000D4330
		public override TypeCode 08177016()
		{
			return TypeCode.Single;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000D4340 File Offset: 0x000D4340
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 78528901U;
			float 474F1D1D = this.1E8F288E;
			num += 2120627018U;
			return new 0B005140.721F5C60(474F1D1D);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000D4368 File Offset: 0x000D4368
		public override object 611AD8EF()
		{
			uint num = 1925462768U;
			num >>= 31;
			return this.1E8F288E;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000D4390 File Offset: 0x000D4390
		public override void 53E5679E(object 5CCF0B9A)
		{
			uint num = 413298971U;
			if (1552813107U >= num)
			{
				do
				{
					num = 11604168U / num;
					float num2 = Convert.ToSingle(5CCF0B9A);
					num -= 405435847U;
					this.1E8F288E = num2;
				}
				while ((243948173U ^ num) == 0U);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000D43D8 File Offset: 0x000D43D8
		public override bool A29D7A45()
		{
			return Convert.ToBoolean(this.1E8F288E);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000D43F8 File Offset: 0x000D43F8
		public override sbyte 3759DB5E()
		{
			return (sbyte)this.1E8F288E;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000D440C File Offset: 0x000D440C
		public override short D846A716()
		{
			return (short)this.1E8F288E;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000D4428 File Offset: 0x000D4428
		public override int DCFDB33F()
		{
			return (int)this.1E8F288E;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000D4444 File Offset: 0x000D4444
		public override long EB2B8B0E()
		{
			return (long)this.1E8F288E;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000D4458 File Offset: 0x000D4458
		public override char C299D4B1()
		{
			return (char)this.1E8F288E;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000D4474 File Offset: 0x000D4474
		public override byte 7CCA383B()
		{
			uint num = 36729463U;
			byte b = (byte)this.1E8F288E;
			num = 32584727U * num;
			return b;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000D4458 File Offset: 0x000D4458
		public override ushort E35975AC()
		{
			return (ushort)this.1E8F288E;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000D4498 File Offset: 0x000D4498
		public override uint 49390C3B()
		{
			return (uint)this.1E8F288E;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000D44B4 File Offset: 0x000D44B4
		public override ulong 6DD020CC()
		{
			return (ulong)this.1E8F288E;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000D44D0 File Offset: 0x000D44D0
		public override float 84027CE6()
		{
			return this.1E8F288E;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000D44E4 File Offset: 0x000D44E4
		public override double BD97D382()
		{
			return (double)this.1E8F288E;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000D4500 File Offset: 0x000D4500
		public override IntPtr 861F6A75()
		{
			uint num2;
			for (;;)
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 1223103729U;
				if (size != num)
				{
					if (num2 != 1861950040U)
					{
						break;
					}
				}
				else
				{
					num2 = 1915175764U >> (int)num2;
					if (592707713U > num2)
					{
						goto Block_2;
					}
				}
			}
			long value = (long)this.1E8F288E;
			goto IL_69;
			Block_2:
			num2 <<= 29;
			int num3 = (int)this.1E8F288E;
			num2 = (487996422U & num2);
			long num4 = (long)num3;
			num2 ^= 1818328534U;
			value = num4;
			num2 ^= 612788519U;
			IL_69:
			num2 = (31851428U & num2);
			return new IntPtr(value);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000D4584 File Offset: 0x000D4584
		public override UIntPtr 1A796C90()
		{
			uint num = 661465576U;
			int size = IntPtr.Size;
			uint num2 = num + 3633501724U;
			num = (2130147164U ^ num);
			ulong value;
			if (size != num2)
			{
				value = (ulong)this.1E8F288E;
			}
			else
			{
				uint num3 = (uint)this.1E8F288E;
				num = 1532708963U / num;
				value = (ulong)num3;
				num ^= 1503289013U;
			}
			num = (57745595U | num);
			return new UIntPtr(value);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000D45E4 File Offset: 0x000D45E4
		public override object FBC53937(Type 620870FF, bool 1D411D37)
		{
			uint num;
			for (;;)
			{
				num = 1839550044U;
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num = (498820442U ^ num);
				if (620870FF == Type.GetTypeFromHandle(handle))
				{
					num = 299655883U + num;
					if (1540621286U + num != 0U)
					{
						break;
					}
				}
				else
				{
					num <<= 19;
					num &= 1262776343U;
					if (620870FF == typeof(UIntPtr))
					{
						num = (245576474U & num);
						if (num / 743469853U == 0U)
						{
							goto IL_88;
						}
					}
					num %= 499199352U;
					if (1821901129U != num)
					{
						num |= 340079868U;
						TypeCode typeCode = Type.GetTypeCode(620870FF);
						num = 415261840U / num;
						TypeCode typeCode2 = typeCode;
						num ^= 1792693687U;
						uint num2 = (uint)typeCode2;
						num ^= 134311083U;
						uint num3 = num2 - (num ^ 1658534169U);
						num = (2075992982U & num);
						switch (num3)
						{
						case 0:
							num = 799946302U >> (int)num;
							num = 123878355U << (int)num;
							if (!1D411D37)
							{
								goto Block_4;
							}
							num /= 2146467713U;
							if ((432551527U ^ num) != 0U)
							{
								goto Block_5;
							}
							continue;
						case 1:
							goto IL_21E;
						case 2:
							num &= 1046677817U;
							if ((num ^ 247398884U) != 0U)
							{
								goto Block_6;
							}
							continue;
						case 3:
							goto IL_249;
						case 4:
							goto IL_209;
						case 5:
							goto IL_26E;
						case 6:
							goto IL_2BA;
						case 7:
							goto IL_2A5;
						}
						goto Block_3;
					}
					break;
				}
			}
			IL_32:
			long num4 = (long)this.1E8F288E;
			num = 1296572138U / num;
			long value = num4;
			num |= 1408109338U;
			return new IntPtr(value);
			IL_88:
			ulong num5 = (ulong)this.1E8F288E;
			num = 328353165U << (int)num;
			return new UIntPtr(num5);
			Block_3:
			num ^= 0U;
			goto IL_2BA;
			Block_4:
			num %= 289503165U;
			sbyte b = (sbyte)this.1E8F288E;
			num = 1401230730U + num;
			sbyte b2 = b;
			goto IL_195;
			Block_5:
			uint num6 = (uint)this.1E8F288E;
			num = 458058296U >> (int)num;
			b2 = checked((sbyte)num6);
			num += 1060228190U;
			IL_195:
			num |= 1937070791U;
			return b2;
			Block_6:
			checked
			{
				short num8;
				if (!1D411D37)
				{
					num >>= 14;
					if ((1613045104U ^ num) == 0U)
					{
						goto IL_88;
					}
					num = 659770928U >> (int)num;
					short num7 = (short)this.1E8F288E;
					num = (2028222980U ^ num);
					num8 = num7;
				}
				else
				{
					num8 = (short)((uint)this.1E8F288E);
					num ^= 1485836279U;
				}
				return num8;
				IL_209:
				num /= 1722183447U;
				return (int)this.1E8F288E;
				IL_21E:
				num <<= 3;
				byte b3 = (byte)this.1E8F288E;
				num = 1334788383U >> (int)num;
				byte b4 = b3;
				num <<= 28;
				return b4;
				IL_249:
				num |= 628512966U;
				num = unchecked(97475541U + num);
				ushort num9 = (ushort)this.1E8F288E;
				num = (682195893U | num);
				return num9;
				IL_26E:;
			}
			if ((num ^ 735586245U) != 0U)
			{
				num = (893794180U | num);
				uint num10 = (uint)this.1E8F288E;
				num += 76219670U;
				uint num11 = num10;
				num = 1097169390U << (int)num;
				return num11;
			}
			goto IL_32;
			IL_2A5:
			num /= 410025008U;
			return checked((ulong)this.1E8F288E);
			IL_2BA:
			num /= 869431173U;
			if (num + 2129419978U != 0U)
			{
				throw new ArgumentException();
			}
			goto IL_32;
		}

		// Token: 0x040001DB RID: 475
		private float 1E8F288E;
	}

	// Token: 0x02000055 RID: 85
	private sealed class 6B6D1F66 : 0B005140.375D71A4
	{
		// Token: 0x06000246 RID: 582 RVA: 0x000D48C4 File Offset: 0x000D48C4
		public 6B6D1F66(double 702B5082)
		{
			uint num = 684020801U;
			do
			{
				base..ctor();
				num = (2066290756U & num);
				if (446772718U >= num)
				{
					break;
				}
				num %= 1580287316U;
				this.02E54C0F = 702B5082;
			}
			while (1436056125U == num);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000D490C File Offset: 0x000D490C
		public override Type 3A79FD5F()
		{
			return typeof(double);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000D4924 File Offset: 0x000D4924
		public override TypeCode 08177016()
		{
			uint num = 1151156590U;
			return (TypeCode)(num ^ 1151156576U);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000D4940 File Offset: 0x000D4940
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 565052430U;
			num <<= 30;
			double 702B = this.02E54C0F;
			num = 1731869640U * num;
			return new 0B005140.6B6D1F66(702B);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000D4970 File Offset: 0x000D4970
		public override object 611AD8EF()
		{
			return this.02E54C0F;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000D4990 File Offset: 0x000D4990
		public override void 53E5679E(object 2D7E7AB3)
		{
			uint num = 834427767U;
			num = (1741776455U | num);
			this.02E54C0F = (double)2D7E7AB3;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000D49B8 File Offset: 0x000D49B8
		public override bool A29D7A45()
		{
			uint num = 1955663162U;
			double value = this.02E54C0F;
			num *= 791436020U;
			return Convert.ToBoolean(value);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000D49E0 File Offset: 0x000D49E0
		public override sbyte 3759DB5E()
		{
			uint num = 407072927U;
			sbyte b = (sbyte)this.02E54C0F;
			num = 1513375159U + num;
			return b;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000D4A04 File Offset: 0x000D4A04
		public override short D846A716()
		{
			uint num = 2010329579U;
			short num2 = (short)this.02E54C0F;
			num /= 907041633U;
			return num2;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000D4A28 File Offset: 0x000D4A28
		public override int DCFDB33F()
		{
			return (int)this.02E54C0F;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000D4A3C File Offset: 0x000D4A3C
		public override long EB2B8B0E()
		{
			uint num = 847988277U;
			num = 686043947U - num;
			return (long)this.02E54C0F;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000D4A60 File Offset: 0x000D4A60
		public override char C299D4B1()
		{
			uint num = 1041784688U;
			num = 677453504U / num;
			return (char)this.02E54C0F;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000D4A84 File Offset: 0x000D4A84
		public override byte 7CCA383B()
		{
			uint num = 1730425350U;
			byte b = (byte)this.02E54C0F;
			num = (993602478U | num);
			return b;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000D4A60 File Offset: 0x000D4A60
		public override ushort E35975AC()
		{
			uint num = 1041784688U;
			num = 677453504U / num;
			return (ushort)this.02E54C0F;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000D4AA8 File Offset: 0x000D4AA8
		public override uint 49390C3B()
		{
			return (uint)this.02E54C0F;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000D4AC4 File Offset: 0x000D4AC4
		public override ulong 6DD020CC()
		{
			uint num = 523793471U;
			num %= 282282121U;
			ulong num2 = (ulong)this.02E54C0F;
			num = (732576321U ^ num);
			return num2;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000D4AF0 File Offset: 0x000D4AF0
		public override float 84027CE6()
		{
			uint num = 640890191U;
			num -= 772898674U;
			return (float)this.02E54C0F;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000D4B14 File Offset: 0x000D4B14
		public override double BD97D382()
		{
			return this.02E54C0F;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000D4B28 File Offset: 0x000D4B28
		public override IntPtr 861F6A75()
		{
			uint num = 361200792U;
			long value;
			if (num <= 502945484U)
			{
				do
				{
					uint size = (uint)IntPtr.Size;
					num >>= 3;
					if (size == num + 4249817201U)
					{
						goto IL_51;
					}
					num &= 848115697U;
				}
				while (num > 761800469U);
				num += 1221809710U;
				value = (long)this.02E54C0F;
				goto IL_81;
			}
			IL_51:
			num = (1600800513U ^ num);
			num *= 1551381869U;
			int num2 = (int)this.02E54C0F;
			num = 1297227835U % num;
			long num3 = (long)num2;
			num &= 1808029828U;
			value = num3;
			num += 34831807U;
			IL_81:
			return new IntPtr(value);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000D4BBC File Offset: 0x000D4BBC
		public override UIntPtr 1A796C90()
		{
			uint num = 902123117U;
			ulong value;
			if (1979408222U > num)
			{
				do
				{
					int size = IntPtr.Size;
					uint num2 = num - 902123113U;
					num = 1768688536U % num;
					if (size == num2)
					{
						goto IL_49;
					}
					num = 512308613U - num;
				}
				while (num <= 450307589U);
				value = (ulong)this.02E54C0F;
				goto IL_71;
			}
			IL_49:
			num %= 1119880037U;
			num = (2015973499U & num);
			ulong num3 = (ulong)((uint)this.02E54C0F);
			num >>= 12;
			value = num3;
			num ^= 3940645467U;
			IL_71:
			return new UIntPtr(value);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000D4C40 File Offset: 0x000D4C40
		public override object FBC53937(Type 0C043CF2, bool 4C780421)
		{
			uint num;
			for (;;)
			{
				IL_00:
				num = 1741036199U;
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num = 463816815U % num;
				if (0C043CF2 == Type.GetTypeFromHandle(handle))
				{
					break;
				}
				while (230424642U < num)
				{
					num |= 2126057165U;
					if (0C043CF2 == typeof(UIntPtr))
					{
						if (num % 247863773U != 0U)
						{
							break;
						}
						goto IL_00;
					}
					else
					{
						num &= 1616191630U;
						TypeCode typeCode = Type.GetTypeCode(0C043CF2);
						num |= 490677800U;
						if ((num ^ 430573064U) != 0U)
						{
							uint num2 = (uint)typeCode;
							num = 1423595635U * num;
							switch (num2 - (num ^ 14037039U))
							{
							case 0U:
								num = 537600409U >> (int)num;
								num |= 1428101965U;
								if (4C780421)
								{
									goto IL_142;
								}
								num -= 332469595U;
								if (num > 743207874U)
								{
									goto Block_6;
								}
								goto IL_00;
							case 1U:
								goto IL_1F5;
							case 2U:
								num *= 1729389806U;
								if (862535726U - num != 0U)
								{
									goto Block_7;
								}
								goto IL_00;
							case 3U:
								num ^= 1464806196U;
								if (num >> 17 != 0U)
								{
									goto Block_11;
								}
								continue;
							case 4U:
								goto IL_1B2;
							case 5U:
								num = 819754038U - num;
								if (945316108U > num)
								{
									goto Block_12;
								}
								goto IL_00;
							case 6U:
								goto IL_1E8;
							case 7U:
								if (383401706 << (int)num != 0)
								{
									goto Block_13;
								}
								goto IL_00;
							case 8U:
								goto IL_2D0;
							case 9U:
								goto IL_2AC;
							}
							goto Block_4;
						}
						goto IL_00;
					}
				}
				goto IL_77;
			}
			num *= 1143538726U;
			IL_26:
			num = 542723215U % num;
			long num3 = (long)this.02E54C0F;
			num += 1949589130U;
			return new IntPtr(num3);
			IL_77:
			UIntPtr uintPtr = new UIntPtr(checked((ulong)this.02E54C0F));
			num = 1574638157U * num;
			return uintPtr;
			Block_4:
			num ^= 0U;
			goto IL_2D0;
			Block_6:
			num <<= 10;
			sbyte b = checked((sbyte)this.02E54C0F);
			goto IL_162;
			IL_142:
			num -= 2036689214U;
			uint num4 = (uint)this.02E54C0F;
			num = (1546333722U | num);
			uint num9;
			checked
			{
				b = (sbyte)num4;
				num ^= 3886184095U;
				IL_162:
				return b;
				Block_7:
				num = 167647127U << (int)num;
				short num5;
				if (!4C780421)
				{
					num5 = (short)this.02E54C0F;
				}
				else
				{
					num5 = (short)((uint)this.02E54C0F);
					num ^= 0U;
				}
				return num5;
				IL_1B2:
				num = 1998091058U >> (int)num;
				if (num <= 1195668022U)
				{
					int num6 = (int)this.02E54C0F;
					num = (503606755U & num);
					int num7 = num6;
					num ^= 75235624U;
					return num7;
				}
				goto IL_26;
				IL_1E8:
				return (long)this.02E54C0F;
				IL_1F5:
				num |= 704541285U;
				if (num << 29 != 0U)
				{
					num = (1684095785U & num);
					byte b2 = (byte)this.02E54C0F;
					num = 1956405875U >> (int)num;
					return b2;
				}
				goto IL_26;
				Block_11:
				num = 597964249U / num;
				ushort num8 = (ushort)this.02E54C0F;
				num &= 521540387U;
				return num8;
				Block_12:
				num9 = (uint)this.02E54C0F;
			}
			num += 1336676555U;
			return num9;
			Block_13:
			num = (665390086U & num);
			return checked((ulong)this.02E54C0F);
			IL_2AC:
			num = 1978145002U + num;
			num %= 278216097U;
			double num10 = this.02E54C0F;
			num = 1956667954U % num;
			return num10;
			IL_2D0:
			num = 390209172U / num;
			throw new ArgumentException();
		}

		// Token: 0x040001DC RID: 476
		private double 02E54C0F;
	}

	// Token: 0x02000056 RID: 86
	private sealed class 3C1E7579 : 0B005140.375D71A4
	{
		// Token: 0x0600025B RID: 603 RVA: 0x000D4F2C File Offset: 0x000D4F2C
		public 3C1E7579(string 28414112)
		{
			uint num = 457992989U;
			num += 1310420721U;
			base..ctor();
			num = 720994028U % num;
			this.6A744B73 = 28414112;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000D4F5C File Offset: 0x000D4F5C
		public override Type 3A79FD5F()
		{
			return typeof(string);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000C2644 File Offset: 0x000C2644
		public override TypeCode 08177016()
		{
			return TypeCode.Object;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000D4F7C File Offset: 0x000D4F7C
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.3C1E7579(this.6A744B73);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000D4F9C File Offset: 0x000D4F9C
		public override object 611AD8EF()
		{
			return this.6A744B73;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000D4FB8 File Offset: 0x000D4FB8
		public override void 53E5679E(object 3A133FE1)
		{
			string text;
			if (3A133FE1 == null)
			{
				text = null;
			}
			else
			{
				uint num = 1634669786U;
				text = Convert.ToString(3A133FE1);
				num += 3866234486U;
			}
			this.6A744B73 = text;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000D4FF4 File Offset: 0x000D4FF4
		public override bool A29D7A45()
		{
			return this.6A744B73 != null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000D4F9C File Offset: 0x000D4F9C
		public override string ToString()
		{
			return this.6A744B73;
		}

		// Token: 0x040001DD RID: 477
		private string 6A744B73;
	}

	// Token: 0x02000057 RID: 87
	private sealed class 083F6CB0 : 0B005140.124B6895
	{
		// Token: 0x06000263 RID: 611 RVA: 0x000D5010 File Offset: 0x000D5010
		public 083F6CB0(short 004C0E5C)
		{
			uint num = 390743959U;
			num *= 209138285U;
			num += 754718069U;
			this.0FC83C5D = 004C0E5C;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000D5040 File Offset: 0x000D5040
		public override Type 3A79FD5F()
		{
			return typeof(short);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000D5060 File Offset: 0x000D5060
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 848758366U;
			short 004C0E5C = this.0FC83C5D;
			num += 2114473624U;
			return new 0B005140.083F6CB0(004C0E5C);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000D5088 File Offset: 0x000D5088
		public override object 611AD8EF()
		{
			uint num = 1807171680U;
			num /= 958822996U;
			short num2 = this.0FC83C5D;
			num = 749096478U % num;
			return num2;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000D50B8 File Offset: 0x000D50B8
		public override void 53E5679E(object 26740081)
		{
			uint num;
			do
			{
				num = 2082241442U;
				short num2 = Convert.ToInt16(26740081);
				num += 574101783U;
				this.0FC83C5D = num2;
			}
			while (954038934U >> (int)num == 0U);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000D50F4 File Offset: 0x000D50F4
		public override 0B005140.375D71A4 58C2988C()
		{
			uint num = 1163946736U;
			num = (1665598854U ^ num);
			int 0D6B27B = this.DCFDB33F();
			num = 1185027903U + num;
			return new 0B005140.07685083(0D6B27B);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000D5124 File Offset: 0x000D5124
		public override sbyte 3759DB5E()
		{
			return (sbyte)this.0FC83C5D;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000D5140 File Offset: 0x000D5140
		public override byte 7CCA383B()
		{
			return (byte)this.0FC83C5D;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000D5154 File Offset: 0x000D5154
		public override short D846A716()
		{
			return this.0FC83C5D;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000D5168 File Offset: 0x000D5168
		public override ushort E35975AC()
		{
			return (ushort)this.0FC83C5D;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000D5154 File Offset: 0x000D5154
		public override int DCFDB33F()
		{
			return (int)this.0FC83C5D;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000D5154 File Offset: 0x000D5154
		public override uint 49390C3B()
		{
			return (uint)this.0FC83C5D;
		}

		// Token: 0x040001DE RID: 478
		private short 0FC83C5D;
	}

	// Token: 0x02000058 RID: 88
	private sealed class 4F521487 : 0B005140.124B6895
	{
		// Token: 0x0600026F RID: 623 RVA: 0x000D517C File Offset: 0x000D517C
		public 4F521487(ushort 321F1B61)
		{
			uint num;
			do
			{
				num = 1742890683U;
				base..ctor();
			}
			while (1762874532U - num == 0U);
			do
			{
				num = (1995186299U | num);
				this.790404E1 = 321F1B61;
			}
			while (num + 1351119114U == 0U);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000D51BC File Offset: 0x000D51BC
		public override Type 3A79FD5F()
		{
			return typeof(ushort);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000D51DC File Offset: 0x000D51DC
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 2071922602U;
			ushort 321F1B = this.790404E1;
			num = (1233857774U & num);
			return new 0B005140.4F521487(321F1B);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000D5204 File Offset: 0x000D5204
		public override object 611AD8EF()
		{
			uint num = 440612106U;
			num &= 228932131U;
			ushort num2 = this.790404E1;
			num = 1574852501U >> (int)num;
			return num2;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000D5238 File Offset: 0x000D5238
		public override void 53E5679E(object 3C681A20)
		{
			uint num = 388066993U;
			ushort num2 = Convert.ToUInt16(3C681A20);
			num = 485844863U / num;
			this.790404E1 = num2;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000D50F4 File Offset: 0x000D50F4
		public override 0B005140.375D71A4 58C2988C()
		{
			uint num = 1163946736U;
			num = (1665598854U ^ num);
			int 0D6B27B = this.DCFDB33F();
			num = 1185027903U + num;
			return new 0B005140.07685083(0D6B27B);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000D5260 File Offset: 0x000D5260
		public override sbyte 3759DB5E()
		{
			return (sbyte)this.790404E1;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000D527C File Offset: 0x000D527C
		public override byte 7CCA383B()
		{
			uint num = 543388843U;
			num -= 967908219U;
			byte b = (byte)this.790404E1;
			num = (1510944269U | num);
			return b;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000D52A8 File Offset: 0x000D52A8
		public override short D846A716()
		{
			uint num = 537540646U;
			short num2 = (short)this.790404E1;
			num = 1625256903U * num;
			return num2;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000D52CC File Offset: 0x000D52CC
		public override ushort E35975AC()
		{
			return this.790404E1;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000D52CC File Offset: 0x000D52CC
		public override int DCFDB33F()
		{
			return (int)this.790404E1;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000D52CC File Offset: 0x000D52CC
		public override uint 49390C3B()
		{
			return (uint)this.790404E1;
		}

		// Token: 0x040001DF RID: 479
		private ushort 790404E1;
	}

	// Token: 0x02000059 RID: 89
	private sealed class 759B7CAC : 0B005140.124B6895
	{
		// Token: 0x0600027B RID: 635 RVA: 0x000D52E8 File Offset: 0x000D52E8
		public 759B7CAC(bool 59293657)
		{
			uint num = 238960369U;
			if (2057977420U >= num)
			{
				do
				{
					num |= 2018116995U;
					base..ctor();
				}
				while ((num ^ 1307659059U) == 0U);
			}
			do
			{
				num *= 2118133511U;
				this.1E0205F6 = 59293657;
			}
			while (1607992836U % num == 0U);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000D533C File Offset: 0x000D533C
		public override Type 3A79FD5F()
		{
			return typeof(bool);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000D535C File Offset: 0x000D535C
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 435704771U;
			bool <<EMPTY_NAME>> = this.1E0205F6;
			num = (393703861U & num);
			return new 0B005140.759B7CAC(<<EMPTY_NAME>>);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000D5384 File Offset: 0x000D5384
		public override object 611AD8EF()
		{
			uint num = 1327236869U;
			num = 1962558521U % num;
			bool flag = this.1E0205F6;
			num = 1330726144U - num;
			return flag;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000D53B4 File Offset: 0x000D53B4
		public override void 53E5679E(object 2FCC159F)
		{
			uint num = 1662718751U;
			if (1369060044U % num != 0U)
			{
				do
				{
					bool flag = Convert.ToBoolean(2FCC159F);
					num = 848523968U >> (int)num;
					this.1E0205F6 = flag;
				}
				while (num >= 2135163441U);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000D50F4 File Offset: 0x000D50F4
		public override 0B005140.375D71A4 58C2988C()
		{
			uint num = 1163946736U;
			num = (1665598854U ^ num);
			int 0D6B27B = this.DCFDB33F();
			num = 1185027903U + num;
			return new 0B005140.07685083(0D6B27B);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000D53F8 File Offset: 0x000D53F8
		public override int DCFDB33F()
		{
			uint num = 908948049U;
			if (num >= 452859449U)
			{
				num %= 1950945767U;
				bool flag = this.1E0205F6;
				num /= 132975539U;
				if (!flag)
				{
					num %= 74006639U;
					return (int)(num ^ 6U);
				}
			}
			num &= 738538616U;
			return (int)(num - uint.MaxValue);
		}

		// Token: 0x040001E0 RID: 480
		private bool 1E0205F6;
	}

	// Token: 0x0200005A RID: 90
	private sealed class 7EB526D5 : 0B005140.124B6895
	{
		// Token: 0x06000282 RID: 642 RVA: 0x000D5450 File Offset: 0x000D5450
		public 7EB526D5(char 4ACB4F98)
		{
			uint num = 1904556113U;
			if (num != 482624511U)
			{
				do
				{
					num /= 1145199523U;
					base..ctor();
					num <<= 20;
				}
				while (num == 2100832954U);
				do
				{
					num &= 330315470U;
					num = (708325064U & num);
					this.0CCC2DF8 = 4ACB4F98;
				}
				while (2102535931U % num == 0U);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000D54B4 File Offset: 0x000D54B4
		public override Type 3A79FD5F()
		{
			return typeof(char);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000D54D4 File Offset: 0x000D54D4
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 527716597U;
			char 4ACB4F = this.0CCC2DF8;
			num = (1953912107U | num);
			return new 0B005140.7EB526D5(4ACB4F);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000D54FC File Offset: 0x000D54FC
		public override object 611AD8EF()
		{
			uint num = 780893781U;
			char c = this.0CCC2DF8;
			num = 329656290U << (int)num;
			return c;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000D5528 File Offset: 0x000D5528
		public override void 53E5679E(object 5E144F26)
		{
			uint num = 1614940127U;
			if (num >= 1245149586U)
			{
				num <<= 10;
				this.0CCC2DF8 = Convert.ToChar(5E144F26);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000D50F4 File Offset: 0x000D50F4
		public override 0B005140.375D71A4 58C2988C()
		{
			uint num = 1163946736U;
			num = (1665598854U ^ num);
			int 0D6B27B = this.DCFDB33F();
			num = 1185027903U + num;
			return new 0B005140.07685083(0D6B27B);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000D555C File Offset: 0x000D555C
		public override sbyte 3759DB5E()
		{
			uint num = 179056512U;
			num = (1729126167U & num);
			sbyte b = (sbyte)this.0CCC2DF8;
			num = 1198000712U + num;
			return b;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000D5588 File Offset: 0x000D5588
		public override byte 7CCA383B()
		{
			return (byte)this.0CCC2DF8;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000D55A4 File Offset: 0x000D55A4
		public override short D846A716()
		{
			uint num = 1832993183U;
			num %= 605371952U;
			return (short)this.0CCC2DF8;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000D55C8 File Offset: 0x000D55C8
		public override ushort E35975AC()
		{
			return (ushort)this.0CCC2DF8;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000D55C8 File Offset: 0x000D55C8
		public override int DCFDB33F()
		{
			return (int)this.0CCC2DF8;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000D55C8 File Offset: 0x000D55C8
		public override uint 49390C3B()
		{
			return (uint)this.0CCC2DF8;
		}

		// Token: 0x040001E1 RID: 481
		private char 0CCC2DF8;
	}

	// Token: 0x0200005B RID: 91
	private sealed class 560C2D3B : 0B005140.124B6895
	{
		// Token: 0x0600028E RID: 654 RVA: 0x000D55E4 File Offset: 0x000D55E4
		public 560C2D3B(byte 22DC5421)
		{
			uint num = 281810590U;
			do
			{
				base..ctor();
				num %= 636768930U;
			}
			while (2142717856U == num);
			num %= 255754078U;
			num += 797781495U;
			this.5E241B26 = 22DC5421;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000D5628 File Offset: 0x000D5628
		public override Type 3A79FD5F()
		{
			return typeof(byte);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000D5648 File Offset: 0x000D5648
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 1599228674U;
			num += 961231288U;
			byte 22DC = this.5E241B26;
			num = 1146893701U >> (int)num;
			return new 0B005140.560C2D3B(22DC);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000D567C File Offset: 0x000D567C
		public override object 611AD8EF()
		{
			return this.5E241B26;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000D569C File Offset: 0x000D569C
		public override void 53E5679E(object 3EC8249F)
		{
			uint num;
			do
			{
				num = 651249070U;
				byte b = Convert.ToByte(3EC8249F);
				num = 464130783U / num;
				this.5E241B26 = b;
			}
			while (1671116217U * num != 0U);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000D50F4 File Offset: 0x000D50F4
		public override 0B005140.375D71A4 58C2988C()
		{
			uint num = 1163946736U;
			num = (1665598854U ^ num);
			int 0D6B27B = this.DCFDB33F();
			num = 1185027903U + num;
			return new 0B005140.07685083(0D6B27B);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000D56D0 File Offset: 0x000D56D0
		public override sbyte 3759DB5E()
		{
			uint num = 2022906940U;
			num = (1455900087U | num);
			sbyte b = (sbyte)this.5E241B26;
			num += 242684359U;
			return b;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000D56FC File Offset: 0x000D56FC
		public override byte 7CCA383B()
		{
			return this.5E241B26;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000D56FC File Offset: 0x000D56FC
		public override short D846A716()
		{
			return (short)this.5E241B26;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000D56FC File Offset: 0x000D56FC
		public override ushort E35975AC()
		{
			return (ushort)this.5E241B26;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000D56FC File Offset: 0x000D56FC
		public override int DCFDB33F()
		{
			return (int)this.5E241B26;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000D56FC File Offset: 0x000D56FC
		public override uint 49390C3B()
		{
			return (uint)this.5E241B26;
		}

		// Token: 0x040001E2 RID: 482
		private byte 5E241B26;
	}

	// Token: 0x0200005C RID: 92
	private sealed class 67617919 : 0B005140.124B6895
	{
		// Token: 0x0600029A RID: 666 RVA: 0x000D5718 File Offset: 0x000D5718
		public 67617919(sbyte 20251814)
		{
			uint num = 836529000U;
			do
			{
				base..ctor();
				num += 1531316273U;
				if (num == 1842811941U)
				{
					break;
				}
				this.79FD4E25 = 20251814;
			}
			while ((1499683742U & num) == 0U);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000D5758 File Offset: 0x000D5758
		public override Type 3A79FD5F()
		{
			return typeof(sbyte);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000D5778 File Offset: 0x000D5778
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.67617919(this.79FD4E25);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000D5798 File Offset: 0x000D5798
		public override object 611AD8EF()
		{
			uint num = 787109101U;
			num /= 1253776348U;
			return this.79FD4E25;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000D57C0 File Offset: 0x000D57C0
		public override void 53E5679E(object 2402343A)
		{
			uint num;
			do
			{
				num = 1212943731U;
				num = 802368968U % num;
				this.79FD4E25 = Convert.ToSByte(2402343A);
			}
			while (num == 1737635936U);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000D50F4 File Offset: 0x000D50F4
		public override 0B005140.375D71A4 58C2988C()
		{
			uint num = 1163946736U;
			num = (1665598854U ^ num);
			int 0D6B27B = this.DCFDB33F();
			num = 1185027903U + num;
			return new 0B005140.07685083(0D6B27B);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000D57F4 File Offset: 0x000D57F4
		public override sbyte 3759DB5E()
		{
			return this.79FD4E25;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000D5808 File Offset: 0x000D5808
		public override byte 7CCA383B()
		{
			return (byte)this.79FD4E25;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000D57F4 File Offset: 0x000D57F4
		public override short D846A716()
		{
			return (short)this.79FD4E25;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000D5824 File Offset: 0x000D5824
		public override ushort E35975AC()
		{
			return (ushort)this.79FD4E25;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000D57F4 File Offset: 0x000D57F4
		public override int DCFDB33F()
		{
			return (int)this.79FD4E25;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000D57F4 File Offset: 0x000D57F4
		public override uint 49390C3B()
		{
			return (uint)this.79FD4E25;
		}

		// Token: 0x040001E3 RID: 483
		private sbyte 79FD4E25;
	}

	// Token: 0x0200005D RID: 93
	private sealed class 074A0932 : 0B005140.124B6895
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x000D5840 File Offset: 0x000D5840
		public 074A0932(uint 50E55136)
		{
			uint num;
			do
			{
				num = 445456604U;
				this.2BFF6C7B = 50E55136;
			}
			while (1662143197U % num == 0U);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000D586C File Offset: 0x000D586C
		public override Type 3A79FD5F()
		{
			return typeof(uint);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000D588C File Offset: 0x000D588C
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 2135571083U;
			num ^= 1817264535U;
			return new 0B005140.074A0932(this.2BFF6C7B);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000D58B4 File Offset: 0x000D58B4
		public override object 611AD8EF()
		{
			return this.2BFF6C7B;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000D58D4 File Offset: 0x000D58D4
		public override void 53E5679E(object 4AF12AE8)
		{
			this.2BFF6C7B = Convert.ToUInt32(4AF12AE8);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000D50F4 File Offset: 0x000D50F4
		public override 0B005140.375D71A4 58C2988C()
		{
			uint num = 1163946736U;
			num = (1665598854U ^ num);
			int 0D6B27B = this.DCFDB33F();
			num = 1185027903U + num;
			return new 0B005140.07685083(0D6B27B);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000D58F4 File Offset: 0x000D58F4
		public override sbyte 3759DB5E()
		{
			uint num = 659885081U;
			sbyte b = (sbyte)this.2BFF6C7B;
			num <<= 13;
			return b;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000D5918 File Offset: 0x000D5918
		public override byte 7CCA383B()
		{
			uint num = 1401700038U;
			byte b = (byte)this.2BFF6C7B;
			num &= 1634367012U;
			return b;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000D593C File Offset: 0x000D593C
		public override short D846A716()
		{
			return (short)this.2BFF6C7B;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000D5950 File Offset: 0x000D5950
		public override ushort E35975AC()
		{
			return (ushort)this.2BFF6C7B;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000D596C File Offset: 0x000D596C
		public override int DCFDB33F()
		{
			return (int)this.2BFF6C7B;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000D596C File Offset: 0x000D596C
		public override uint 49390C3B()
		{
			return this.2BFF6C7B;
		}

		// Token: 0x040001E4 RID: 484
		private uint 2BFF6C7B;
	}

	// Token: 0x0200005E RID: 94
	private sealed class 2BAF4849 : 0B005140.124B6895
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x000D5988 File Offset: 0x000D5988
		public 2BAF4849(ulong 0F4F2172)
		{
			uint num = 1840585893U;
			num %= 835139103U;
			num &= 686240599U;
			this.08061315 = 0F4F2172;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000D59B8 File Offset: 0x000D59B8
		public override Type 3A79FD5F()
		{
			return typeof(ulong);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000D59D0 File Offset: 0x000D59D0
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 1346791293U;
			ulong 0F4F = this.08061315;
			num -= 1551587222U;
			return new 0B005140.2BAF4849(0F4F);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000D59F8 File Offset: 0x000D59F8
		public override object 611AD8EF()
		{
			return this.08061315;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000D5A10 File Offset: 0x000D5A10
		public override void 53E5679E(object 3C5922DF)
		{
			uint num = 775291160U;
			if (num != 1320821590U)
			{
				num -= 1967077711U;
				num = (701328400U & num);
				ulong num2 = Convert.ToUInt64(3C5922DF);
				num = (110842661U & num);
				this.08061315 = num2;
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000D5A54 File Offset: 0x000D5A54
		public override 0B005140.375D71A4 58C2988C()
		{
			uint num = 115360347U;
			num = 1285838148U * num;
			return new 0B005140.13AF7E46(this.EB2B8B0E());
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000D5A7C File Offset: 0x000D5A7C
		public override sbyte 3759DB5E()
		{
			return (sbyte)this.08061315;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000D5A90 File Offset: 0x000D5A90
		public override byte 7CCA383B()
		{
			return (byte)this.08061315;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000D5AAC File Offset: 0x000D5AAC
		public override short D846A716()
		{
			uint num = 2052610730U;
			num %= 1032015372U;
			short num2 = (short)this.08061315;
			num &= 545156134U;
			return num2;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000D5AD8 File Offset: 0x000D5AD8
		public override ushort E35975AC()
		{
			uint num = 1710586240U;
			num -= 497448577U;
			ushort num2 = (ushort)this.08061315;
			num = (233009553U ^ num);
			return num2;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000D5B04 File Offset: 0x000D5B04
		public override int DCFDB33F()
		{
			uint num = 1795972029U;
			num = (343821707U ^ num);
			int num2 = (int)this.08061315;
			num = 1965310107U / num;
			return num2;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000D5B30 File Offset: 0x000D5B30
		public override uint 49390C3B()
		{
			return (uint)this.08061315;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000D5B4C File Offset: 0x000D5B4C
		public override long EB2B8B0E()
		{
			uint num = 911239047U;
			num = 1806504913U - num;
			return (long)this.08061315;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000D5B4C File Offset: 0x000D5B4C
		public override ulong 6DD020CC()
		{
			uint num = 911239047U;
			num = 1806504913U - num;
			return this.08061315;
		}

		// Token: 0x040001E5 RID: 485
		private ulong 08061315;
	}

	// Token: 0x0200005F RID: 95
	private sealed class 744E73A6 : 0B005140.375D71A4
	{
		// Token: 0x060002C0 RID: 704 RVA: 0x000D5B70 File Offset: 0x000D5B70
		public 744E73A6(object 4E073154)
		{
			uint num = 159777500U;
			do
			{
				base..ctor();
				num = (2129149348U & num);
			}
			while (num == 2016434165U);
			num += 731414322U;
			this.1EA438C2 = 4E073154;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000D5BAC File Offset: 0x000D5BAC
		public override Type 3A79FD5F()
		{
			return typeof(object);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000C2644 File Offset: 0x000C2644
		public override TypeCode 08177016()
		{
			return TypeCode.Object;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000D5BCC File Offset: 0x000D5BCC
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 609443441U;
			object 4E = this.1EA438C2;
			num = 1200388044U / num;
			return new 0B005140.744E73A6(4E);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000D5BF4 File Offset: 0x000D5BF4
		public override object 611AD8EF()
		{
			return this.1EA438C2;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000D5C10 File Offset: 0x000D5C10
		public override void 53E5679E(object 7D11121C)
		{
			this.1EA438C2 = 7D11121C;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000D5C24 File Offset: 0x000D5C24
		public override bool A29D7A45()
		{
			return this.1EA438C2 != null;
		}

		// Token: 0x040001E6 RID: 486
		private object 1EA438C2;
	}

	// Token: 0x02000060 RID: 96
	private sealed class 03371198 : 0B005140.375D71A4
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x000D5C3C File Offset: 0x000D5C3C
		public 03371198(object 019B20B6, Type 255177ED)
		{
			uint num = 409223242U;
			if (num != 2087526614U)
			{
				goto IL_11;
			}
			do
			{
				IL_27:
				num = 1533884750U - num;
				this.7BD34488 = 019B20B6;
				num = (1426081453U & num);
				num <<= 28;
				this.4B2A7835 = 255177ED;
			}
			while (num - 192951982U == 0U);
			0B005140.124B6895 124B = 0B005140.03371198.34A85A8F(019B20B6);
			num = 1863463052U * num;
			this.44AB6134 = 124B;
			if (num % 1709924455U == 0U)
			{
				return;
			}
			IL_11:
			num = 1285562469U * num;
			base..ctor();
			num = 713120978U - num;
			goto IL_27;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000D5CC4 File Offset: 0x000D5CC4
		private static 0B005140.124B6895 34A85A8F(object 0C416277)
		{
			uint num = 323376753U;
			num += 942102854U;
			IntPtr intPtr;
			if (0C416277 != null)
			{
				num = (1729905286U ^ num);
				num = 1687633579U % num;
				intPtr = new IntPtr(Pointer.Unbox(0C416277));
			}
			else
			{
				num = 1035754951U % num;
				intPtr = IntPtr.Zero;
				num += 3455518338U;
			}
			num = 1252014446U + num;
			IntPtr intPtr2 = intPtr;
			if (IntPtr.Size == (int)(num - 1448320435U))
			{
				num &= 84568593U;
				if (498033332U != num)
				{
					return new 0B005140.07685083(intPtr2.ToInt32());
				}
			}
			return new 0B005140.13AF7E46(intPtr2.ToInt64());
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000D5BAC File Offset: 0x000D5BAC
		public override Type 3A79FD5F()
		{
			return typeof(object);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000D5D60 File Offset: 0x000D5D60
		public Type 0E8448DC()
		{
			return this.4B2A7835;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000D5D74 File Offset: 0x000D5D74
		public override TypeCode 08177016()
		{
			uint num = 400565631U;
			if (1865356816U > num)
			{
				int size = IntPtr.Size;
				num &= 1063480427U;
				uint num2 = num ^ 392176751U;
				num = 1917340147U << (int)num;
				if (size == num2)
				{
					num = 481191881U >> (int)num;
					return (int)num + (TypeCode)(-481191871);
				}
			}
			return (int)num + (TypeCode)(-1112512500);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000D5DD8 File Offset: 0x000D5DD8
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.03371198(this.7BD34488, this.4B2A7835);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000D5DF8 File Offset: 0x000D5DF8
		public override object 611AD8EF()
		{
			uint num = 1502306722U;
			num *= 982346220U;
			return this.7BD34488;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000D5E1C File Offset: 0x000D5E1C
		public override void 53E5679E(object 3F300023)
		{
			uint num = 1980388473U;
			if ((2110004193U & num) != 0U)
			{
				num %= 1986536775U;
				this.7BD34488 = 3F300023;
			}
			num ^= 1930713010U;
			num = (1427332804U ^ num);
			0B005140.124B6895 124B = 0B005140.03371198.34A85A8F(3F300023);
			num %= 1976043429U;
			this.44AB6134 = 124B;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000D5E70 File Offset: 0x000D5E70
		public override bool A29D7A45()
		{
			uint num = 91780595U;
			object obj = this.7BD34488;
			num = (506203528U & num);
			return obj != null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000D5E94 File Offset: 0x000D5E94
		public override sbyte 3759DB5E()
		{
			uint num = 1214919259U;
			num *= 1523867327U;
			return this.44AB6134.3759DB5E();
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000D5EBC File Offset: 0x000D5EBC
		public override short D846A716()
		{
			return this.44AB6134.D846A716();
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000D5EDC File Offset: 0x000D5EDC
		public override int DCFDB33F()
		{
			uint num = 2045475368U;
			0B005140.124B6895 124B = this.44AB6134;
			num |= 355807004U;
			return 124B.DCFDB33F();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000D5F04 File Offset: 0x000D5F04
		public override long EB2B8B0E()
		{
			uint num = 33107169U;
			0B005140.124B6895 124B = this.44AB6134;
			num *= 121243395U;
			return 124B.EB2B8B0E();
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000D5F2C File Offset: 0x000D5F2C
		public override byte 7CCA383B()
		{
			uint num = 1597406739U;
			0B005140.124B6895 124B = this.44AB6134;
			num %= 1897163568U;
			return 124B.7CCA383B();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000D5F54 File Offset: 0x000D5F54
		public override ushort E35975AC()
		{
			uint num = 1588073482U;
			num >>= 1;
			0B005140.124B6895 124B = this.44AB6134;
			num >>= 7;
			return 124B.E35975AC();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000D5F84 File Offset: 0x000D5F84
		public override uint 49390C3B()
		{
			return this.44AB6134.49390C3B();
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000D5FA4 File Offset: 0x000D5FA4
		public override ulong 6DD020CC()
		{
			return this.44AB6134.6DD020CC();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000D5FC4 File Offset: 0x000D5FC4
		public override float 84027CE6()
		{
			return this.44AB6134.84027CE6();
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000D5FE4 File Offset: 0x000D5FE4
		public override double BD97D382()
		{
			return this.44AB6134.BD97D382();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000D5FFC File Offset: 0x000D5FFC
		public override IntPtr 861F6A75()
		{
			uint num = 1272276089U;
			num %= 334496001U;
			0B005140.124B6895 124B = this.44AB6134;
			num %= 1827172242U;
			return 124B.861F6A75();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000D602C File Offset: 0x000D602C
		public override UIntPtr 1A796C90()
		{
			return this.44AB6134.1A796C90();
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000D6044 File Offset: 0x000D6044
		public override object FBC53937(Type 18645D08, bool 4AD3627C)
		{
			return this.44AB6134.FBC53937(18645D08, 4AD3627C);
		}

		// Token: 0x040001E7 RID: 487
		private object 7BD34488;

		// Token: 0x040001E8 RID: 488
		private Type 4B2A7835;

		// Token: 0x040001E9 RID: 489
		private 0B005140.124B6895 44AB6134;
	}

	// Token: 0x02000061 RID: 97
	private sealed class 4FCC199C : 0B005140.375D71A4
	{
		// Token: 0x060002DD RID: 733 RVA: 0x000D6064 File Offset: 0x000D6064
		public 4FCC199C(object 14D50CDD)
		{
			uint num = 1576291747U;
			for (;;)
			{
				base..ctor();
				num /= 2000448350U;
				for (;;)
				{
					if (14D50CDD != null)
					{
						if (num > 1914984321U)
						{
							break;
						}
						num = (1769631505U ^ num);
						bool flag = 14D50CDD is ValueType;
						num ^= 1769631505U;
						if (!flag)
						{
							goto Block_3;
						}
					}
					num &= 394553558U;
					if (num < 396239116U)
					{
						goto Block_5;
					}
				}
			}
			Block_3:
			if (780812507U >= num)
			{
				throw new ArgumentException();
			}
			return;
			Block_5:
			num ^= 1492258101U;
			this.56D0249A = 14D50CDD;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000D60E4 File Offset: 0x000D60E4
		public override Type 3A79FD5F()
		{
			return typeof(ValueType);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000D6104 File Offset: 0x000D6104
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.4FCC199C(this.56D0249A);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000D6124 File Offset: 0x000D6124
		public override object 611AD8EF()
		{
			uint num = 1919690683U;
			num <<= 21;
			return this.56D0249A;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000D6148 File Offset: 0x000D6148
		public override void 53E5679E(object 4C982720)
		{
			uint num = 1001415308U;
			for (;;)
			{
				num += 2099010793U;
				if (4C982720 != null)
				{
					num -= 167473617U;
					if (724718642U * num == 0U)
					{
						continue;
					}
					bool flag = 4C982720 is ValueType;
					num = 384508404U >> (int)num;
					num += 3076394326U;
					if (!flag)
					{
						num >>= 29;
						if ((1954043014U ^ num) != 0U)
						{
							break;
						}
					}
				}
				if (num > 1776697920U)
				{
					num = 1230074665U / num;
					num = 1480872794U + num;
					this.56D0249A = 4C982720;
					if ((97271272U ^ num) != 0U)
					{
						return;
					}
				}
			}
			throw new ArgumentException();
		}

		// Token: 0x040001EA RID: 490
		private object 56D0249A;
	}

	// Token: 0x02000062 RID: 98
	private sealed class 149C28AA : 0B005140.375D71A4
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x000D61E8 File Offset: 0x000D61E8
		public 149C28AA(Array 2FB142BA)
		{
			uint num = 7222792U;
			if (1104891726U > num)
			{
				num -= 1066667400U;
				base..ctor();
				num += 1390483971U;
				if (1047923284U < num)
				{
					return;
				}
			}
			do
			{
				num = 1324427008U + num;
				this.526854FC = 2FB142BA;
			}
			while ((54405259U & num) == 0U);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000D6244 File Offset: 0x000D6244
		public override Type 3A79FD5F()
		{
			return typeof(Array);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000D625C File Offset: 0x000D625C
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.149C28AA(this.526854FC);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000D627C File Offset: 0x000D627C
		public override object 611AD8EF()
		{
			return this.526854FC;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000D6290 File Offset: 0x000D6290
		public override void 53E5679E(object 7C367730)
		{
			this.526854FC = (Array)7C367730;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000D62AC File Offset: 0x000D62AC
		public override bool A29D7A45()
		{
			return this.526854FC != null;
		}

		// Token: 0x040001EB RID: 491
		private Array 526854FC;
	}

	// Token: 0x02000063 RID: 99
	private abstract class 66782487 : 0B005140.375D71A4
	{
		// Token: 0x060002E8 RID: 744 RVA: 0x000C2644 File Offset: 0x000C2644
		public override bool 591DABE5()
		{
			return true;
		}
	}

	// Token: 0x02000064 RID: 100
	private sealed class 18446303 : 0B005140.66782487
	{
		// Token: 0x060002EA RID: 746 RVA: 0x000D62E4 File Offset: 0x000D62E4
		public 18446303(0B005140.124B6895 41D11578)
		{
			uint num = 1004824903U;
			if ((num ^ 661867684U) != 0U)
			{
				num += 1107590279U;
				base..ctor();
			}
			do
			{
				this.37EA0217 = 41D11578;
			}
			while (1067008151U - num == 0U);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000D6324 File Offset: 0x000D6324
		public override Type 3A79FD5F()
		{
			return this.37EA0217.3A79FD5F();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000D6344 File Offset: 0x000D6344
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.18446303(this.37EA0217);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000D635C File Offset: 0x000D635C
		public override object 611AD8EF()
		{
			return this.37EA0217.611AD8EF();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000D6374 File Offset: 0x000D6374
		public override void 53E5679E(object 02BA1904)
		{
			uint num = 1242985425U;
			if (554003493U < num)
			{
				do
				{
					num = 134490314U + num;
					0B005140.124B6895 124B = this.37EA0217;
					num = (555494695U | num);
					124B.53E5679E(02BA1904);
				}
				while (num % 889589325U == 0U);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000D63BC File Offset: 0x000D63BC
		public override bool A29D7A45()
		{
			uint num = 517417510U;
			0B005140.124B6895 124B = this.37EA0217;
			object obj = null;
			num = 204548594U % num;
			return 124B > obj;
		}

		// Token: 0x040001EC RID: 492
		private 0B005140.124B6895 37EA0217;
	}

	// Token: 0x02000065 RID: 101
	private sealed class 0A626AC2 : 0B005140.66782487
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x000D63E0 File Offset: 0x000D63E0
		public 0A626AC2(0B005140.124B6895 14CF5050, 0B005140.124B6895 5F4262BC)
		{
			uint num;
			do
			{
				base..ctor();
				num = 645018904U;
				if (1794193788U == num)
				{
					break;
				}
				num *= 1905340284U;
				num += 1636587439U;
				this.7E4F71A4 = 14CF5050;
			}
			while (num <= 247153651U);
			num = 235489052U + num;
			this.2CA505D2 = 5F4262BC;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000D6438 File Offset: 0x000D6438
		public override Type 3A79FD5F()
		{
			return this.7E4F71A4.3A79FD5F();
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000D6458 File Offset: 0x000D6458
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 1359169983U;
			num = 2115374440U * num;
			0B005140.124B6895 14CF = this.7E4F71A4;
			num = (1305504730U | num);
			0B005140.124B6895 5F4262BC = this.2CA505D2;
			num += 591950882U;
			return new 0B005140.0A626AC2(14CF, 5F4262BC);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000D6494 File Offset: 0x000D6494
		public override object 611AD8EF()
		{
			return this.7E4F71A4.611AD8EF();
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000D64B4 File Offset: 0x000D64B4
		public override void 53E5679E(object 294F7CC3)
		{
			uint num;
			do
			{
				0B005140.124B6895 124B = this.7E4F71A4;
				num = 813371247U;
				124B.53E5679E(294F7CC3);
			}
			while (num << 30 == 0U);
			do
			{
				0B005140.124B6895 124B2 = this.2CA505D2;
				num = 862280936U % num;
				num = 1911640341U + num;
				object 4EE42AA = this.7E4F71A4.611AD8EF();
				num ^= 485695469U;
				124B2.53E5679E(4EE42AA);
			}
			while (num == 2091005854U);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000D6518 File Offset: 0x000D6518
		public override bool A29D7A45()
		{
			uint num = 812269388U;
			num *= 1756322438U;
			object obj = this.7E4F71A4;
			num = 238120633U << (int)num;
			return obj != null;
		}

		// Token: 0x040001ED RID: 493
		private 0B005140.124B6895 7E4F71A4;

		// Token: 0x040001EE RID: 494
		private 0B005140.124B6895 2CA505D2;
	}

	// Token: 0x02000066 RID: 102
	private sealed class 40315214 : 0B005140.66782487
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x000D654C File Offset: 0x000D654C
		public 40315214(FieldInfo 61580CF7, object 4547547D)
		{
			uint num = 634520696U;
			if (543057840U >> (int)num != 0U)
			{
				do
				{
					base..ctor();
					num = 491476414U - num;
					do
					{
						this.62EB2760 = 61580CF7;
						num = 2075872976U % num;
					}
					while (1031212953U + num == 0U);
					num |= 480196659U;
					this.35896EA5 = 4547547D;
				}
				while ((num & 1656584733U) == 0U);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000D65B8 File Offset: 0x000D65B8
		public override Type 3A79FD5F()
		{
			uint num = 1562058897U;
			FieldInfo fieldInfo = this.62EB2760;
			num = (1203385206U | num);
			return fieldInfo.FieldType;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000D65E0 File Offset: 0x000D65E0
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 96563894U;
			FieldInfo 61580CF = this.62EB2760;
			num = 2101807495U - num;
			return new 0B005140.40315214(61580CF, this.35896EA5);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000D660C File Offset: 0x000D660C
		public override object 611AD8EF()
		{
			uint num = 103744448U;
			FieldInfo fieldInfo = this.62EB2760;
			num = 1718643989U / num;
			return fieldInfo.GetValue(this.35896EA5);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000D6638 File Offset: 0x000D6638
		public override void 53E5679E(object 015F225B)
		{
			uint num;
			do
			{
				num = 482224149U;
				FieldInfo fieldInfo = this.62EB2760;
				num = (756172117U & num);
				object obj = this.35896EA5;
				num = (641282578U & num);
				num >>= 8;
				fieldInfo.SetValue(obj, 015F225B);
			}
			while (481123144U < num);
		}

		// Token: 0x040001EF RID: 495
		private FieldInfo 62EB2760;

		// Token: 0x040001F0 RID: 496
		private object 35896EA5;
	}

	// Token: 0x02000067 RID: 103
	private sealed class 75F76FC0 : 0B005140.66782487
	{
		// Token: 0x060002FB RID: 763 RVA: 0x000D6680 File Offset: 0x000D6680
		public 75F76FC0(Array 1C1C2F10, int 3E8745D7)
		{
			uint num;
			do
			{
				num = 1585911151U;
				base..ctor();
				num = (91910305U | num);
				num *= 779834357U;
				this.29016A08 = 1C1C2F10;
			}
			while (num << 4 == 0U);
			num *= 2588570U;
			this.378F7057 = 3E8745D7;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000D66CC File Offset: 0x000D66CC
		public override Type 3A79FD5F()
		{
			uint num = 477655420U;
			num *= 1008358377U;
			return this.29016A08.GetType().GetElementType();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000D66F8 File Offset: 0x000D66F8
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 1863084403U;
			num = (2028300693U ^ num);
			Array 1C1C2F = this.29016A08;
			num >>= 1;
			num -= 1348617811U;
			return new 0B005140.75F76FC0(1C1C2F, this.378F7057);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000D6734 File Offset: 0x000D6734
		public override object 611AD8EF()
		{
			uint num = 1977686078U;
			Array array = this.29016A08;
			num = 1925717262U >> (int)num;
			return array.GetValue(this.378F7057);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000D6768 File Offset: 0x000D6768
		public override void 53E5679E(object 22BC37C1)
		{
			uint num;
			do
			{
				Array array = this.29016A08;
				num = 1811905637U;
				num = (1672891822U ^ num);
				array.SetValue(22BC37C1, this.378F7057);
			}
			while (num % 89222461U == 0U);
		}

		// Token: 0x040001F1 RID: 497
		private Array 29016A08;

		// Token: 0x040001F2 RID: 498
		private int 378F7057;
	}

	// Token: 0x02000068 RID: 104
	private sealed class 28534615 : 0B005140.375D71A4
	{
		// Token: 0x06000300 RID: 768 RVA: 0x000D67A4 File Offset: 0x000D67A4
		public 28534615(MethodBase 159F7EC3)
		{
			uint num;
			do
			{
				num = 1261452863U;
				base..ctor();
			}
			while ((num & 1455569692U) == 0U);
			do
			{
				num += 1490969817U;
				this.3080145A = 159F7EC3;
			}
			while (1022912219U + num == 0U);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000D67E4 File Offset: 0x000D67E4
		public override Type 3A79FD5F()
		{
			return typeof(MethodBase);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000D6804 File Offset: 0x000D6804
		public override 0B005140.124B6895 1FB8DBBA()
		{
			uint num = 908292492U;
			num = 1870542051U % num;
			return new 0B005140.28534615(this.3080145A);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000D682C File Offset: 0x000D682C
		public override object 611AD8EF()
		{
			uint num = 1300527875U;
			num = 1188892639U >> (int)num;
			return this.3080145A;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000D6854 File Offset: 0x000D6854
		public override void 53E5679E(object 057C0E92)
		{
			uint num = 979982892U;
			num ^= 1688562005U;
			num = 1312172552U << (int)num;
			MethodBase methodBase = (MethodBase)057C0E92;
			num >>= 24;
			this.3080145A = methodBase;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000D6894 File Offset: 0x000D6894
		public override bool A29D7A45()
		{
			MethodBase methodBase = this.3080145A;
			uint num = 2105107906U;
			object obj = null;
			num *= 861472614U;
			return methodBase > obj;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000D68B8 File Offset: 0x000D68B8
		public override IntPtr 861F6A75()
		{
			uint num = 1913457039U;
			num /= 796349373U;
			RuntimeMethodHandle methodHandle = this.3080145A.MethodHandle;
			num <<= 8;
			RuntimeMethodHandle runtimeMethodHandle = methodHandle;
			num %= 1019882306U;
			return runtimeMethodHandle.GetFunctionPointer();
		}

		// Token: 0x040001F3 RID: 499
		private MethodBase 3080145A;
	}

	// Token: 0x02000069 RID: 105
	private sealed class 484E1899 : 0B005140.375D71A4
	{
		// Token: 0x06000307 RID: 775 RVA: 0x000D68F8 File Offset: 0x000D68F8
		public 484E1899(IntPtr 1D7237C0)
		{
			uint num = 548350695U;
			if (num - 1491420512U != 0U)
			{
				num >>= 1;
				base..ctor();
				num = 2116750515U >> (int)num;
				num = 758788556U / num;
				num = (1155943539U | num);
				this.2B595513 = 1D7237C0;
				if (num <= 428742813U)
				{
					return;
				}
			}
			num = (897394972U & num);
			num = 1023951164U >> (int)num;
			IntPtr <<EMPTY_NAME>> = this.2B595513;
			num &= 386557037U;
			0B005140.124B6895 124B = 0B005140.484E1899.03321128(<<EMPTY_NAME>>);
			num *= 1823437737U;
			this.53566CE8 = 124B;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000D698C File Offset: 0x000D698C
		private static 0B005140.124B6895 03321128(IntPtr 46487188)
		{
			uint num2;
			for (;;)
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 31262623U;
				if (size == num)
				{
					if (num2 != 1370368392U)
					{
						break;
					}
				}
				else if (num2 < 759722684U)
				{
					goto Block_2;
				}
			}
			return new 0B005140.07685083(46487188.ToInt32());
			Block_2:
			num2 <<= 27;
			long 46487189 = 46487188.ToInt64();
			num2 = 1594907706U % num2;
			return new 0B005140.13AF7E46(46487189);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000D69EC File Offset: 0x000D69EC
		public override Type 3A79FD5F()
		{
			return typeof(IntPtr);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000D6A0C File Offset: 0x000D6A0C
		public override TypeCode 08177016()
		{
			return this.53566CE8.08177016();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000D6A24 File Offset: 0x000D6A24
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.484E1899(this.2B595513);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000D6A44 File Offset: 0x000D6A44
		public override object 611AD8EF()
		{
			uint num = 1639869531U;
			IntPtr intPtr = this.2B595513;
			num += 1707869613U;
			return intPtr;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000D6A6C File Offset: 0x000D6A6C
		public override void 53E5679E(object 5DAC3848)
		{
			uint num = 1136668587U;
			if (981141317U - num == 0U)
			{
				goto IL_36;
			}
			IL_12:
			num /= 1785337690U;
			num = (1663505280U | num);
			IntPtr intPtr = (IntPtr)5DAC3848;
			num >>= 12;
			this.2B595513 = intPtr;
			IL_36:
			IntPtr <<EMPTY_NAME>> = this.2B595513;
			num = (1096180045U ^ num);
			this.53566CE8 = 0B005140.484E1899.03321128(<<EMPTY_NAME>>);
			if (num != 1492013115U)
			{
				return;
			}
			goto IL_12;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000D6AD4 File Offset: 0x000D6AD4
		public override bool A29D7A45()
		{
			return this.2B595513 != IntPtr.Zero;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000D6AF8 File Offset: 0x000D6AF8
		public override sbyte 3759DB5E()
		{
			return this.53566CE8.3759DB5E();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000D6B18 File Offset: 0x000D6B18
		public override short D846A716()
		{
			return this.53566CE8.D846A716();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000D6B30 File Offset: 0x000D6B30
		public override int DCFDB33F()
		{
			return this.53566CE8.DCFDB33F();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000D6B50 File Offset: 0x000D6B50
		public override long EB2B8B0E()
		{
			uint num = 1348234074U;
			num = 2087870867U - num;
			0B005140.124B6895 124B = this.53566CE8;
			num = 1908616726U % num;
			return 124B.EB2B8B0E();
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000D6B80 File Offset: 0x000D6B80
		public override byte 7CCA383B()
		{
			uint num = 1048990350U;
			num = 1804021980U * num;
			return this.53566CE8.7CCA383B();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000D6BA8 File Offset: 0x000D6BA8
		public override ushort E35975AC()
		{
			uint num = 244543141U;
			0B005140.124B6895 124B = this.53566CE8;
			num -= 1416843557U;
			return 124B.E35975AC();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000D6BD0 File Offset: 0x000D6BD0
		public override uint 49390C3B()
		{
			uint num = 708143017U;
			0B005140.124B6895 124B = this.53566CE8;
			num <<= 17;
			return 124B.49390C3B();
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000D6BF8 File Offset: 0x000D6BF8
		public override ulong 6DD020CC()
		{
			uint num = 1742546369U;
			num = 1031952650U << (int)num;
			0B005140.124B6895 124B = this.53566CE8;
			num = 1954510082U << (int)num;
			return 124B.6DD020CC();
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000D6C34 File Offset: 0x000D6C34
		public override float 84027CE6()
		{
			uint num = 362041628U;
			num ^= 1023366872U;
			0B005140.124B6895 124B = this.53566CE8;
			num |= 922158167U;
			return 124B.84027CE6();
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000D6C64 File Offset: 0x000D6C64
		public override double BD97D382()
		{
			return this.53566CE8.BD97D382();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000D6C84 File Offset: 0x000D6C84
		public override IntPtr 861F6A75()
		{
			return this.2B595513;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000D6C98 File Offset: 0x000D6C98
		public override UIntPtr 1A796C90()
		{
			uint num = 253917107U;
			0B005140.124B6895 124B = this.53566CE8;
			num &= 1793883669U;
			return 124B.1A796C90();
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000D6CC0 File Offset: 0x000D6CC0
		public override object FBC53937(Type 514A39F2, bool 1A604997)
		{
			uint num = 741304540U;
			0B005140.124B6895 124B = this.53566CE8;
			num &= 1819238278U;
			return 124B.FBC53937(514A39F2, 1A604997);
		}

		// Token: 0x040001F4 RID: 500
		private IntPtr 2B595513;

		// Token: 0x040001F5 RID: 501
		private 0B005140.124B6895 53566CE8;
	}

	// Token: 0x0200006A RID: 106
	private sealed class 0F111823 : 0B005140.375D71A4
	{
		// Token: 0x0600031C RID: 796 RVA: 0x000D6CE8 File Offset: 0x000D6CE8
		public 0F111823(UIntPtr 65B46173)
		{
			uint num;
			do
			{
				num = 188055169U;
				base..ctor();
				num = (1379694727U ^ num);
				num = 794367246U % num;
				num *= 1987788876U;
				this.10AF3392 = 65B46173;
				num = (1523258899U & num);
				UIntPtr 24671DA = this.10AF3392;
				num %= 1870093809U;
				this.67F30BE5 = 0B005140.0F111823.39BA3C42(24671DA);
			}
			while (1803233792U <= num);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000D6D4C File Offset: 0x000D6D4C
		private static 0B005140.124B6895 39BA3C42(UIntPtr 24671DA6)
		{
			uint num = 584473925U;
			int size = IntPtr.Size;
			num = (1220222003U | num);
			uint num2 = num + 2499846797U;
			num &= 1760823216U;
			if (size == num2)
			{
				num ^= 1028922320U;
			}
			else
			{
				num = 1174237118U / num;
				if (2124030562U != num)
				{
					long <<EMPTY_NAME>> = (long)24671DA6.ToUInt64();
					num >>= 12;
					return new 0B005140.13AF7E46(<<EMPTY_NAME>>);
				}
			}
			num = 1242131590U >> (int)num;
			int 0D6B27B = (int)24671DA6.ToUInt32();
			num = 87295980U >> (int)num;
			return new 0B005140.07685083(0D6B27B);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000D6DD8 File Offset: 0x000D6DD8
		public override Type 3A79FD5F()
		{
			uint num = 2064139734U;
			RuntimeTypeHandle handle = typeof(UIntPtr).TypeHandle;
			num ^= 1257260427U;
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000D6E00 File Offset: 0x000D6E00
		public override TypeCode 08177016()
		{
			uint num = 863976768U;
			0B005140.124B6895 124B = this.67F30BE5;
			num = 949032890U / num;
			return 124B.08177016();
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000D6E28 File Offset: 0x000D6E28
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.0F111823(this.10AF3392);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000D6E48 File Offset: 0x000D6E48
		public override object 611AD8EF()
		{
			return this.10AF3392;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000D6E68 File Offset: 0x000D6E68
		public override void 53E5679E(object 7D840545)
		{
			uint num;
			do
			{
				num = 1800287109U;
				UIntPtr uintPtr = (UIntPtr)7D840545;
				num = 1521248390U / num;
				this.10AF3392 = uintPtr;
				num &= 1418473145U;
			}
			while (371075676U < num);
			num = (609313898U | num);
			UIntPtr 24671DA = this.10AF3392;
			num = 2147050224U << (int)num;
			this.67F30BE5 = 0B005140.0F111823.39BA3C42(24671DA);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000D6ECC File Offset: 0x000D6ECC
		public override bool A29D7A45()
		{
			uint num = 1756497344U;
			UIntPtr value = this.10AF3392;
			num *= 275317903U;
			UIntPtr zero = UIntPtr.Zero;
			num = 1397188985U / num;
			return value != zero;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000D6F00 File Offset: 0x000D6F00
		public override sbyte 3759DB5E()
		{
			return this.67F30BE5.3759DB5E();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000D6F20 File Offset: 0x000D6F20
		public override short D846A716()
		{
			return this.67F30BE5.D846A716();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000D6F40 File Offset: 0x000D6F40
		public override int DCFDB33F()
		{
			return this.67F30BE5.DCFDB33F();
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000D6F60 File Offset: 0x000D6F60
		public override long EB2B8B0E()
		{
			uint num = 2007311883U;
			0B005140.124B6895 124B = this.67F30BE5;
			num %= 1765736967U;
			return 124B.EB2B8B0E();
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000D6F88 File Offset: 0x000D6F88
		public override byte 7CCA383B()
		{
			return this.67F30BE5.7CCA383B();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000D6FA8 File Offset: 0x000D6FA8
		public override ushort E35975AC()
		{
			return this.67F30BE5.E35975AC();
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000D6FC8 File Offset: 0x000D6FC8
		public override uint 49390C3B()
		{
			uint num = 2008966699U;
			num = 1554653695U + num;
			0B005140.124B6895 124B = this.67F30BE5;
			num %= 1542208858U;
			return 124B.49390C3B();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000D6FF8 File Offset: 0x000D6FF8
		public override ulong 6DD020CC()
		{
			uint num = 129832481U;
			0B005140.124B6895 124B = this.67F30BE5;
			num = 78410484U + num;
			return 124B.6DD020CC();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000D7020 File Offset: 0x000D7020
		public override float 84027CE6()
		{
			return this.67F30BE5.84027CE6();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000D7040 File Offset: 0x000D7040
		public override double BD97D382()
		{
			uint num = 1190815315U;
			num = 130117890U * num;
			return this.67F30BE5.BD97D382();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000D7068 File Offset: 0x000D7068
		public override IntPtr 861F6A75()
		{
			uint num = 1714830774U;
			0B005140.124B6895 124B = this.67F30BE5;
			num = 1057759856U - num;
			return 124B.861F6A75();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000D7090 File Offset: 0x000D7090
		public override UIntPtr 1A796C90()
		{
			uint num = 1936461310U;
			num = 1961493055U % num;
			return this.10AF3392;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000D70B4 File Offset: 0x000D70B4
		public override object FBC53937(Type 1965368D, bool 7F707CE1)
		{
			uint num = 513433706U;
			0B005140.124B6895 124B = this.67F30BE5;
			num = (1117942319U ^ num);
			num -= 1342572203U;
			return 124B.FBC53937(1965368D, 7F707CE1);
		}

		// Token: 0x040001F6 RID: 502
		private UIntPtr 10AF3392;

		// Token: 0x040001F7 RID: 503
		private 0B005140.124B6895 67F30BE5;
	}

	// Token: 0x0200006B RID: 107
	private sealed class 543A386B : 0B005140.375D71A4
	{
		// Token: 0x06000331 RID: 817 RVA: 0x000D70E4 File Offset: 0x000D70E4
		public 543A386B(Enum 21340C1D)
		{
			uint num = 181678046U;
			do
			{
				num -= 944726873U;
				base..ctor();
			}
			while (num == 47343379U);
			if (21340C1D == null)
			{
				throw new ArgumentException();
			}
			num -= 1178797672U;
			num ^= 508970377U;
			this.54B13BE4 = 21340C1D;
			Enum 4C856E = this.54B13BE4;
			num = 1708984772U << (int)num;
			this.12947F58 = 0B005140.543A386B.073A4FDD(4C856E);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000D7154 File Offset: 0x000D7154
		private static 0B005140.124B6895 073A4FDD(Enum 4C856E13)
		{
			TypeCode typeCode = 4C856E13.GetTypeCode();
			uint num = 460943052U;
			TypeCode typeCode2 = typeCode;
			object obj = typeCode2;
			num /= 950367868U;
			object obj2 = num + 5U;
			num = (1258441329U | num);
			object obj3 = obj - obj2;
			num >>= 14;
			switch (obj3)
			{
			case 0:
			case 2:
			case 4:
				if (1074087267 << (int)num != 0)
				{
					int 0D6B27B = Convert.ToInt32(4C856E13);
					num >>= 8;
					return new 0B005140.07685083(0D6B27B);
				}
				goto IL_58;
			case 1:
			case 3:
			case 5:
				goto IL_58;
			case 6:
				if (num != 286552189U)
				{
					return new 0B005140.13AF7E46(Convert.ToInt64(4C856E13));
				}
				break;
			case 7:
				num = 664632156U + num;
				if (1600812265U >= num)
				{
					num = 584537769U % num;
					return new 0B005140.13AF7E46((long)Convert.ToUInt64(4C856E13));
				}
				goto IL_58;
			}
			num = 1952910125U / num;
			throw new InvalidOperationException();
			IL_58:
			int 0D6B27B2 = (int)Convert.ToUInt32(4C856E13);
			num -= 1577339305U;
			return new 0B005140.07685083(0D6B27B2);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000D7240 File Offset: 0x000D7240
		public override 0B005140.124B6895 3D08BB82()
		{
			return this.12947F58.3D08BB82();
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000D7258 File Offset: 0x000D7258
		public override Type 3A79FD5F()
		{
			uint num = 182406424U;
			object obj = this.54B13BE4;
			num = 843925368U >> (int)num;
			return obj.GetType();
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000D7284 File Offset: 0x000D7284
		public override TypeCode 08177016()
		{
			uint num = 1491289107U;
			0B005140.124B6895 124B = this.12947F58;
			num = (1302811846U | num);
			return 124B.08177016();
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000D72AC File Offset: 0x000D72AC
		public override 0B005140.124B6895 1FB8DBBA()
		{
			return new 0B005140.543A386B(this.54B13BE4);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000D72CC File Offset: 0x000D72CC
		public override object 611AD8EF()
		{
			uint num = 1946905795U;
			num += 1276716855U;
			return this.54B13BE4;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000D72F0 File Offset: 0x000D72F0
		public override void 53E5679E(object 6E895570)
		{
			if (6E895570 == null)
			{
				throw new ArgumentException();
			}
			uint num = 1734482440U;
			this.54B13BE4 = (Enum)6E895570;
			Enum 4C856E = this.54B13BE4;
			num = (1552775060U | num);
			this.12947F58 = 0B005140.543A386B.073A4FDD(4C856E);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000D7334 File Offset: 0x000D7334
		public override byte 7CCA383B()
		{
			uint num = 1538083541U;
			0B005140.124B6895 124B = this.12947F58;
			num -= 1408917705U;
			return 124B.7CCA383B();
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000D735C File Offset: 0x000D735C
		public override sbyte 3759DB5E()
		{
			return this.12947F58.3759DB5E();
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000D737C File Offset: 0x000D737C
		public override short D846A716()
		{
			uint num = 649089437U;
			num *= 1957312332U;
			return this.12947F58.D846A716();
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000D73A4 File Offset: 0x000D73A4
		public override ushort E35975AC()
		{
			return this.12947F58.E35975AC();
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000D73BC File Offset: 0x000D73BC
		public override int DCFDB33F()
		{
			return this.12947F58.DCFDB33F();
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000D73DC File Offset: 0x000D73DC
		public override uint 49390C3B()
		{
			return this.12947F58.49390C3B();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000D73FC File Offset: 0x000D73FC
		public override long EB2B8B0E()
		{
			return this.12947F58.EB2B8B0E();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000D741C File Offset: 0x000D741C
		public override ulong 6DD020CC()
		{
			uint num = 2140543355U;
			num = 1349782328U * num;
			return this.12947F58.6DD020CC();
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000D7444 File Offset: 0x000D7444
		public override float 84027CE6()
		{
			uint num = 1117914227U;
			num >>= 22;
			0B005140.124B6895 124B = this.12947F58;
			num = 148724317U >> (int)num;
			return 124B.84027CE6();
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000D7478 File Offset: 0x000D7478
		public override double BD97D382()
		{
			uint num = 1222534995U;
			0B005140.124B6895 124B = this.12947F58;
			num |= 851774514U;
			return 124B.BD97D382();
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000D74A0 File Offset: 0x000D74A0
		public override IntPtr 861F6A75()
		{
			uint num2;
			do
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 611871800U;
				if (size == num)
				{
					goto IL_37;
				}
				num2 ^= 1595242564U;
			}
			while (2084076844U <= num2);
			num2 = (1688865255U & num2);
			long value = this.EB2B8B0E();
			goto IL_4E;
			IL_37:
			long num3 = (long)this.DCFDB33F();
			num2 %= 1977627278U;
			value = num3;
			num2 ^= 1146121308U;
			IL_4E:
			return new IntPtr(value);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000D7500 File Offset: 0x000D7500
		public override UIntPtr 1A796C90()
		{
			uint num = 821514276U;
			ulong value;
			while (IntPtr.Size == (int)(num ^ 821514272U))
			{
				num += 754939893U;
				if (num >> 21 != 0U)
				{
					num = (1613578978U & num);
					ulong num2 = (ulong)this.49390C3B();
					num = 2145871447U * num;
					value = num2;
					num += 858099748U;
					IL_55:
					num *= 1158764139U;
					return new UIntPtr(value);
				}
			}
			value = this.6DD020CC();
			goto IL_55;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000D7570 File Offset: 0x000D7570
		public override object FBC53937(Type 60CF53A9, bool 7CAC7BA1)
		{
			uint num = 661994401U;
			0B005140.124B6895 124B = this.12947F58;
			num = 1611138924U % num;
			return 124B.FBC53937(60CF53A9, 7CAC7BA1);
		}

		// Token: 0x040001F8 RID: 504
		private Enum 54B13BE4;

		// Token: 0x040001F9 RID: 505
		private 0B005140.124B6895 12947F58;
	}

	// Token: 0x0200006C RID: 108
	private sealed class 658470CB : 0B005140.66782487
	{
		// Token: 0x06000346 RID: 838 RVA: 0x000D7598 File Offset: 0x000D7598
		public 658470CB(IntPtr 0C055FD9, Type 1DC679F1)
		{
			uint num;
			do
			{
				num = 1914073919U;
				base..ctor();
				num = 1961390742U + num;
			}
			while (num / 1465665760U == 0U);
			this.54BE2D8F = 0C055FD9;
			num <<= 19;
			this.6EDD4265 = 1DC679F1;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000D75DC File Offset: 0x000D75DC
		public override Type 3A79FD5F()
		{
			uint num = 185760859U;
			RuntimeTypeHandle handle = typeof(Pointer).TypeHandle;
			num |= 43061175U;
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000C268C File Offset: 0x000C268C
		public override TypeCode 08177016()
		{
			return TypeCode.Empty;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000D7604 File Offset: 0x000D7604
		public override 0B005140.124B6895 1FB8DBBA()
		{
			IntPtr 0C055FD = this.54BE2D8F;
			uint num = 1334323825U;
			Type 1DC679F = this.6EDD4265;
			num = (2060583939U ^ num);
			return new 0B005140.658470CB(0C055FD, 1DC679F);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000D7630 File Offset: 0x000D7630
		public override object 611AD8EF()
		{
			uint num = 1012495546U;
			if (559229830U < num)
			{
				for (;;)
				{
					num ^= 450500078U;
					if (!this.6EDD4265.IsValueType)
					{
						break;
					}
					if ((429747678U ^ num) != 0U)
					{
						goto IL_35;
					}
				}
				throw new InvalidOperationException();
			}
			IL_35:
			num >>= 10;
			IntPtr ptr = this.54BE2D8F;
			Type structureType = this.6EDD4265;
			num = 1059944443U >> (int)num;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000D76A0 File Offset: 0x000D76A0
		public override void 53E5679E(object 1D10607E)
		{
			IL_00:
			while (1D10607E != null)
			{
				uint num;
				for (;;)
				{
					num = 2083670628U;
					Type type = this.6EDD4265;
					num = (318440748U & num);
					if (type.IsValueType)
					{
						goto Block_0;
					}
					num %= 234305908U;
					num = 1102075343U / num;
					Type type2 = 1D10607E.GetType();
					num += 1383219808U;
					TypeCode typeCode = Type.GetTypeCode(type2);
					TypeCode typeCode2 = typeCode;
					uint num2 = num - 1383219833U;
					num = 233388317U - num;
					switch (typeCode2 - num2)
					{
					case 0:
						goto IL_130;
					case 1:
						goto IL_C4;
					case 2:
						goto IL_108;
					case 3:
						goto IL_15D;
					case 4:
						goto IL_183;
					case 5:
						goto IL_1B1;
					case 6:
					{
						num >>= 15;
						if ((1510812853U ^ num) == 0U)
						{
							goto IL_00;
						}
						IntPtr ptr = this.54BE2D8F;
						num >>= 19;
						int val = (int)Convert.ToUInt32(1D10607E);
						num = 191969909U * num;
						Marshal.WriteInt32(ptr, val);
						if (num * 1913536503U == 0U)
						{
							return;
						}
						continue;
					}
					case 7:
						goto IL_237;
					case 8:
						goto IL_25F;
					case 9:
						goto IL_29F;
					case 10:
						goto IL_2DA;
					}
					break;
				}
				num ^= 1519063310U;
				if (num > 138100315U)
				{
					throw new ArgumentException();
				}
				continue;
				Block_0:
				if (945883117U != num)
				{
					goto IL_35;
				}
				break;
				IL_C4:
				num += 680200414U;
				if (2070371688U <= num)
				{
					num = 847395728U >> (int)num;
					IntPtr ptr2 = this.54BE2D8F;
					num -= 2146640872U;
					num >>= 6;
					Marshal.WriteByte(ptr2, (byte)Convert.ToSByte(1D10607E));
					return;
				}
				continue;
				IL_130:
				IntPtr ptr3 = this.54BE2D8F;
				num = 2063351285U * num;
				num = (373107409U | num);
				Marshal.WriteInt16(ptr3, Convert.ToChar(1D10607E));
				if (num != 1458463878U)
				{
					return;
				}
				continue;
				IL_183:
				num -= 1364553941U;
				IntPtr ptr4 = this.54BE2D8F;
				num <<= 25;
				Marshal.WriteInt16(ptr4, (short)Convert.ToUInt16(1D10607E));
				if (301420973U < num)
				{
					return;
				}
				continue;
				IL_1B1:
				num = (1852062254U ^ num);
				num ^= 796681412U;
				IntPtr ptr5 = this.54BE2D8F;
				num = 65302252U / num;
				int val2 = Convert.ToInt32(1D10607E);
				num >>= 6;
				Marshal.WriteInt32(ptr5, val2);
				if (1115954260U >> (int)num != 0U)
				{
					return;
				}
				continue;
				IL_25F:
				if (num <= 2008693532U)
				{
					goto IL_35;
				}
				num = 410978183U * num;
				IntPtr ptr6 = this.54BE2D8F;
				num += 1270505U;
				num += 806446735U;
				Marshal.WriteInt64(ptr6, (long)Convert.ToUInt64(1D10607E));
				if (num >= 843061201U)
				{
					return;
				}
				continue;
				IL_2DA:
				num *= 502943953U;
				if ((num ^ 511539002U) != 0U)
				{
					num += 1128204345U;
					IntPtr ptr7 = this.54BE2D8F;
					byte[] bytes = BitConverter.GetBytes(Convert.ToDouble(1D10607E));
					int startIndex = (int)(num + 2337251111U);
					num = 1824731738U << (int)num;
					long val3 = BitConverter.ToInt64(bytes, startIndex);
					num = 979447447U + num;
					Marshal.WriteInt64(ptr7, val3);
					return;
				}
				continue;
				IL_35:
				num >>= 19;
				IntPtr ptr8 = this.54BE2D8F;
				num = 637993302U % num;
				Marshal.StructureToPtr(1D10607E, ptr8, num - 156U != 0U);
				return;
				IL_108:
				num <<= 12;
				num = 1510866956U >> (int)num;
				Marshal.WriteByte(this.54BE2D8F, Convert.ToByte(1D10607E));
				return;
				IL_15D:
				if ((num & 1413426056U) != 0U)
				{
					num &= 957249991U;
					Marshal.WriteInt16(this.54BE2D8F, Convert.ToInt16(1D10607E));
					return;
				}
				break;
				IL_237:
				num = 1794378313U / num;
				IntPtr ptr9 = this.54BE2D8F;
				num = 1256330354U << (int)num;
				Marshal.WriteInt64(ptr9, Convert.ToInt64(1D10607E));
				return;
				IL_29F:
				num = 2143048591U % num;
				IntPtr ptr10 = this.54BE2D8F;
				float value = Convert.ToSingle(1D10607E);
				num %= 745217084U;
				byte[] bytes2 = BitConverter.GetBytes(value);
				int startIndex2 = (int)(num ^ 652614423U);
				num = (2001084647U ^ num);
				Marshal.WriteInt32(ptr10, BitConverter.ToInt32(bytes2, startIndex2));
				return;
			}
			throw new ArgumentException();
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000D79F4 File Offset: 0x000D79F4
		public override sbyte 3759DB5E()
		{
			uint num = 393162911U;
			IntPtr ptr = this.54BE2D8F;
			num = 1332633979U * num;
			sbyte b = (sbyte)Marshal.ReadByte(ptr);
			num ^= 62020598U;
			return b;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000D7A24 File Offset: 0x000D7A24
		public override short D846A716()
		{
			return Marshal.ReadInt16(this.54BE2D8F);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000D7A3C File Offset: 0x000D7A3C
		public override int DCFDB33F()
		{
			return Marshal.ReadInt32(this.54BE2D8F);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000D7A54 File Offset: 0x000D7A54
		public override long EB2B8B0E()
		{
			return Marshal.ReadInt64(this.54BE2D8F);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000D7A74 File Offset: 0x000D7A74
		public override char C299D4B1()
		{
			uint num = 1427472369U;
			char c = (char)Marshal.ReadInt16(this.54BE2D8F);
			num = (1162181405U ^ num);
			return c;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000D7A9C File Offset: 0x000D7A9C
		public override byte 7CCA383B()
		{
			return Marshal.ReadByte(this.54BE2D8F);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000D7A74 File Offset: 0x000D7A74
		public override ushort E35975AC()
		{
			uint num = 1427472369U;
			ushort num2 = (ushort)Marshal.ReadInt16(this.54BE2D8F);
			num = (1162181405U ^ num);
			return num2;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000D7A3C File Offset: 0x000D7A3C
		public override uint 49390C3B()
		{
			return (uint)Marshal.ReadInt32(this.54BE2D8F);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000D7A54 File Offset: 0x000D7A54
		public override ulong 6DD020CC()
		{
			return (ulong)Marshal.ReadInt64(this.54BE2D8F);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000D7ABC File Offset: 0x000D7ABC
		public override float 84027CE6()
		{
			uint num = 1691184831U;
			IntPtr ptr = this.54BE2D8F;
			num = (1088820695U | num);
			byte[] bytes = BitConverter.GetBytes(Marshal.ReadInt32(ptr));
			num &= 1901545138U;
			int startIndex = (int)(num ^ 1615283890U);
			num = 1980703180U / num;
			return BitConverter.ToSingle(bytes, startIndex);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000D7B04 File Offset: 0x000D7B04
		public override double BD97D382()
		{
			uint num = 551165941U;
			num ^= 689598217U;
			byte[] bytes = BitConverter.GetBytes(Marshal.ReadInt64(this.54BE2D8F));
			num = (1765699210U | num);
			return BitConverter.ToDouble(bytes, (int)(num ^ 1778286334U));
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000D7B44 File Offset: 0x000D7B44
		public override IntPtr 861F6A75()
		{
			uint num;
			long value;
			while (IntPtr.Size != 4)
			{
				num = 2070050732U;
				if (1892636925U != num)
				{
					IntPtr ptr = this.54BE2D8F;
					num |= 1379407993U;
					value = Marshal.ReadInt64(ptr);
					IL_56:
					num = 1268329484U * num;
					return new IntPtr(value);
				}
			}
			num = 1099705613U;
			long num2 = (long)Marshal.ReadInt32(this.54BE2D8F);
			num |= 712336220U;
			value = num2;
			num += 259854496U;
			goto IL_56;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000D7BB4 File Offset: 0x000D7BB4
		public override UIntPtr 1A796C90()
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 1256465648U;
			ulong value;
			if (size != num)
			{
				IntPtr ptr = this.54BE2D8F;
				num2 = (1790329402U ^ num2);
				value = (ulong)Marshal.ReadInt64(ptr);
			}
			else
			{
				num2 = 718492762U - num2;
				num2 <<= 28;
				IntPtr ptr2 = this.54BE2D8F;
				num2 = 780428882U % num2;
				value = (ulong)Marshal.ReadInt32(ptr2);
				num2 ^= 248905880U;
			}
			return new UIntPtr(value);
		}

		// Token: 0x040001FA RID: 506
		private IntPtr 54BE2D8F;

		// Token: 0x040001FB RID: 507
		private Type 6EDD4265;
	}

	// Token: 0x0200006D RID: 109
	private sealed class 516357D5
	{
		// Token: 0x06000359 RID: 857 RVA: 0x000D7C1C File Offset: 0x000D7C1C
		public 516357D5(byte 0E0076B3, int 4F7A1C34, int 41C73AF8)
		{
			uint num = 487083295U;
			for (;;)
			{
				base..ctor();
				if (num == 2116171411U)
				{
					goto IL_48;
				}
				IL_17:
				num = (851070366U & num);
				num = 1469991712U >> (int)num;
				this.2A134369 = 0E0076B3;
				num -= 999128435U;
				if ((num ^ 876769258U) == 0U)
				{
					continue;
				}
				IL_48:
				num = 566059609U >> (int)num;
				this.1F643FAD = 4F7A1C34;
				if (num != 1701146965U)
				{
					break;
				}
				goto IL_17;
			}
			this.7D987532 = 41C73AF8;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000D7C98 File Offset: 0x000D7C98
		public byte 79A84666()
		{
			return this.2A134369;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000D7CB4 File Offset: 0x000D7CB4
		public int 147B6C82()
		{
			return this.1F643FAD;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000D7CC8 File Offset: 0x000D7CC8
		public int 400A0B48()
		{
			return this.7D987532;
		}

		// Token: 0x040001FC RID: 508
		private byte 2A134369;

		// Token: 0x040001FD RID: 509
		private int 1F643FAD;

		// Token: 0x040001FE RID: 510
		private int 7D987532;
	}

	// Token: 0x0200006E RID: 110
	private sealed class 11482F88
	{
		// Token: 0x0600035D RID: 861 RVA: 0x000D7CE4 File Offset: 0x000D7CE4
		public 11482F88(int 554A53A1, int 11C37599)
		{
			uint num = 927092590U;
			num = (877988527U ^ num);
			List<0B005140.516357D5> list = new List<0B005140.516357D5>();
			num %= 1914205312U;
			this.6EF14426 = list;
			num = 883913053U % num;
			do
			{
				base..ctor();
				num ^= 1389694038U;
				if (543365088U * num != 0U)
				{
					do
					{
						num /= 415248280U;
						this.67895F2B = 554A53A1;
					}
					while (700147191U < num);
				}
				num = 1120803917U >> (int)num;
				this.7F1279A8 = 11C37599;
			}
			while (num >= 1018527418U);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000D7D70 File Offset: 0x000D7D70
		public int 4BB56715()
		{
			return this.67895F2B;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000D7D84 File Offset: 0x000D7D84
		public int 072C4A6E()
		{
			return this.7F1279A8;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000D7DA0 File Offset: 0x000D7DA0
		public int 6787274E(0B005140.11482F88 52533AA0)
		{
			uint num;
			int num3;
			int num4;
			for (;;)
			{
				num = 1924954976U;
				if (52533AA0 == null)
				{
					break;
				}
				num &= 1198144460U;
				if (num >= 913792191U)
				{
					num = (1408856094U ^ num);
					int num2 = this.67895F2B.CompareTo(52533AA0.4BB56715());
					num = 1157460417U % num;
					num3 = num2;
					if (598631792U >= num)
					{
						if (num3 != 0)
						{
							return num3;
						}
						if (num << 11 == 0U)
						{
							break;
						}
						num = 155726160U + num;
						num4 = 52533AA0.072C4A6E();
						num = 1403279877U + num;
						if (num > 957881924U)
						{
							goto Block_4;
						}
					}
				}
			}
			return (int)(num ^ 1924954977U);
			Block_4:
			num = (1362982857U ^ num);
			num = (1464940541U | num);
			int num5 = num4.CompareTo(this.7F1279A8);
			num = 1596597365U / num;
			num3 = num5;
			num += 260673447U;
			return num3;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000D7E64 File Offset: 0x000D7E64
		public void 7FB3588B(byte 00B6022F, int 50844378, int 0E3A4AC9)
		{
			uint num = 117858667U;
			if (1497453200U != num)
			{
				do
				{
					num *= 56627872U;
					List<0B005140.516357D5> list = this.6EF14426;
					0B005140.516357D5 item = new 0B005140.516357D5(00B6022F, 50844378, 0E3A4AC9);
					num = (190725290U & num);
					list.Add(item);
				}
				while (1326080548U <= num);
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000D7EB0 File Offset: 0x000D7EB0
		public List<0B005140.516357D5> 6C5F487C()
		{
			return this.6EF14426;
		}

		// Token: 0x040001FF RID: 511
		private int 67895F2B;

		// Token: 0x04000200 RID: 512
		private int 7F1279A8;

		// Token: 0x04000201 RID: 513
		private List<0B005140.516357D5> 6EF14426;
	}

	// Token: 0x0200006F RID: 111
	// (Invoke) Token: 0x06000364 RID: 868
	internal delegate void 38CC03B8();
}

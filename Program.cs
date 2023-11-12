using AVL_Tree;
Console.OutputEncoding = System.Text.Encoding.UTF8;
CSinhVien sv1 = new CSinhVien("1", "1A1", "Chau Nguyen Truong An", "180 Cao Lo", DateTime.Today, true);
CSinhVien sv2 = new CSinhVien("2", "1A2", "Huynh To Tran", "180 Cao Lo", DateTime.Today, false);
CSinhVien sv3 = new CSinhVien("3", "1A3", "Nguyen Van Linh", "32 Hong Bang", DateTime.Today, true);
CSinhVien sv4 = new CSinhVien("4", "1A4", "Pham The Hien", "54 Pham Hung", DateTime.Today, true);
CSinhVien sv5 = new CSinhVien("5", "1A5", "Le Thi Hong Gam", "32 Le Lai", DateTime.Today, false);
CSinhVien sv6 = new CSinhVien("6", "1A5", "Le Thi Hong Gam", "32 Le Lai", DateTime.Today, false);
CSinhVien sv7 = new CSinhVien("6", "1A5", "Le Thi Hong Gam", "32 Le Lai", DateTime.Today, false);

AVL_DanhSach temp = new AVL_DanhSach();
temp.Add(sv1);
temp.Add(sv2);
temp.Add(sv3);
temp.Add(sv4);

temp.Show();
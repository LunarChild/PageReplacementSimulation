namespace PageReplace
{
    public partial class Form1 : Form
    {
        List<int> pages = new List<int>();
        int[] blockArray;//����� FIFOʹ��
        OPTEntity[] optArray;
        LRUEntity[] lruArray;
        LFUEntity[] lfuArray;

        int fifoCount, optCount, lruCount, lfuCount;

        bool isCustomerBorder = false;

        Color customerGreen = Color.FromArgb(0, 176, 80);
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// �������
        /// </summary>
        private void DataClear()
        {

        }
        #region WinForm�������

        private void SetLabelCount(Label label, int count)
        {
            label.Invoke(() =>
            {
                label.Text = count.ToString();
            });
        }

        private void LockBtn(BtnType type)
        {
            if (type == BtnType.FIFO)
            {
                btnFIFO.Invoke(() =>
                {
                    if (btnFIFO.Enabled)
                    {
                        btnFIFO.Enabled = false;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (btnAll.Enabled)
                    {
                        btnAll.Enabled = false;
                    }
                });
            }
            else if (type == BtnType.OPT)
            {
                btnOPT.Invoke(() =>
                {
                    if (btnOPT.Enabled)
                    {
                        btnOPT.Enabled = false;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (btnAll.Enabled)
                    {
                        btnAll.Enabled = false;
                    }
                });
            }
            else if (type == BtnType.LRU)
            {
                btnLRU.Invoke(() =>
                {
                    if (btnLRU.Enabled)
                    {
                        btnLRU.Enabled = false;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (btnAll.Enabled)
                    {
                        btnAll.Enabled = false;
                    }
                });
            }
            else if (type == BtnType.LFU)
            {
                btnLFU.Invoke(() =>
                {
                    if (btnLFU.Enabled)
                    {
                        btnLFU.Enabled = false;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (btnAll.Enabled)
                    {
                        btnAll.Enabled = false;
                    }
                });
            }
            else
            {
                btnFIFO.Invoke(() =>
                {
                    if (btnFIFO.Enabled)
                    {
                        btnFIFO.Enabled = false;
                    }
                });
                btnOPT.Invoke(() =>
                {
                    if (btnOPT.Enabled)
                    {
                        btnOPT.Enabled = false;
                    }
                });
                btnLRU.Invoke(() =>
                {
                    if (btnLRU.Enabled)
                    {
                        btnLRU.Enabled = false;
                    }
                });
                btnLFU.Invoke(() =>
                {
                    if (btnLFU.Enabled)
                    {
                        btnLFU.Enabled = false;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (btnAll.Enabled)
                    {
                        btnAll.Enabled = false;
                    }
                });
            }
        }
        private void UnLockBtn(BtnType type)
        {
            if (type == BtnType.FIFO)
            {
                btnFIFO.Invoke(() =>
                {
                    if (!btnFIFO.Enabled)
                    {
                        btnFIFO.Enabled = true;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (!btnAll.Enabled)
                    {
                        btnAll.Enabled = true;
                    }
                });
            }
            else if (type == BtnType.OPT)
            {
                btnOPT.Invoke(() =>
                {
                    if (!btnOPT.Enabled)
                    {
                        btnOPT.Enabled = true;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (!btnAll.Enabled)
                    {
                        btnAll.Enabled = true;
                    }
                });
            }
            else if (type == BtnType.LRU)
            {
                btnLRU.Invoke(() =>
                {
                    if (!btnLRU.Enabled)
                    {
                        btnLRU.Enabled = true;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (!btnAll.Enabled)
                    {
                        btnAll.Enabled = true;
                    }
                });
            }
            else if (type == BtnType.LFU)
            {
                btnLFU.Invoke(() =>
                {
                    if (!btnLFU.Enabled)
                    {
                        btnLFU.Enabled = true;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (!btnAll.Enabled)
                    {
                        btnAll.Enabled = true;
                    }
                });
            }
            else
            {
                btnFIFO.Invoke(() =>
                {
                    if (!btnFIFO.Enabled)
                    {
                        btnFIFO.Enabled = true;
                    }
                });
                btnOPT.Invoke(() =>
                {
                    if (!btnOPT.Enabled)
                    {
                        btnOPT.Enabled = true;
                    }
                });
                btnLRU.Invoke(() =>
                {
                    if (!btnLRU.Enabled)
                    {
                        btnLRU.Enabled = true;
                    }
                });
                btnLFU.Invoke(() =>
                {
                    if (!btnLFU.Enabled)
                    {
                        btnLFU.Enabled = false;
                    }
                });
                btnAll.Invoke(() =>
                {
                    if (!btnAll.Enabled)
                    {
                        btnAll.Enabled = true;
                    }
                });
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            pages.Clear();
            dgvFIFO.Columns.Clear();
            dgvOPT.Columns.Clear();
            dgvLRU.Columns.Clear();
            dgvLFU.Columns.Clear();
            fifoCount = 0;
            optCount = 0;
            lruCount = 0;
            lfuCount = 0;


            int pageLength = Convert.ToInt32(numericUpDown1.Value);
            int rBlockSize = Convert.ToInt32(numericUpDown2.Value);
            blockArray = new int[rBlockSize];
            optArray = new OPTEntity[rBlockSize];
            lruArray = new LRUEntity[rBlockSize];
            lfuArray = new LFUEntity[rBlockSize];
            Random random = new Random();
            for (int i = 0; i < pageLength; i++)
            {
                pages.Add(random.Next(1, 8));
            }
            InitDataGridView(dgvFIFO, rBlockSize + 1);
            InitDataGridView(dgvOPT, rBlockSize + 1);
            InitDataGridView(dgvLRU, rBlockSize + 1);
            InitDataGridView(dgvLFU, rBlockSize + 1);
        }

        private void InitDataGridView(DataGridView dataGridView, int rowCount)
        {
            int columnIndex = 0;
            foreach (int i in pages)
            {
                dataGridView.Columns.Add(columnIndex.ToString(), i.ToString());
                dataGridView.Columns[columnIndex.ToString()].Width = 40;
                columnIndex++;
            }
            dataGridView.RowCount = rowCount;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
        }


        /// <summary>
        /// ���õ�Ԫ��ֵ����ʽ
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="value"></param>
        private void SetCellValueAndStyle(DataGridView dgv, int row, int column, int value)
        {
            dgv.Rows[row].Cells[column].Value = value;
            dgv.Rows[row].Cells[column].Style = new DataGridViewCellStyle()
            {
                BackColor = customerGreen,
                ForeColor = Color.White
            };
        }

        #region FIFO
        /// <summary>
        /// FIFOģ��ִ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFIFO_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < blockArray.Length; i++)
            {///�ظ����ʱ��ʼ��
                blockArray[i] = 0;
            }

            Task.Run(() =>
            {
                LockBtn(BtnType.FIFO);
                SimFIFO();
                UnLockBtn(BtnType.FIFO);
            });

        }
        /// <summary>
        /// FIFO
        /// </summary>
        private void SimFIFO()
        {
            #region FIFO�㷨
            int nextRemoveIndex = 0;
            bool blockIsFull = false;
            bool blockChange = false;
            int blockArrayItemCount = 0;
            int currentIndex = 0;

            for (int i = 0; i < pages.Count; i++)
            {
                if (blockArray.Contains(pages[i]))//�ж�һ���������������һ�ε��õ�ҳ
                {
                    blockChange = false;
                }
                else
                {
                    blockChange = true;
                    fifoCount++;
                    SetLabelCount(FIFOCount, fifoCount);
                }

                if (blockChange)//�����û�У���Ҫ��ҳ���������
                {
                    if (!blockIsFull)
                    {
                        blockArray[currentIndex] = pages[i];
                        currentIndex++;
                        blockArrayItemCount++;
                        if (blockArrayItemCount == blockArray.Length)
                        {
                            blockIsFull = true;
                        }
                    }
                    else
                    {
                        blockArray[nextRemoveIndex] = pages[i];
                        nextRemoveIndex++;
                        nextRemoveIndex = nextRemoveIndex % blockArray.Length;
                    }


                    for (int j = 1; j < blockArrayItemCount + 1; j++)
                    {
                        SetCellValueAndStyle(dgvFIFO, j, i, blockArray[j - 1]);
                    }

                }

                foreach (DataGridViewCell scell in dgvFIFO.SelectedCells)
                {
                    scell.Selected = false;
                }
                for (int j = 0; j < blockArray.Length + 1; j++)
                {
                    dgvFIFO.Rows[j].Cells[i].Selected = true;
                }
                Thread.Sleep(1000);
            }
            #endregion
        }
        #endregion

        #region OPT
        private void btnOPT_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                LockBtn(BtnType.OPT);
                SimOPT();
                UnLockBtn(BtnType.OPT);
            });
        }

        private void SimOPT()
        {
            int nextRemoveIndex = 0;
            bool optArrayIsFull = false;
            bool optArrayChange = false;
            int optArrayItemCount = 0;
            int currentIndex = 0;

            for (int i = 0; i < pages.Count; i++)
            {
                if (optArray.Select(x => x.Value).Contains(pages[i]))//�ж�һ���������������һ�ε��õ�ҳ
                {
                    optArrayChange = false;
                }
                else
                {
                    optArrayChange = true;
                    optCount++;
                    SetLabelCount(OPTCount, optCount);
                }

                if (optArrayChange)//�����û�У���Ҫ��ҳ���������
                {
                    if (!optArrayIsFull)
                    {
                        optArray[currentIndex] = new OPTEntity()
                        {
                            Value = pages[i],
                            LatestFindIndex = 0
                        };
                        currentIndex++;
                        optArrayItemCount++;
                        if (optArrayItemCount == optArray.Length)
                        {
                            optArrayIsFull = true;
                        }
                    }
                    else
                    {
                        nextRemoveIndex = GetShoudRemoveOptArrayIndex(i);
                        optArray[nextRemoveIndex] = new OPTEntity()
                        {
                            Value = pages[i],
                            LatestFindIndex = 0
                        };
                    }

                    for (int j = 1; j < optArrayItemCount + 1; j++)
                    {
                        SetCellValueAndStyle(dgvOPT, j, i, optArray[j - 1].Value);
                    }

                }

                foreach (DataGridViewCell scell in dgvOPT.SelectedCells)
                {
                    scell.Selected = false;
                }
                for (int j = 0; j < optArray.Length + 1; j++)
                {
                    dgvOPT.Rows[j].Cells[i].Selected = true;
                }
                Thread.Sleep(1000);
            }
        }
        /// <summary>
        /// ��ȡӦ�ñ��Ƴ���OptArray�±�
        /// </summary>
        /// <returns></returns>
        private int GetShoudRemoveOptArrayIndex(int pageStart)
        {
            for (int i = 0; i < optArray.Length; i++)
            {
                optArray[i].LatestFindIndex = pages.IndexOf(optArray[i].Value, pageStart);
                if (optArray[i].LatestFindIndex == 0)
                {
                    optArray[i].LatestFindIndex = int.MaxValue;
                }
            }
            int index = 0;
            int min = 0;
            for (int i = 0; i < optArray.Length; i++)
            {
                if (optArray[i].LatestFindIndex > min)
                {
                    min = optArray[i].LatestFindIndex;
                    index = i;
                }
            }
            return index;
        }
        #endregion

        #region LRU
        private void btnLRU_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                LockBtn(BtnType.LRU);
                SimLRU();
                UnLockBtn(BtnType.LRU);
            });
        }

        private void SimLRU()
        {
            int nextRemoveIndex = 0;
            bool lruArrayIsFull = false;
            bool lruArrayChange = false;
            int lruArrayItemCount = 0;
            int currentIndex = 0;

            for (int i = 0; i < pages.Count; i++)
            {
                for (int j = 0; j < lruArrayItemCount; j++)
                {
                    lruArray[j].Time += 1;//ģ��ʱ�����У����ϴη��ʺ�ʱ��+1
                }


                if (lruArray.Select(x => x.Value).Contains(pages[i]))//�ж�һ���������������һ�ε��õ�ҳ
                {
                    lruArrayChange = false;
                    #region �������ҳ�ű�ʹ���ˣ�������δʹ�õ�ʱ��
                    for (int j = 0; j < lruArrayItemCount; j++)
                    {
                        if (lruArray[j].Value == pages[i])
                        {
                            lruArray[j].Time = 0;
                        }
                    }
                    #endregion

                }
                else
                {
                    lruArrayChange = true;
                    lruCount++;
                    SetLabelCount(LRUCount, lruCount);
                }

                if (lruArrayChange)//�����û�У���Ҫ��ҳ���������
                {
                    if (!lruArrayIsFull)
                    {
                        lruArray[currentIndex] = new LRUEntity()
                        {
                            Value = pages[i],
                            Time = 0
                        };
                        currentIndex++;
                        lruArrayItemCount++;
                        if (lruArrayItemCount == lruArray.Length)
                        {
                            lruArrayIsFull = true;
                        }
                    }
                    else
                    {
                        nextRemoveIndex = GetShoudRemoveLRUArrayIndex(i);
                        lruArray[nextRemoveIndex] = new LRUEntity()
                        {
                            Value = pages[i],
                            Time = 0
                        };
                    }

                    for (int j = 1; j < lruArrayItemCount + 1; j++)
                    {
                        SetCellValueAndStyle(dgvLRU, j, i, lruArray[j - 1].Value);
                    }

                }

                foreach (DataGridViewCell scell in dgvLRU.SelectedCells)
                {
                    scell.Selected = false;
                }
                for (int j = 0; j < lruArray.Length + 1; j++)
                {
                    dgvLRU.Rows[j].Cells[i].Selected = true;
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// ��ȡӦ�ñ��Ƴ���LRUArray�±�
        /// </summary>
        /// <returns></returns>
        private int GetShoudRemoveLRUArrayIndex(int pageStart)
        {
            int index = 0;
            int min = 0;
            for (int i = 0; i < lruArray.Length; i++)
            {
                if (lruArray[i].Time > min)
                {
                    min = lruArray[i].Time;
                    index = i;
                }
            }
            return index;
        }
        #endregion

        #region LFU
        private void btnLFU_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                LockBtn(BtnType.LFU);
                SimLFU();
                UnLockBtn(BtnType.LFU);
            });
        }

        private void SimLFU()
        {
            int nextRemoveIndex = 0;
            bool lfuArrayIsFull = false;
            bool lfuArrayChange = false;
            int lfuArrayItemCount = 0;
            int currentIndex = 0;

            for (int i = 0; i < pages.Count; i++)
            {

                if (lfuArray.Select(x => x.Value).Contains(pages[i]))//�ж�һ���������������һ�ε��õ�ҳ
                {
                    lfuArrayChange = false;
                    #region �������ҳ�ű�ʹ���ˣ�������ʹ�ô�������
                    for (int j = 0; j < lfuArrayItemCount; j++)
                    {
                        if (lfuArray[j].Value == pages[i])
                        {
                            lfuArray[j].UseCount += 1;
                        }
                    }
                    #endregion

                }
                else
                {
                    lfuArrayChange = true;
                    lfuCount++;
                    SetLabelCount(LFUCount, lfuCount);
                }

                if (lfuArrayChange)//�����û�У���Ҫ��ҳ���������
                {
                    if (!lfuArrayIsFull)
                    {
                        lfuArray[currentIndex] = new LFUEntity()
                        {
                            Value = pages[i],
                            UseCount = 1
                        };
                        currentIndex++;
                        lfuArrayItemCount++;
                        if (lfuArrayItemCount == lfuArray.Length)
                        {
                            lfuArrayIsFull = true;
                        }
                    }
                    else
                    {
                        nextRemoveIndex = GetShoudRemoveLFUArrayIndex(i);
                        lfuArray[nextRemoveIndex] = new LFUEntity()
                        {
                            Value = pages[i],
                            UseCount = 1
                        };
                    }

                    for (int j = 1; j < lfuArrayItemCount + 1; j++)
                    {
                        SetCellValueAndStyle(dgvLFU, j, i, lfuArray[j - 1].Value);
                    }

                }

                foreach (DataGridViewCell scell in dgvLFU.SelectedCells)
                {
                    scell.Selected = false;
                }
                for (int j = 0; j < lfuArray.Length + 1; j++)
                {
                    dgvLFU.Rows[j].Cells[i].Selected = true;
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// ��ȡӦ�ñ��Ƴ���LFUArray�±�
        /// </summary>
        /// <returns></returns>
        private int GetShoudRemoveLFUArrayIndex(int pageStart)
        {
            int index = 0;
            int max = int.MaxValue;
            for (int i = 0; i < lfuArray.Length; i++)
            {
                if (lfuArray[i].UseCount < max)
                {
                    max = lfuArray[i].UseCount;
                    index = i;
                }
            }
            return index;
        }
        #endregion

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnFIFO.PerformClick();
            btnOPT.PerformClick();
            btnLRU.PerformClick();
            btnLFU.PerformClick();
        }
    }
}
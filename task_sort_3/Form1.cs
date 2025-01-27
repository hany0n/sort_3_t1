using System.Diagnostics;

namespace task_sort_3
{
    public partial class Form1 : Form
    {


        
        private int[] generatedArr = null;

        
        private int countFinishedSorts = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                var sizeText = textBoxSize.Text.Trim();
                var minText = textBoxMin.Text.Trim();
                var maxText = textBoxMax.Text.Trim();

                
                // for (int z = 0; z < 10; z++) { generatedArr[z] = z * 2; }

                int arrSize = int.Parse(sizeText);
                int arrMinVal = int.Parse(minText);
                int arrMaxVal = int.Parse(maxText);

                if (arrMinVal > arrMaxVal)
                {
                    MessageBox.Show("Минимальное значение не может быть больше максимального!");
                    return;
                }

                generatedArr = new int[arrSize];

               
                Random myRandom = new Random();
                for (int i = 0; i < arrSize; i++)
                {
                    generatedArr[i] = myRandom.Next(arrMinVal, arrMaxVal + 1);
                }

                
                listBoxOriginal.Items.Clear();
                foreach (int x in generatedArr)
                {
                    listBoxOriginal.Items.Add(x);
                }

                
                listBoxSorted.Items.Clear();
                labelBubbleResult.Text = "Bubble Sort: -";
                labelInsertionResult.Text = "Insertion Sort: -";
                labelSelectionResult.Text = "Selection Sort: -";

                countFinishedSorts = 0;

                MessageBox.Show("Массив создан!");
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ошибка при генерации массива: " + ex.Message);
            }
        }


        private void buttonSort_Click(object sender, EventArgs e)
        {
            
            if (generatedArr == null || generatedArr.Length == 0)
            {
                MessageBox.Show("Нужно сгенерировать массив!");
                return;
            }

            
            var bubbleArr = (int[])generatedArr.Clone();
            var insertionArr = (int[])generatedArr.Clone();
            var selectionArr = (int[])generatedArr.Clone();

            
            Thread bThread = new Thread(() => BubbleSorter(bubbleArr));
            Thread iThread = new Thread(() => InsertionSorter(insertionArr));
            Thread sThread = new Thread(() => SelectionSorter(selectionArr));

            
            bThread.Start();
            iThread.Start();
            sThread.Start();
        }

        private void OnSortFinished(int[] sortedArr)
        {
            countFinishedSorts++;
            
            if (countFinishedSorts == 3)
            {
                listBoxSorted.Items.Clear();
                foreach (var val in sortedArr)
                {
                    listBoxSorted.Items.Add(val);
                }
                MessageBox.Show("Все три сортировки завершены!");
            }
        }


        private void BubbleSorter(int[] arr)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            
            int cmp = 0;
            int sw = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int jCnt = 0; jCnt < arr.Length - 1 - i; jCnt++)
                {
                    cmp++;
                    if (arr[jCnt] > arr[jCnt + 1])
                    {
                        sw++;
                        int temp = arr[jCnt];
                        arr[jCnt] = arr[jCnt + 1];
                        arr[jCnt + 1] = temp;
                    }
                }
            }

            watch.Stop();
            long timeMs = watch.ElapsedMilliseconds;

            
            this.Invoke((Action)(() =>
            {
                labelBubbleResult.Text = $"Сортировка пузырьком: {timeMs} мс (сравнений: {cmp}, перестановок: {sw})";
                OnSortFinished(arr);
            }));
        }


        private void InsertionSorter(int[] arr)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int compCount = 0;
            int swapCount = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int idx = i - 1;

                while (idx >= 0)
                {
                    compCount++;
                    if (arr[idx] > key)
                    {
                        arr[idx + 1] = arr[idx];
                        idx--;
                        swapCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                arr[idx + 1] = key;
            }

            stopWatch.Stop();
            long spentMs = stopWatch.ElapsedMilliseconds;

            this.Invoke((Action)(() =>
            {
                labelInsertionResult.Text = $"Сортировка вставками: {spentMs} мс (сравнений: {compCount}, перестановок: {swapCount})";
                OnSortFinished(arr);
            }));
        }


        private void SelectionSorter(int[] arr)
        {
            Stopwatch stpWatch = new Stopwatch();
            stpWatch.Start();

            int cCount = 0;
            int sCount = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    cCount++;
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    sCount++;
                    int tmpVal = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = tmpVal;
                }
            }

            stpWatch.Stop();
            long msTime = stpWatch.ElapsedMilliseconds;

            this.Invoke((Action)(() =>
            {
                labelSelectionResult.Text = $"Сортировка выбором: {msTime} мс (сравнений: {cCount}, перестановок: {sCount})";
                OnSortFinished(arr);
            }));
        }
    

        
       





        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

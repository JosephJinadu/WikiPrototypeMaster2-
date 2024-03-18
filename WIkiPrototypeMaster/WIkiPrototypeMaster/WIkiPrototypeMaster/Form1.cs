using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WIkiPrototypeMaster
{
    public partial class FormWiki : Form
    {
        #region FormWiki
        public FormWiki()
        {

            InitializeComponent();
            InitializewikiArray();
            DisplayList();

            toolStripStatusLabel1.Text = "Program opened successfully.";
        }
        // Question 9.1 - Global array and static variables
        // Global 2D string array with static variables for dimensions (row = 12, column = 4)
        readonly static int Rows = 12;
        readonly static int Columns = 4;
        private string[,] wikiArray = new string[Rows, Columns];
        int currentIndex = 0;

        #endregion


        #region Method 
        private void ResetTextBoxes()
        {
            // Method to reset all text boxes
            {
                // Clear text boxes
                Searchtxtbox.Clear();
                datastructuretxtbox.Clear();
                Categorytxtbox.Clear();
                Structuretxtbox.Clear();
                defintiontxtbox.Clear();
            }
        }
        // Initialize the 2D array with empty strings
        private void InitializewikiArray()
        {
            // Method to initialize the 2D array with empty strings
            // Initialize each element in the array with "~"
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        wikiArray[i, j] = "~";
                    }
                }
            }
        }
           
        private void DisplayList()
        {
            //9.8 Display List
            // Clear existing items
            listview_Array.Items.Clear();
            BubbleSort();

            // Populate ListView with Name and Category
            for (int i = 0; i < Rows; i++)
            {
                if (wikiArray[i, 0] != null)
                {
                    listview_Array.Items.Add(new ListViewItem(new string[] { wikiArray[i, 0], wikiArray[i, 1] }));
                }
            }
        }
        #region Bubble Sort
        private void BubbleSort()
        {
            //9.6 Bubble Sort to sort out the 2D array in ascending order 
            // Iterate through each row in the array
            for (int i = 0; i < Rows - 1; i++)
            {
                // Iterate through each row again, starting from the next row
                for (int j = 0; j < Rows - i - 1; j++)
                {
                    // Compare the Names of adjacent rows
                    if (string.CompareOrdinal(wikiArray[j, 0], wikiArray[j + 1, 0]) > 0)
                    {
                        // Swap the rows if the Name in the current row is greater than the Name in the next row
                        SwapRows(j, j + 1);
                    }
                }
            }
        }
        private void SwapRows(int j, int v)
        {
            // Method to swap two rows in the 2D array
            // Swap elements at the specified indices in the 2D array
            for (int col = 0; col < Columns; col++)
            {
                string temp = wikiArray[j, col];
                wikiArray[j, col] = wikiArray[v, col];
                wikiArray[v, col] = temp;
            }
        }
        #endregion

        private void listview_Array_SelectedIndexChanged(object sender, EventArgs e)
        {
            //9.9 Select definitions from the List View_Array 
            // Event handler for selecting an item in the ListView
            if (listview_Array.SelectedItems.Count > 0)
            {
                int selectedIndex = listview_Array.SelectedIndices[0];
                datastructuretxtbox.Text = wikiArray[selectedIndex, 0];
                Categorytxtbox.Text = wikiArray[selectedIndex, 1];
                Structuretxtbox.Text = wikiArray[selectedIndex, 2];
                defintiontxtbox.Text = wikiArray[selectedIndex, 3];
            }
        }
        #endregion

        #region Button Function
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //9.5 To clear 4 text boxes  so that the user can input a new definition in
            ResetTextBoxes();
            toolStripStatusLabel1.Text = "All text boxes have been cleared";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // 9.2 Add Button 
            // Button event handler to add data to the 2D array
            {
                // Check if all text boxes have valid inputs
                if (string.IsNullOrWhiteSpace(datastructuretxtbox.Text) ||
                    string.IsNullOrWhiteSpace(Categorytxtbox.Text) ||
                    string.IsNullOrWhiteSpace(Structuretxtbox.Text) ||
                    string.IsNullOrWhiteSpace(defintiontxtbox.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Find the first empty row in the array
                if (currentIndex + 1 > 12)
                {
                    MessageBox.Show("Array is full");
                    return;
                }

                // Add information to the array from respective text boxes
                wikiArray[currentIndex, 0] = datastructuretxtbox.Text.ToUpper();
                wikiArray[currentIndex, 1] = Categorytxtbox.Text;
                wikiArray[currentIndex, 2] = Structuretxtbox.Text;
                wikiArray[currentIndex, 3] = defintiontxtbox.Text;
                currentIndex++;

                // Provide feedback
                MessageBox.Show("Information added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTextBoxes(); // Reset all text boxes
                DisplayList(); // Display the updated list
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //9.3 Edit Button
            // Button event handler to edit data in the 2D array
            // Check if any item is selected in the list view
            if (listview_Array.SelectedItems.Count == 0)
            {
                toolStripStatusLabel1.Text = "Must select a cell to edit.";
                return;
            }

            // Get the index of the selected item
            int selectedIndex = listview_Array.SelectedIndices[0];

            // Validate selected index
            if (selectedIndex < 0 || selectedIndex >= wikiArray.GetLength(0))
            {
                toolStripStatusLabel1.Text = "Invalid selection.";
                return;
            }

            // Check if any of the text boxes are empty
            if (string.IsNullOrEmpty(datastructuretxtbox.Text) ||
                string.IsNullOrEmpty(Categorytxtbox.Text) ||
                string.IsNullOrEmpty(Structuretxtbox.Text) ||
                string.IsNullOrEmpty(defintiontxtbox.Text))
            {
                toolStripStatusLabel1.Text = "Need to fill all fields to edit cell.";
                return;
            }

            // Update data in the global array with values from text boxes
            wikiArray[selectedIndex, 0] = datastructuretxtbox.Text.ToUpper();
            wikiArray[selectedIndex, 1] = Categorytxtbox.Text;
            wikiArray[selectedIndex, 2] = Structuretxtbox.Text;
            wikiArray[selectedIndex, 3] = defintiontxtbox.Text;

            // Provide feedback
            toolStripStatusLabel1.Text = "Successfully edited cell.";

            // Reset text boxes after editing
            ResetTextBoxes();
            DisplayList();
        }

        

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            //9.11 this to open a dat file from the release version of the code 
            // Button event handler to load data from a binary file
            // Implementation for loading data
            // Create OpenFileDialog to allow the user to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            openFileDialog.Title = "Select a binary file";

            // Show OpenFileDialog and handle result
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                try
                {
                    // Read data from the binary file into the 2D array
                    using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                    {
                        int x = 0; // Initialize a counter for array indexing
                        listview_Array.Items.Clear(); // Clear the ListView

                        // Read data from the file until the end is reached
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            try
                            {
                                // Read data from the file and assign it to corresponding positions in the global array
                                wikiArray[x, 0] = reader.ReadString().ToUpper();
                                wikiArray[x, 1] = reader.ReadString();
                                wikiArray[x, 2] = reader.ReadString();
                                wikiArray[x, 3] = reader.ReadString();
                                currentIndex++;
                                x++;
                            }
                            catch (Exception ex)
                            {
                                // Display an error message if data cannot be read from the file or if the end of file is reached unexpectedly
                                MessageBox.Show("Cannot read data from file or EOF: " + ex.Message);
                                break; // Exit the loop if an error occurs
                            }
                        }
                    }

                    // Provide feedback
                    toolStripStatusLabel1.Text = "Data loaded successfully.";

                    // Optionally, refresh the ListView or perform other actions with the loaded data
                    DisplayList(); // Example method call to refresh the ListView
                }
                catch (Exception ex)
                {
                    // Provide feedback in case of error
                    toolStripStatusLabel1.Text = $"Error loading data: {ex.Message}";
                }
            }
        }



        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //9.4 to delete all the information from a single entry of the array 
            // Button event handler to delete data from the 2D array
            {
                // Check if any item is selected in the ListView
                if (listview_Array.SelectedItems.Count > 0)
                {
                    // Get the index of the selected item
                    int selectedIndex = listview_Array.SelectedIndices[0];

                    if (selectedIndex > currentIndex)
                    {
                        toolStripStatusLabel1.Text = "Cannot delete cell";
                        return;
                    }

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this cell?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        toolStripStatusLabel1.Text = "Cell was not deleted.";
                        return;
                    }

                    // Remove selected item from the ListView
                    listview_Array.Items.RemoveAt(selectedIndex);

                    // Clear the corresponding values from the 2D array
                    for (int j = 0; j < Columns; j++)
                    {
                        wikiArray[selectedIndex, j] = "~";
                    }

                    // Provide feedback
                    toolStripStatusLabel1.Text = "Entry deleted successfully.";
                    ResetTextBoxes();
                    DisplayList();
                    currentIndex--;
                }
                else
                {
                    toolStripStatusLabel1.Text = "No cell selected for deletion";
                }
            }

        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //9.10 To Save a the program that user has written in the list view and save it as a dat file 
            // Button event handler to save data to a binary file
            // Implementation for saving data
            // Create SaveFileDialog to allow the user to choose the save location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            saveFileDialog.FileName = "definitions.dat";
            saveFileDialog.Title = "Save data to binary file";

            // Show SaveFileDialog and handle result
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    // Sort the 2D array by Name before saving
                    BubbleSort();

                    // Write data from the sorted 2D array into the binary file
                    using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
                    {
                        for (int i = 0; i < Rows; i++)
                        {
                            for (int j = 0; j < Columns; j++)
                            {
                                writer.Write(wikiArray[i, j]);
                            }
                        }
                    }

                    // Provide feedback
                    toolStripStatusLabel1.Text = "Data saved successfully.";
                }
                catch (Exception ex)
                {
                    // Provide feedback in case of error
                    toolStripStatusLabel1.Text = $"Error saving data: {ex.Message}";
                }
            }
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            //9.7 This button is for searching an information in the list view array using a binary search method 
            // Button event handler to search for data in the 2D array
            // Implementation for searching data
            string searchName = Searchtxtbox.Text.ToUpper();

            // Initialize search indices
            int start = 0;
            int end = Rows - 1;
            bool found = false;
            int cell = 0;

            // Continue search until start index is less than or equal to end index
            while (start <= end)
            {
                // Calculate mid index
                int mid = start + (end - start) / 2;

                // Compare search name with name at mid index
                if (wikiArray[mid, 0] == searchName)
                {
                    // Name found, display information in other text boxes
                    datastructuretxtbox.Text = wikiArray[mid, 0];
                    Categorytxtbox.Text = wikiArray[mid, 1];
                    Structuretxtbox.Text = wikiArray[mid, 2];
                    defintiontxtbox.Text = wikiArray[mid, 3];
                    cell = mid;
                    found = true;
                    break;
                }
                else if (string.Compare(wikiArray[mid, 0], searchName) < 0) // Search in the right half
                {
                    start = mid + 1;
                }
                else // Search in the left half
                {
                    end = mid - 1;
                }
            }

            if (!found)
            {
                // Clear other text boxes
                datastructuretxtbox.Text = "";
                Categorytxtbox.Text = "";
                Structuretxtbox.Text = "";
                defintiontxtbox.Text = "";

                // Clear search textbox and provide feedback
                Searchtxtbox.Text = "";
                toolStripStatusLabel1.Text = "Item not found.";
            }
            else
            {
                // Provide feedback for successful search
                toolStripStatusLabel1.Text = "Item found at index: " + cell;
            }
        }
        #endregion
    }
}

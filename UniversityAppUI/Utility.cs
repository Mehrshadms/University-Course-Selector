namespace UniversityAppUI
{
    public static class Utility
    {
        public static int WhichItemIsSelected(MaterialSkin.Controls.MaterialComboBox Mcb, string SearchKey)
        {
            for (int i = 0; i < Mcb.Items.Count; i++)
            {
                if (Mcb.Items[i].ToString() == SearchKey)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
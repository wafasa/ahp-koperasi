using System;
using System.Collections.Specialized;

namespace helper.Class
{
    static class MdiFormLoader
    {
        private static readonly HybridDictionary m_InitializedForms = new HybridDictionary();

        public static void LoadFormType(Type formType, System.Windows.Forms.Form mdiParentForm)
        {
            if (IsAlreadyLoaded(formType)) { return; }
            FlagAsLoaded(formType);
            System.Windows.Forms.Form frm = (System.Windows.Forms.Form)Activator.CreateInstance(formType);
            frm.MdiParent = mdiParentForm;
            frm.Closed += FormClosed;
            frm.Show();
        }

        private static void FlagAsLoaded(Type formType)
        {
            m_InitializedForms[formType.Name] = true;
        }

        private static void FlagAsNotLoaded(Type formType)
        {
            m_InitializedForms[formType.Name] = false;
        }

        private static bool IsAlreadyLoaded(Type formType)
        {
            return ((m_InitializedForms[formType.Name] != null) && (bool)m_InitializedForms[formType.Name]);
        }

        private static void FormClosed(object sender, EventArgs e)
        {
            System.Windows.Forms.Form closingForm = (System.Windows.Forms.Form)sender;
            closingForm.Closed -= FormClosed;
            FlagAsNotLoaded(sender.GetType());
        }
    }
}

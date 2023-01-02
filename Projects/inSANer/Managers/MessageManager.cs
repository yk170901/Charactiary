using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inSANer.Managers
{
    // May or May not Be Used
    internal class MessageManager
    {
        public void MessageThemeChanged()
        {

        }

        #region Edits
        public void MessageProjectEdited()
        {

        }

        public void MessageCardFolderEdited()
        {
            // 영향 받는 곳
            // Sidebar (ProjectContainer)
            // ProjectManager (I Guess) -> 해당 프로젝트 ProjectModel
            // 

        }

        public void MessageCardFileEdited()
        {

        }
        #endregion

        #region Adds
        public void MessageProjectAdded()
        {

        }

        public void MessageCardFolderAdded()
        {

        }

        public void MessageCardFileAdded()
        {

        }
        #endregion

        #region Removes
        public void MessageProjectRemoved()
        {

        }

        public void MessageCardFolderRemoved()
        {

        }

        public void MessageCardFileRemoved()
        {

        }
        #endregion
    }
}

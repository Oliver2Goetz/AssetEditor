using System.Collections.Generic;

namespace AlienPAK {

    class BulkImportResult {

        public List<string> successfulFiles = new List<string>();
        public List<string> failedFiles = new List<string>();
        public List<string> ignoredFiles = new List<string>();

        public string getResultString() {
            string result = "";

            if (0 < this.successfulFiles.Count) {
                result += "Successful files (" + this.successfulFiles.Count + "):\n";
                foreach (string file in this.successfulFiles) {
                    result += " - " + file + "\n";
                }
            }

            if (0 < this.failedFiles.Count) {
                result += "Failed files (" + this.failedFiles.Count + "):\n";
                foreach (string file in this.failedFiles) {
                    result += " - " + file + "\n";
                }
            }

            if (0 < this.ignoredFiles.Count) {
                result += "Ignored files (" + this.ignoredFiles.Count + "):\n";
                foreach (string file in this.ignoredFiles) {
                    result += " - " + file + "\n";
                }

                result += "\nIgnored files are files which are not imported since they aren't existing in the PAK.";
            }

            return result;
        }
    }
}

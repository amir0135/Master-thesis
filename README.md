
This repository contains the code and documentation for my master’s thesis, which explores the integration of machine learning models with FPGA hardware for efficient high-performance computing.

The complete code setup is split across three repositories:
	•	Master Thesis (this repository): Documentation, experimental results, and supplementary materials related to the thesis.
	•	ML_SME_FPGA-main: Contains the main FPGA integration code and setup.
	•	Feedforward-Network: Implements the feedforward neural network used in the project.

⸻

Overview

The project investigates the design, implementation, and evaluation of machine learning algorithms deployed on FPGA platforms. Key focus areas include:
	•	Efficient integration of ML models with FPGA hardware.
	•	Performance improvements through hardware acceleration.
	•	Detailed analysis and documentation of the experimental setup and results.

⸻

Repository Structure
	•	docs/: Thesis documents, supplementary materials, and presentations.
	•	code/: Scripts, notebooks, and other experiment-related code.
	•	results/: Data outputs, plots, and analysis results.
	•	README.md: This documentation file.

⸻

Dependencies and Installation

Ensure you have the following installed:
	•	Python 3.x and necessary packages (see individual repository requirements).
	•	FPGA Toolchain (e.g., Xilinx Vivado or Intel Quartus, depending on your target hardware).

Setup Steps
	1.	Clone this repository:

git clone https://github.com/amir0135/Master-thesis.git


  2.	Clone the complete code setup:

git clone https://github.com/amir0135/ML_SME_FPGA-main.git
git clone https://github.com/amir0135/Feedforward-Network.git


  3.	Follow the installation instructions in the ML_SME_FPGA-main and Feedforward-Network repositories to configure your FPGA environment and run the ML models.

⸻

Usage
	•	Simulation & Testing:
  Navigate to the Feedforward-Network repository and run the provided scripts (e.g., main.py) to simulate the neural network model.
	•	FPGA Deployment:
Refer to the ML_SME_FPGA-main repository for instructions on deploying the models to FPGA hardware.
	•	Documentation & Analysis:
Detailed experimental setups, performance metrics, and results are documented in the docs/ folder.

⸻

Results

The thesis demonstrates significant performance improvements by leveraging FPGA acceleration for machine learning tasks. All results and comparative analyses are detailed within the thesis document in the docs/ directory.


License

This project is licensed under the MIT License. See the LICENSE file for details.

⸻

Acknowledgments

Special thanks to my advisors, collaborators, and everyone who supported this research

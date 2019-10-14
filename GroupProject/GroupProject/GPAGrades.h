#pragma once

namespace GroupProject {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for GPAGrades
	/// </summary>
	public ref class GPAGrades : public System::Windows::Forms::Form
	{
	public:
		GPAGrades(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~GPAGrades()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::GroupBox^ calculategpagroupbox;
	protected:
	private: System::Windows::Forms::Label^ gpalabel2;
	private: System::Windows::Forms::Button^ calculatebutton;
	private: System::Windows::Forms::Label^ gpalabel;
	private: System::Windows::Forms::Button^ backbutton;
	private: System::Windows::Forms::GroupBox^ currentgradesgroupbox;
	private: System::Windows::Forms::DataGridView^ viewgradegridview;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ department;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ id;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ name;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ grade;
	private: System::Windows::Forms::Button^ exitbutton;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->calculategpagroupbox = (gcnew System::Windows::Forms::GroupBox());
			this->gpalabel2 = (gcnew System::Windows::Forms::Label());
			this->calculatebutton = (gcnew System::Windows::Forms::Button());
			this->gpalabel = (gcnew System::Windows::Forms::Label());
			this->backbutton = (gcnew System::Windows::Forms::Button());
			this->currentgradesgroupbox = (gcnew System::Windows::Forms::GroupBox());
			this->viewgradegridview = (gcnew System::Windows::Forms::DataGridView());
			this->department = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->id = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->name = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->grade = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->exitbutton = (gcnew System::Windows::Forms::Button());
			this->calculategpagroupbox->SuspendLayout();
			this->currentgradesgroupbox->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->viewgradegridview))->BeginInit();
			this->SuspendLayout();
			// 
			// calculategpagroupbox
			// 
			this->calculategpagroupbox->Controls->Add(this->gpalabel2);
			this->calculategpagroupbox->Controls->Add(this->calculatebutton);
			this->calculategpagroupbox->Controls->Add(this->gpalabel);
			this->calculategpagroupbox->Location = System::Drawing::Point(125, 270);
			this->calculategpagroupbox->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->calculategpagroupbox->Name = L"calculategpagroupbox";
			this->calculategpagroupbox->Padding = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->calculategpagroupbox->Size = System::Drawing::Size(398, 108);
			this->calculategpagroupbox->TabIndex = 10;
			this->calculategpagroupbox->TabStop = false;
			this->calculategpagroupbox->Text = L"Calculate GPA";
			// 
			// gpalabel2
			// 
			this->gpalabel2->BorderStyle = System::Windows::Forms::BorderStyle::Fixed3D;
			this->gpalabel2->Location = System::Drawing::Point(72, 57);
			this->gpalabel2->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->gpalabel2->Name = L"gpalabel2";
			this->gpalabel2->Size = System::Drawing::Size(134, 35);
			this->gpalabel2->TabIndex = 6;
			// 
			// calculatebutton
			// 
			this->calculatebutton->Location = System::Drawing::Point(258, 57);
			this->calculatebutton->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->calculatebutton->Name = L"calculatebutton";
			this->calculatebutton->Size = System::Drawing::Size(112, 35);
			this->calculatebutton->TabIndex = 4;
			this->calculatebutton->Text = L"Calculate";
			this->calculatebutton->UseVisualStyleBackColor = true;
			// 
			// gpalabel
			// 
			this->gpalabel->AutoSize = true;
			this->gpalabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->gpalabel->Location = System::Drawing::Point(68, 28);
			this->gpalabel->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->gpalabel->Name = L"gpalabel";
			this->gpalabel->Size = System::Drawing::Size(139, 20);
			this->gpalabel->TabIndex = 5;
			this->gpalabel->Text = L"Semester GPA:";
			// 
			// backbutton
			// 
			this->backbutton->Location = System::Drawing::Point(569, 282);
			this->backbutton->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->backbutton->Name = L"backbutton";
			this->backbutton->Size = System::Drawing::Size(112, 35);
			this->backbutton->TabIndex = 9;
			this->backbutton->Text = L"Back";
			this->backbutton->UseVisualStyleBackColor = true;
			// 
			// currentgradesgroupbox
			// 
			this->currentgradesgroupbox->Controls->Add(this->viewgradegridview);
			this->currentgradesgroupbox->Location = System::Drawing::Point(13, 14);
			this->currentgradesgroupbox->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->currentgradesgroupbox->Name = L"currentgradesgroupbox";
			this->currentgradesgroupbox->Padding = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->currentgradesgroupbox->Size = System::Drawing::Size(669, 246);
			this->currentgradesgroupbox->TabIndex = 8;
			this->currentgradesgroupbox->TabStop = false;
			this->currentgradesgroupbox->Text = L"Current Grades";
			// 
			// viewgradegridview
			// 
			this->viewgradegridview->AllowUserToAddRows = false;
			this->viewgradegridview->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->viewgradegridview->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(4) {
				this->department,
					this->id, this->name, this->grade
			});
			this->viewgradegridview->Location = System::Drawing::Point(32, 29);
			this->viewgradegridview->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->viewgradegridview->Name = L"viewgradegridview";
			this->viewgradegridview->RowHeadersWidth = 62;
			this->viewgradegridview->Size = System::Drawing::Size(628, 194);
			this->viewgradegridview->TabIndex = 0;
			// 
			// department
			// 
			this->department->HeaderText = L"Department";
			this->department->MinimumWidth = 8;
			this->department->Name = L"department";
			this->department->Width = 75;
			// 
			// id
			// 
			this->id->HeaderText = L"Course Number";
			this->id->MinimumWidth = 8;
			this->id->Name = L"id";
			this->id->Width = 50;
			// 
			// name
			// 
			this->name->HeaderText = L"Name";
			this->name->MinimumWidth = 8;
			this->name->Name = L"name";
			this->name->Width = 200;
			// 
			// grade
			// 
			this->grade->HeaderText = L"Grade";
			this->grade->MinimumWidth = 8;
			this->grade->Name = L"grade";
			this->grade->Width = 50;
			// 
			// exitbutton
			// 
			this->exitbutton->Location = System::Drawing::Point(569, 327);
			this->exitbutton->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->exitbutton->Name = L"exitbutton";
			this->exitbutton->Size = System::Drawing::Size(112, 35);
			this->exitbutton->TabIndex = 7;
			this->exitbutton->Text = L"Logout";
			this->exitbutton->UseVisualStyleBackColor = true;
			// 
			// GPAGrades
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(9, 20);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(697, 387);
			this->Controls->Add(this->calculategpagroupbox);
			this->Controls->Add(this->backbutton);
			this->Controls->Add(this->currentgradesgroupbox);
			this->Controls->Add(this->exitbutton);
			this->Name = L"GPAGrades";
			this->Text = L"GPAGrades";
			this->calculategpagroupbox->ResumeLayout(false);
			this->calculategpagroupbox->PerformLayout();
			this->currentgradesgroupbox->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->viewgradegridview))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	};
}

#pragma once

namespace GroupProject {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for courselist
	/// </summary>
	public ref class courselist : public System::Windows::Forms::Form
	{
	public:
		courselist(void)
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
		~courselist()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ logoutbutton;
	protected:
	private: System::Windows::Forms::Button^ backbutton;
	private: System::Windows::Forms::GroupBox^ enrolledcoursesgroupbox;
	private: System::Windows::Forms::DataGridView^ enrolledcoursesgridview;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ department;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ id;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ name;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ professor;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ grade;

	protected:






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
			this->logoutbutton = (gcnew System::Windows::Forms::Button());
			this->backbutton = (gcnew System::Windows::Forms::Button());
			this->enrolledcoursesgroupbox = (gcnew System::Windows::Forms::GroupBox());
			this->enrolledcoursesgridview = (gcnew System::Windows::Forms::DataGridView());
			this->department = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->id = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->name = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->professor = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->grade = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->enrolledcoursesgroupbox->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->enrolledcoursesgridview))->BeginInit();
			this->SuspendLayout();
			// 
			// logoutbutton
			// 
			this->logoutbutton->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(78)), static_cast<System::Int32>(static_cast<System::Byte>(184)),
				static_cast<System::Int32>(static_cast<System::Byte>(206)));
			this->logoutbutton->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->logoutbutton->Location = System::Drawing::Point(529, 185);
			this->logoutbutton->Name = L"logoutbutton";
			this->logoutbutton->Size = System::Drawing::Size(75, 23);
			this->logoutbutton->TabIndex = 6;
			this->logoutbutton->Text = L"Logout";
			this->logoutbutton->UseVisualStyleBackColor = false;
			// 
			// backbutton
			// 
			this->backbutton->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(78)), static_cast<System::Int32>(static_cast<System::Byte>(184)),
				static_cast<System::Int32>(static_cast<System::Byte>(206)));
			this->backbutton->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->backbutton->Location = System::Drawing::Point(447, 185);
			this->backbutton->Name = L"backbutton";
			this->backbutton->Size = System::Drawing::Size(75, 23);
			this->backbutton->TabIndex = 5;
			this->backbutton->Text = L"Back";
			this->backbutton->UseVisualStyleBackColor = false;
			// 
			// enrolledcoursesgroupbox
			// 
			this->enrolledcoursesgroupbox->Controls->Add(this->enrolledcoursesgridview);
			this->enrolledcoursesgroupbox->ForeColor = System::Drawing::SystemColors::Control;
			this->enrolledcoursesgroupbox->Location = System::Drawing::Point(9, 9);
			this->enrolledcoursesgroupbox->Name = L"enrolledcoursesgroupbox";
			this->enrolledcoursesgroupbox->Size = System::Drawing::Size(595, 170);
			this->enrolledcoursesgroupbox->TabIndex = 4;
			this->enrolledcoursesgroupbox->TabStop = false;
			this->enrolledcoursesgroupbox->Text = L"Enrolled Courses";
			// 
			// enrolledcoursesgridview
			// 
			this->enrolledcoursesgridview->AllowUserToAddRows = false;
			this->enrolledcoursesgridview->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->enrolledcoursesgridview->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(5) {
				this->department,
					this->id, this->name, this->professor, this->grade
			});
			this->enrolledcoursesgridview->Location = System::Drawing::Point(13, 19);
			this->enrolledcoursesgridview->Name = L"enrolledcoursesgridview";
			this->enrolledcoursesgridview->RowHeadersWidth = 62;
			this->enrolledcoursesgridview->Size = System::Drawing::Size(568, 139);
			this->enrolledcoursesgridview->TabIndex = 0;
			this->enrolledcoursesgridview->CellContentClick += gcnew System::Windows::Forms::DataGridViewCellEventHandler(this, &courselist::Enrolledcoursesgridview_CellContentClick);
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
			this->id->FillWeight = 125;
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
			// professor
			// 
			this->professor->HeaderText = L"Professor";
			this->professor->MinimumWidth = 8;
			this->professor->Name = L"professor";
			this->professor->Width = 150;
			// 
			// grade
			// 
			this->grade->HeaderText = L"Grade";
			this->grade->MinimumWidth = 8;
			this->grade->Name = L"grade";
			this->grade->Width = 50;
			// 
			// courselist
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(34)), static_cast<System::Int32>(static_cast<System::Byte>(36)),
				static_cast<System::Int32>(static_cast<System::Byte>(49)));
			this->ClientSize = System::Drawing::Size(613, 216);
			this->Controls->Add(this->logoutbutton);
			this->Controls->Add(this->backbutton);
			this->Controls->Add(this->enrolledcoursesgroupbox);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->Name = L"courselist";
			this->Text = L"courselist";
			this->enrolledcoursesgroupbox->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->enrolledcoursesgridview))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion

private: System::Void Enrolledcoursesgridview_CellContentClick(System::Object^ sender, System::Windows::Forms::DataGridViewCellEventArgs^ e) {
}
};
}

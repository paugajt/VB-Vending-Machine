; Homework #1

          .equ SWI_Exit,    0x11  ; Set the value of SWI_Exit to 0x11
start:    LDR  R1, =a             ; Load the value of a into register R1
          LDR  R2, =b             ; Load the value of b into register R2
          ADD  R3,R1,R2           ; Add R1 and R2 and store the result into R3
          LDR  R7, =value1        ; Load the address of value1 into R7
          STR  R3,[R7]            ; Store the data in R3 at location with label value1
          SUB  R4,R1,R2           ; Subtract R2 from R1 and store the result into R4
          LDR  R7, =value2        ; Load the address of value2 into R7
          STR  R4, [R7]           ; Store the data in R4 at location with label value2
          MULS R5,R1,R2           ; Multiply R1 and R2 and store the result into R5
          LDR  R7, =value3        ; Load the address of value3 into R7
          STR  R5, [R7]           ; Store the data in R5 at location with label value3
          ADD  R6, R3, R4         ; Add R3 and R4 and store the result into R6
          ADD  R6, R6, R5         ; Add R6 and R5 and store the result into R6
          LDR  R7, =value4        ; Load the adreess of value4 into R7
          STR  R6, [R7]           ; Store the data in R6 at location with label value4
          SWI  SWI_Exit           ; Stop Program Execution

.data

a:       .word 0x1
b:       .word 0x2
value1:  .word 0x0
value2:  .word 0x0
value3:  .word 0x0
value4:  .word 0x0
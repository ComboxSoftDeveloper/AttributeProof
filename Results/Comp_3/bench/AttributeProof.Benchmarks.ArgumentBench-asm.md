## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       rcx,2D0E6958B08
       jmp       qword ptr [7FFDF2A7F978]; AttributeProof.Subjects.CheckByLibrary(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByLibrary(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,28
       ret
M01_L00:
       mov       ecx,67
       mov       rdx,7FFDF294BE48
       call      qword ptr [7FFDF26AF210]
       mov       rcx,rax
       call      qword ptr [7FFDF2B357B8]
       int       3
; Total bytes of code 48
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       rcx,2E03A308B08
       jmp       qword ptr [7FFDF2A4F960]; AttributeProof.Subjects.CheckByHand(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByHand(System.String)
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,67
       mov       rdx,7FFDF291BE48
       call      qword ptr [7FFDF267F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF29A72E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 79
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       rcx,27E07D58DA8
       jmp       qword ptr [7FFDC8E5E958]; AttributeProof.Subjects.CheckByLibrary(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByLibrary(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,28
       ret
M01_L00:
       mov       ecx,67
       mov       rdx,7FFDC8C31528
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFDC8C166E8]
       int       3
; Total bytes of code 47
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       rcx,2627AC48DA8
       jmp       qword ptr [7FFDC8E3E160]; AttributeProof.Subjects.CheckByHand(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByHand(System.String)
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,67
       mov       rdx,7FFDC8C11528
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC8BF6640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.Library()
       mov       rcx,2981A7C9058
       jmp       qword ptr [7FFDB57FEB20]; AttributeProof.Subjects.CheckByLibrary(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByLibrary(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,28
       ret
M01_L00:
       mov       ecx,67
       mov       rdx,7FFDB56D7478
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFDB58C4C00]
       int       3
; Total bytes of code 47
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.ArgumentBench.ByHand()
       mov       rcx,254C51E9058
       jmp       qword ptr [7FFDB57CEBF8]; AttributeProof.Subjects.CheckByHand(System.String)
; Total bytes of code 16
```
```assembly
; AttributeProof.Subjects.CheckByHand(System.String)
       push      rbx
       sub       rsp,20
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,67
       mov       rdx,7FFDB56A7478
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDB5736760]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```


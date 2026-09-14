## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A5F9A8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,81EB5E87A993
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,81EB5E87A993
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDF2897D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A4F8D0]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,45DAE1FA1657
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,45DAE1FA1657
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDF2887D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E6E8E0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,559E52B85B95
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,559E52B85B95
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDC8BFE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E3E0E8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0B6998D59C803
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0B6998D59C803
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDC8BCE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDB57DEB50]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,9A024E661309
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,9A024E661309
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDB5637888]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDB57EEC10]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,3DE4B68C8757
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,3DE4B68C8757
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDB5647888]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A5F9A8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,8963C558AEBE
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,8963C558AEBE
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDF2897D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A6F9A8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0D9803B87847E
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0D9803B87847E
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDF28A7D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E4E0D0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,3D7E6B249854
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,3D7E6B249854
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDC8BDE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E4E0E8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,544C27AF5328
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,544C27AF5328
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDC8BDE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDB57CEC28]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,50F036B9127D
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,50F036B9127D
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDB5627888]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDB57FEC28]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0DE65CCAFD867
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0DE65CCAFD867
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDB5657888]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A3F9A8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,8CA8B5D04896
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,8CA8B5D04896
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDF2877D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A4F8D0]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,2AAB335B99BD
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,2AAB335B99BD
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDF2887D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E6E8E0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,56B8F7E62D64
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,56B8F7E62D64
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDC8BFE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E4E0E8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0E8FD5CC9AB02
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0E8FD5CC9AB02
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDC8BDE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDB57DEB50]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,9008DC43E49
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,9008DC43E49
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDB5637888]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDB57DEC28]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0AD7D64409567
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,0AD7D64409567
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDB5637888]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A3F9A8]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,41FA97DD369E
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,41FA97DD369E
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDF2877D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 128
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDF2A5F8D0]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,0E9981BECC81
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       dec       ecx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       r8,0E9981BECC81
       cmp       [rbp+8],r8
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDF2897D50]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 153
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E4E8E0]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,381615E3A6D8
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,381615E3A6D8
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDC8BDE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDC8E6E8F8]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,1B1EA247B804
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,1B1EA247B804
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDC8BFE9D0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDB57EEB50]; AttributeProof.Subjects.StackWithInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,1D8AD8B96983
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       add       rax,0F
       shr       rax,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rax
       jne       short M01_L00
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,1D8AD8B96983
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDB5647888]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 135
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; AttributeProof.Benchmarks.LocalsInitBench.WithoutInit()
       mov       ecx,[rcx+8]
       jmp       qword ptr [7FFDB57DEC28]; AttributeProof.Subjects.StackWithoutInit(Int32)
; Total bytes of code 9
```
```assembly
; AttributeProof.Subjects.StackWithoutInit(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+20]
       mov       rax,79387ADCD6BC
       mov       [rbp+8],rax
       mov       eax,ecx
       test      rax,rax
       je        short M01_L01
       mov       rdx,rax
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,20
       neg       rdx
       add       rdx,rsp
       jb        short M01_L00
       xor       edx,edx
M01_L00:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M01_L00
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,20
       lea       rax,[rsp+20]
M01_L01:
       test      ecx,ecx
       jl        short M01_L03
       test      ecx,ecx
       je        short M01_L04
       mov       byte ptr [rax],1
       lea       edx,[rcx-1]
       cmp       edx,ecx
       jae       short M01_L04
       mov       ecx,edx
       mov       byte ptr [rax+rcx],2
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+rcx]
       add       eax,edx
       mov       rcx,79387ADCD6BC
       cmp       [rbp+8],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+10]
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FFDB5637888]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

